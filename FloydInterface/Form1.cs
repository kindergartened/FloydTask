using static FloydLib.Floyd;

namespace FloydInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int N = 0;
            if (InputPathBox.Text.Length == 0)
            {
                MessageBox.Show("Ошибка: поле не заполнено");
                return;
            }
            try
            {
                N = int.Parse(enterN.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка: неверная длина");
                return;
            }

            string inputPath = InputPathBox.Text;
            List<string> strings = ReadString(inputPath);
            for (int i = 0; i < strings.Count; i++)
            {
                strings[i] = DeleteSpaces(strings[i]);
            }
            strings = Formatting(strings, N);
            int lenFile = inputPath.Split("\\")[^1].Length;
            string outPath = inputPath.Substring(0, inputPath.Length - lenFile) + "out.txt";
            WriteString(strings, outPath);

            MessageBox.Show("Форматирование завершено");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }
            InputPathBox.Text = filePath;
        }
    }
}