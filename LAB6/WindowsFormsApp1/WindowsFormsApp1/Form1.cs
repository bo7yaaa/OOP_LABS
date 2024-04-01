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

        private void button1_Click(object sender, EventArgs e)
        {
            // Отримання значень сторін з текстових полів
            double sideA, sideB, sideC;
            if (!double.TryParse(textBox1.Text, out sideA) ||
                !double.TryParse(textBox2.Text, out sideB) ||
                !double.TryParse(textBox3.Text, out sideC))
            {
                MessageBox.Show("Будь ласка, введіть коректні числові значення для сторін трикутника.", "Помилка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка на існування трикутника
            if (!IsTriangleValid(sideA, sideB, sideC))
            {
                MessageBox.Show("Трикутник з такими сторонами не існує.", "Помилка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Обчислення площі трикутника за формулою Герона
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));

            // Виведення результату
            MessageBox.Show($"Площа трикутника: {area:F2} кв. одиниць", "Результат",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool IsTriangleValid(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}
