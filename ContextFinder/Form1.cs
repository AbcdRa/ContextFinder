using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContextFinder
{
    public partial class Form1 : Form
    {
        private string filename;
        private Encoding encoding;
        private long lineNums;
        public Form1()
        {
            InitializeComponent();
            dudEncoding.Items.Clear();
            dudEncoding.Items.Add(Encoding.ASCII);
            dudEncoding.Items.Add(Encoding.UTF8);
            dudEncoding.Items.Add(Encoding.GetEncoding("windows-1251"));
            encoding = Encoding.GetEncoding("windows-1251");
        }

        private Encoding GetEncoding()
        {
            Encoding pvEncode = encoding;
            try
            {
                encoding = (Encoding)dudEncoding.SelectedItem;
            }
            catch (Exception) {}
            if (encoding == null) encoding = pvEncode;
            return encoding;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void initNudBound()
        {
            lineNums = countLines(filename);
            nudStartLineIndex.Minimum = 1;
            nudStartLineIndex.Maximum = lineNums;
            nudStartLineIndex.Value = 1;
           
            nudEndLineIndex.Minimum = 2;
            nudEndLineIndex.Maximum = lineNums + 1;
            nudEndLineIndex.Value = lineNums;
          
            nudStartLineIndex.Enabled = true;
            nudEndLineIndex.Enabled = true;
        }


        private long countLines(string filename)
        {
            long linesCount = 1;
            int nextLine = '\n';
            using (var streamReader = new StreamReader(
                new BufferedStream(
                    File.OpenRead(filename), 10 * 1024 * 1024))) // буфер в 10 мегабайт
            {
                while (!streamReader.EndOfStream)
                {
                    if (streamReader.Read() == nextLine) linesCount++;
                }
            }

            return linesCount;
        }

        

        private void bChooseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            filename = openFileDialog1.FileName;
            lFileLog.Text = "Открыт файл: " + filename;
            initNudBound();
            bFind.Enabled = true;
            rtbContext.Text = (System.IO.File.ReadAllText(filename, GetEncoding()));
            showText();
        }


        private void showText()
        {
            long start = Decimal.ToInt64(nudStartLineIndex.Value);
            long end = Decimal.ToInt64(nudEndLineIndex.Value);
            rtbContext.Text = "";
            int buffRowSize = 20;
            int buffSize = 10485760;
            using (var streamReader = new StreamReader(
                new BufferedStream(
                    File.OpenRead(filename), buffSize),GetEncoding())) // буфер в 10 мегабайт
            {
                StringBuilder buff = new StringBuilder();
                for (long i = start; i < end; i++)
                {
                    if (streamReader.EndOfStream) break;
                    string line = streamReader.ReadLine();
                    buff.Append(line+'\n');
                    if((i-start+1)%buffRowSize == 0)
                    {
                        rtbContext.AppendText(buff.ToString());
                    }
                }
            }
            
        }

        private void bFind_Click(object sender, EventArgs e)
        {
            long start = Decimal.ToInt64(nudStartLineIndex.Value);
            long end = Decimal.ToInt64(nudEndLineIndex.Value);
            string pattern = tbPatternInput.Text;
            ContextInfo contextInfo = new ContextInfo(filename, pattern, start, end, encoding);
            lbPatterns.Items.Add(contextInfo);
        }

        private void nudEndLineIndex_ValueChanged(object sender, EventArgs e)
        {
            showText();
        }

        private void nudStartLineIndex_ValueChanged(object sender, EventArgs e)
        {
            showText();
        }

        private void updateContexts(ContextInfo contextInfo)
        {
            lbContexts.Items.Clear();
            foreach (LineMatchInfo matchInfo in contextInfo.matches)
            {
                lbContexts.Items.Add(matchInfo);   
            }
        }

        private void lbPatterns_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContextInfo contextInfo = (ContextInfo) lbPatterns.SelectedItem;
            if (contextInfo == null) return;
            lcountExtraction.Text = "" + contextInfo.countExtracting();
            updateContexts(contextInfo);
        }

        private void lbContexts_SelectedIndexChanged(object sender, EventArgs e)
        {
            LineMatchInfo matchInfo = (LineMatchInfo)lbContexts.SelectedItem;
            if (matchInfo == null) return;
            rtbContext.Text = "";
            for (int i=0; i < matchInfo.matchs.Count; i++)
            {
                Match match = matchInfo.matchs[i];

                rtbContext.AppendText(matchInfo.indLine + "\t" + matchInfo.line + "\t");
                int propOffset = matchInfo.line.IndexOf(matchInfo.proposals[i]);
                rtbContext.SelectionFont = new Font(rtbContext.Font, FontStyle.Regular);
                
                rtbContext.AppendText(matchInfo.proposals[i].Substring(0, -propOffset + match.Index));
                rtbContext.SelectionFont = new Font(rtbContext.Font, FontStyle.Underline);
                rtbContext.AppendText(match.Value);
                rtbContext.SelectionFont = new Font(rtbContext.Font, FontStyle.Regular);
                rtbContext.AppendText(matchInfo.proposals[i].Substring(-propOffset + match.Index + match.Length) + "\n");


            }
            
        }

        private void cbIgnoreCase_CheckedChanged(object sender, EventArgs e)
        {
            ContextInfo.isIgnoreCase = cbIgnoreCase.Checked;
        }

        private void bSaveFile_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            int buffSize = 10485760;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    using (var streamWriter = new StreamWriter(new BufferedStream(
                        myStream, buffSize), GetEncoding())) // буфер в 10 мегабайт
                    {
                        ContextInfo contextInfo = (ContextInfo) lbPatterns.SelectedItem;
                        if(contextInfo == null)
                        {
                            MessageBox.Show("Не выбран паттерн");
                            myStream.Close();
                            return;
                        }
                        foreach(LineMatchInfo matchInfo in contextInfo.matches)
                        for (int i = 0; i < matchInfo.matchs.Count; i++)
                        {
                            
                            streamWriter.WriteLine(matchInfo.indLine + "\t" + matchInfo.line + "\t" +
                                matchInfo.proposals[i]);

                        }
                    }
                    myStream.Close();
                }
            }
        }
    }
}
