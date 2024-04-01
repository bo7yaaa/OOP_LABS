using System;
using System.Linq;
using System.Windows.Forms;

namespace ArrayOperations
{
    public partial class MainForm : Form
    {
        private TextBox textBox1;
        private Button calculateButton;
        private Label resultLabel;

        public MainForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // Розрахунок для одновимірного масиву
            double[] array = textBox1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                          .Select(double.Parse)
                                          .ToArray();

            // а) сума від’ємних елементів масиву
            double negativeSum = array.Where(x => x < 0).Sum();

            // б) добуток елементів масиву, розташованих між максимальним і мінімальним елементом
            double min = array.Min();
            double max = array.Max();
            double product = 1;

            bool foundMin = false;
            bool foundMax = false;

            foreach (double element in array)
            {
                if (element == min)
                {
                    foundMin = true;
                    continue;
                }

                if (element == max)
                {
                    foundMax = true;
                    break;
                }

                if (foundMin && !foundMax)
                {
                    product *= element;
                }
            }

            // Впорядкування елементів масиву за зростанням
            Array.Sort(array);

            // Виведення результатів в Label
            resultLabel.Text = $"а) Сума від’ємних елементів масиву: {negativeSum}\n";
            resultLabel.Text += $"б) Добуток елементів масиву, розташованих між максимальним і мінімальним елементом: {product}\n";
            resultLabel.Text += $"Впорядкований масив: {string.Join(" ", array)}\n";

            // Двовимірний масив
            int[,] twoDimensionalArray = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            // Вивести на екран увесь масив
            resultLabel.Text += "Двовимірний масив:\n";
            for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
                {
                    resultLabel.Text += twoDimensionalArray[i, j] + " ";
                }
                resultLabel.Text += "\n";
            }

            // Вивести на екран елемент, розміщений у правому верхньому куті масиву
            resultLabel.Text += $"Елемент, розміщений у правому верхньому куті масиву: {twoDimensionalArray[0, twoDimensionalArray.GetLength(1) - 1]}\n";

            // Вивести на екран елемент, розміщений у лівому нижньому куті масиву
            resultLabel.Text += $"Елемент, розміщений у лівому нижньому куті масиву: {twoDimensionalArray[twoDimensionalArray.GetLength(0) - 1, 0]}\n";
        }
    }
}
