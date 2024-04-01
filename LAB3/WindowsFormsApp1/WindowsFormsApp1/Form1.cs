using System;
using System.Windows.Forms;

namespace FigureCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRectangle_Click_1(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle(5, 4);
            MessageBox.Show($"Площа прямокутника: {rectangle.CalculateArea()}, Периметр: {rectangle.CalculatePerimeter()}");
        }

        private void BtnCircle_Click_1(object sender, EventArgs e)
        {
            Circle circle = new Circle(3);
            MessageBox.Show($"Площа круга: {circle.CalculateArea()}, Окружність: {circle.CalculatePerimeter()}");
        }

        private void BtnTrapezium_Click_1(object sender, EventArgs e)
        {
            Trapezium trapezium = new Trapezium(3, 4, 5, 6, 7);
            MessageBox.Show($"Площа трапеції: {trapezium.CalculateArea()}, Периметр: {trapezium.CalculatePerimeter()}");
        }
    }

    public abstract class Figure
    {
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }

    public class Rectangle : Figure
    {
        private readonly double length;
        private readonly double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double CalculateArea()
        {
            return length * width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (length + width);
        }
    }

    public class Circle : Figure
    {
        private readonly double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }

    public class Trapezium : Figure
    {
        private readonly double base1;
        private readonly double base2;
        private readonly double height;
        private readonly double side1;
        private readonly double side2;

        public Trapezium(double base1, double base2, double height, double side1, double side2)
        {
            this.base1 = base1;
            this.base2 = base2;
            this.height = height;
            this.side1 = side1;
            this.side2 = side2;
        }

        public override double CalculateArea()
        {
            return 0.5 * (base1 + base2) * height;
        }

        public override double CalculatePerimeter()
        {
            return base1 + base2 + side1 + side2;
        }
    }
}
