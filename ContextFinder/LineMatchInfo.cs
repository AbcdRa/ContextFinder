using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ContextFinder
{
    class LineMatchInfo
    {
        public long indLine;
        public MatchCollection matchs;
        public string[] proposals;
        public string line;
        public LineMatchInfo(string pattern, string line, long indLine, bool isIgnoreCase)
        {
            this.indLine = indLine;
            this.line = line;
            matchs = Regex.Matches(line, pattern, isIgnoreCase?RegexOptions.IgnoreCase:RegexOptions.None);
            proposals = new string[matchs.Count];
            for(int i=0; i < matchs.Count; i++)
            {
                proposals[i] = GetProposal(line, matchs[i].Index, matchs[i].Length);
            }
        }

        public string GetProposal(string line, int index, int length)
        {
            int wordStart = index;
            int wordEnd = index + length;
            int start = 0;
            int end = line.Length-1;
            string endPattern = @"\n|[а-я\d]{3,}[\.\?\!]";
            var endmatchs = Regex.Matches(line, endPattern);
            foreach(Match match in endmatchs)
            {
                int endPos = match.Index + match.Length;
                if ( endPos >= start && endPos <= wordStart)
                {
                    start = endPos;
                }
                if (endPos <= end && endPos >= wordEnd)
                {
                    end = endPos;
                }
            }
            return line.Substring(start, end-start);
        }


        public bool isEmpty()
        {
            return matchs.Count == 0;
        }

        public override string ToString()
        {
            return "" + indLine;
        }

    }
}
