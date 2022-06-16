using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ContextFinder
{
    class ContextInfo
    {
        public static bool isIgnoreCase = true;
        public List<LineMatchInfo> matches = new List<LineMatchInfo>();
        string pattern;

        public ContextInfo(string filename, string pattern, long start, long end, Encoding encoding)
        {
            int buffSize = 10485760;
            this.pattern = pattern;
            using (var streamReader = new StreamReader(
                new BufferedStream(
                    File.OpenRead(filename), buffSize), encoding)) // буфер в 10 мегабайт
            {
                for (long i = start; i < end; i++)
                {
                    if (streamReader.EndOfStream) break;
                    string line = streamReader.ReadLine();
                    LineMatchInfo matchInfo = new LineMatchInfo(pattern, line, i, isIgnoreCase);
                    if (!matchInfo.isEmpty()) matches.Add(matchInfo);
                }
            }
        }

        public override string ToString()
        {
            return pattern;
        }

        public long countExtracting()
        {
            long count = 0;
            foreach(LineMatchInfo match in matches)
            {
                count += match.matchs.Count;
            }
            return count;
        }
    }
}
