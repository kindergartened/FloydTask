using static FloydLib.Floyd;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> strings = GetString("C:/Users/glebo/OneDrive/Рабочий стол/text1.txt");
            
            Console.WriteLine(string.Join("\n", strings));
            for (int i = 0; i < strings.Count; i++)
            {
                strings[i] = DeleteSpaces(strings[i]);
            }
            
            strings = Formatting(strings, 30);
            Console.WriteLine(string.Join("\n", strings));
            
        }
    }
}