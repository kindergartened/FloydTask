using static FloydLib.Floyd;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> strings = ReadString("C:/Users/nevzo/Desktop/text1.txt");
            
            Console.WriteLine(string.Join("\n", strings));
            for (int i = 0; i < strings.Count; i++)
            {
                strings[i] = DeleteSpaces(strings[i]);
            }
            
            strings = Formatting(strings, 20);
            Console.WriteLine(string.Join("\n", strings));
            WriteString(strings, "C:/Users/nevzo/Desktop/out.txt");
        }
    }
}