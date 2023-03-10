namespace FloydLib
{
    public class Floyd
    {
        public static string DeleteSpaces(string str)
        {
            while (str.Contains("  ")) str = str.Replace("  ", " ");
            
            return str.Trim();
        }
        public static List<string> GetString(string url)
        {
            StreamReader sr = new(url);
            List<string> res = new();
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine() ?? "";
                if (!IsSpacyStr(line)) break;
                res.Add(line);
            }
            return res;
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
            string line = "";
            List<string> res = new();
            for (int i = 0; i < words.Length; i++)
            {

                line = "";
                while (i != words.Length - 1 && line.Length + words[i++].Length < n)
                {
                    line += words[i++] + " ";
                }

                res.Add(line);
            }
            
            return res;
        }

    }
}