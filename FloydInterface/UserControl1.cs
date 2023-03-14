using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloydInterface
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InputPathBox.Text.Length == 0 || OutputPathBox.Text.Length == 0)
            {
                MessageBox.Show("Ошибка: одно поле или более не заполнено");
                return;
            }
            string inputPath = InputPathBox.Text;
            string outputPath = OutputPathBox.Text;

            MessageBox.Show("Форматирование завершено");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string filePath = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }
            InputPathBox.Text = filePath;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string filePath = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }
            OutputPathBox.Text = filePath;
        }
    }
}
