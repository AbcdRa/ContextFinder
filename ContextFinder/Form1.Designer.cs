
namespace ContextFinder
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dudEncoding = new System.Windows.Forms.DomainUpDown();
            this.bFind = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPatternInput = new System.Windows.Forms.TextBox();
            this.nudEndLineIndex = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudStartLineIndex = new System.Windows.Forms.NumericUpDown();
            this.lFileLog = new System.Windows.Forms.Label();
            this.bChooseFile = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lbPatterns = new System.Windows.Forms.ListBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.lcountExtraction = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.lbContexts = new System.Windows.Forms.ListBox();
            this.rtbContext = new System.Windows.Forms.RichTextBox();
            this.cbIgnoreCase = new System.Windows.Forms.CheckBox();
            this.bSaveFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndLineIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartLineIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bSaveFile);
            this.splitContainer1.Panel1.Controls.Add(this.cbIgnoreCase);
            this.splitContainer1.Panel1.Controls.Add(this.dudEncoding);
            this.splitContainer1.Panel1.Controls.Add(this.bFind);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.tbPatternInput);
            this.splitContainer1.Panel1.Controls.Add(this.nudEndLineIndex);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.nudStartLineIndex);
            this.splitContainer1.Panel1.Controls.Add(this.lFileLog);
            this.splitContainer1.Panel1.Controls.Add(this.bChooseFile);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 105;
            this.splitContainer1.TabIndex = 0;
            // 
            // dudEncoding
            // 
            this.dudEncoding.Items.Add("test");
            this.dudEncoding.Items.Add("test2");
            this.dudEncoding.Location = new System.Drawing.Point(332, 12);
            this.dudEncoding.Name = "dudEncoding";
            this.dudEncoding.Size = new System.Drawing.Size(161, 20);
            this.dudEncoding.TabIndex = 18;
            this.dudEncoding.Text = "Кодировка";
            // 
            // bFind
            // 
            this.bFind.Enabled = false;
            this.bFind.Location = new System.Drawing.Point(212, 71);
            this.bFind.Name = "bFind";
            this.bFind.Size = new System.Drawing.Size(75, 23);
            this.bFind.TabIndex = 17;
            this.bFind.Text = "Поиск";
            this.bFind.UseVisualStyleBackColor = true;
            this.bFind.Click += new System.EventHandler(this.bFind_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Введите слово: ";
            // 
            // tbPatternInput
            // 
            this.tbPatternInput.Location = new System.Drawing.Point(106, 71);
            this.tbPatternInput.Name = "tbPatternInput";
            this.tbPatternInput.Size = new System.Drawing.Size(100, 20);
            this.tbPatternInput.TabIndex = 15;
            // 
            // nudEndLineIndex
            // 
            this.nudEndLineIndex.Enabled = false;
            this.nudEndLineIndex.Location = new System.Drawing.Point(332, 45);
            this.nudEndLineIndex.Name = "nudEndLineIndex";
            this.nudEndLineIndex.Size = new System.Drawing.Size(112, 20);
            this.nudEndLineIndex.TabIndex = 14;
            this.nudEndLineIndex.ValueChanged += new System.EventHandler(this.nudEndLineIndex_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "до";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Диапазон поиска по строкам с ";
            // 
            // nudStartLineIndex
            // 
            this.nudStartLineIndex.Enabled = false;
            this.nudStartLineIndex.Location = new System.Drawing.Point(188, 45);
            this.nudStartLineIndex.Name = "nudStartLineIndex";
            this.nudStartLineIndex.Size = new System.Drawing.Size(112, 20);
            this.nudStartLineIndex.TabIndex = 11;
            this.nudStartLineIndex.ValueChanged += new System.EventHandler(this.nudStartLineIndex_ValueChanged);
            // 
            // lFileLog
            // 
            this.lFileLog.AutoSize = true;
            this.lFileLog.Location = new System.Drawing.Point(118, 17);
            this.lFileLog.Name = "lFileLog";
            this.lFileLog.Size = new System.Drawing.Size(90, 13);
            this.lFileLog.TabIndex = 10;
            this.lFileLog.Text = "Файл не открыт";
            // 
            // bChooseFile
            // 
            this.bChooseFile.Location = new System.Drawing.Point(12, 12);
            this.bChooseFile.Name = "bChooseFile";
            this.bChooseFile.Size = new System.Drawing.Size(100, 23);
            this.bChooseFile.TabIndex = 9;
            this.bChooseFile.Text = "Выбрать файл";
            this.bChooseFile.UseVisualStyleBackColor = true;
            this.bChooseFile.Click += new System.EventHandler(this.bChooseFile_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lbPatterns);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(800, 341);
            this.splitContainer2.SplitterDistance = 179;
            this.splitContainer2.TabIndex = 0;
            // 
            // lbPatterns
            // 
            this.lbPatterns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPatterns.FormattingEnabled = true;
            this.lbPatterns.Location = new System.Drawing.Point(0, 0);
            this.lbPatterns.Name = "lbPatterns";
            this.lbPatterns.Size = new System.Drawing.Size(179, 341);
            this.lbPatterns.TabIndex = 0;
            this.lbPatterns.SelectedIndexChanged += new System.EventHandler(this.lbPatterns_SelectedIndexChanged);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.lcountExtraction);
            this.splitContainer3.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(617, 341);
            this.splitContainer3.SplitterDistance = 119;
            this.splitContainer3.TabIndex = 0;
            // 
            // lcountExtraction
            // 
            this.lcountExtraction.AutoSize = true;
            this.lcountExtraction.Location = new System.Drawing.Point(115, 4);
            this.lcountExtraction.Name = "lcountExtraction";
            this.lcountExtraction.Size = new System.Drawing.Size(13, 13);
            this.lcountExtraction.TabIndex = 1;
            this.lcountExtraction.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Кол-во вхождений: ";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.lbContexts);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.rtbContext);
            this.splitContainer4.Size = new System.Drawing.Size(617, 218);
            this.splitContainer4.SplitterDistance = 67;
            this.splitContainer4.TabIndex = 0;
            // 
            // lbContexts
            // 
            this.lbContexts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbContexts.FormattingEnabled = true;
            this.lbContexts.Location = new System.Drawing.Point(0, 0);
            this.lbContexts.Name = "lbContexts";
            this.lbContexts.Size = new System.Drawing.Size(67, 218);
            this.lbContexts.TabIndex = 0;
            this.lbContexts.SelectedIndexChanged += new System.EventHandler(this.lbContexts_SelectedIndexChanged);
            // 
            // rtbContext
            // 
            this.rtbContext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbContext.HideSelection = false;
            this.rtbContext.Location = new System.Drawing.Point(0, 0);
            this.rtbContext.Name = "rtbContext";
            this.rtbContext.ReadOnly = true;
            this.rtbContext.Size = new System.Drawing.Size(546, 218);
            this.rtbContext.TabIndex = 0;
            this.rtbContext.Text = "";
            // 
            // cbIgnoreCase
            // 
            this.cbIgnoreCase.AutoSize = true;
            this.cbIgnoreCase.Checked = true;
            this.cbIgnoreCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIgnoreCase.Location = new System.Drawing.Point(294, 74);
            this.cbIgnoreCase.Name = "cbIgnoreCase";
            this.cbIgnoreCase.Size = new System.Drawing.Size(141, 17);
            this.cbIgnoreCase.TabIndex = 19;
            this.cbIgnoreCase.Text = "Игнорировать регистр";
            this.cbIgnoreCase.UseVisualStyleBackColor = true;
            this.cbIgnoreCase.CheckedChanged += new System.EventHandler(this.cbIgnoreCase_CheckedChanged);
            // 
            // bSaveFile
            // 
            this.bSaveFile.Location = new System.Drawing.Point(441, 71);
            this.bSaveFile.Name = "bSaveFile";
            this.bSaveFile.Size = new System.Drawing.Size(75, 23);
            this.bSaveFile.TabIndex = 20;
            this.bSaveFile.Text = "Сохранить";
            this.bSaveFile.UseVisualStyleBackColor = true;
            this.bSaveFile.Click += new System.EventHandler(this.bSaveFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Простой поиск контекста";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudEndLineIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartLineIndex)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button bFind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPatternInput;
        private System.Windows.Forms.NumericUpDown nudEndLineIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudStartLineIndex;
        private System.Windows.Forms.Label lFileLog;
        private System.Windows.Forms.Button bChooseFile;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox lbPatterns;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DomainUpDown dudEncoding;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ListBox lbContexts;
        private System.Windows.Forms.RichTextBox rtbContext;
        private System.Windows.Forms.Label lcountExtraction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbIgnoreCase;
        private System.Windows.Forms.Button bSaveFile;
    }
}

