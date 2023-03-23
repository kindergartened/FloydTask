using System.Text;

namespace FloydLib
{
    public class Floyd
    {
        public static string DeleteSpaces(string str)
        {
            while (str.Contains("  ")) str = str.Replace("  ", " ");
            
            return str.Trim();
        }
        public static List<string> ReadString(string url)
        {
            StreamReader sr = new(url);
            List<string> res = new();
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine() ?? "";
                if (!IsSpacyStr(line)) break;
                res.Add(line);
            }
            sr.Close();
            return res;
        }
        public static void WriteString(List<string> str, string url)
        {
            StreamWriter sw = new(url, false);
            foreach (string line in str)
            {
                sw.WriteLine(line);
            }
            sw.Close();
        }
        public static bool IsSpacyStr(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ') return true;
            }
            return false;
        }

        public static List<string> Formatting(List<string> str, int n)
        {
            string tempStr = string.Join(" ", str);
            string[] words = tempStr.Split(' ');
            string line;
            List<string> res = new();
            int i = 0;
            while (i < words.Length)
            {
                line = "";
                while (line.Length < n)
                {
                    if (i == words.Length - 1)
                    {
                        line += words[i++];
                        line += new string(Enumerable.Repeat(' ', n - line.Length - 1).ToArray());
                        break;
                    }
                    if (line.Length + words[i].Length + 1 > n)
                    {
                        line += new string(Enumerable.Repeat(' ', n - line.Length - 1).ToArray());
                        break;
                    }
                    line += line.Length + words[i].Length + 1 == n ? words[i++] : words[i++] + ' ';
                }
                res.Add(line);
            }
            
            return res;
        }

    }
}