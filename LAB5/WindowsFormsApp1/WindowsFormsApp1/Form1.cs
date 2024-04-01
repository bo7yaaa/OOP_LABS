using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text;
            string resultText = RemoveSpaces(inputText);
            MessageBox.Show(resultText, "Результат");
        }

        private string RemoveSpaces(string input)
        {
            // Розділити введений текст за всіма символами пропуску
            string[] parts = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Повернути результуючий рядок, об'єднавши частини без пропусків
            return string.Join("", parts);
        }

    }
}
