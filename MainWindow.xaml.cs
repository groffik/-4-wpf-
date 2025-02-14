using System;
using System.Windows;

namespace FunctionCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(TaskNumberTextBox.Text, out int taskNumber))
            {
                try
                {
                    double result = CalculateFunction(taskNumber);
                    ResultTextBlock.Text = $"Result of task {taskNumber}: {result}";
                }
                catch (Exception ex)
                {
                    ResultTextBlock.Text = $"Error: {ex.Message}";
                }
            }
            else
            {
                ResultTextBlock.Text = "Please enter a valid task number.";
            }
        }

        private double CalculateFunction(int taskNumber)
        {
            double x = 0, a = 0, b = 0, c = 0, k = 0, t = 0, p = 0, m = 0;
            double result = 0;

            switch (taskNumber)
            {
                case 1:
                    x = 3.5; b = 0.4;
                    a = Math.Log10(x);
                    result = Math.Exp(2 * x) + Math.Pow(9.7, Math.E);
                    break;

                case 2:
                    x = 1.3;
                    a = Math.Log(Math.Abs(x));
                    b = Math.Exp(2 * x) + a * x;
                    result = x * Math.Pow(a, 3) + Math.Pow(b, 2);
                    break;

                case 3:
                    x = 2.1; double p3 = 1;
                    k = 4; // Assuming k is needed for this task
                    a = Math.Exp(Math.Sqrt(k));
                    b = Math.Sin(Math.Pow(p3, 2)) + Math.Pow(x, 3);
                    result = Math.Pow(a, 3) / Math.Pow(b, 2);
                    break;

                case 4:
                    x = 2.7; t = -6;
                    a = Math.Log10(x);
                    b = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(t, 2));
                    result = Math.Sqrt(a - b * x) / a;
                    break;

                case 5:
                    t = 4.1; p = 3;
                    k = Math.Sqrt(p * t);
                    x = p * Math.Pow(t, 2) + Math.Sqrt(k);
                    result = Math.Pow(Math.Tan(Math.Pow(x, 2)), 3) + k * t;
                    break;

                case 6:
                    m = 2; x = 1.1;
                    a = Math.Sqrt(Math.Abs(x));
                    b = Math.Pow(x, 4) + Math.Pow(m, 2);
                    result = Math.Pow(Math.Sin(a + Math.Pow(Math.Tan(b), 3)), 2);
                    break;

                case 7:
                    k = 8.2; x = 5;
                    c = Math.Sqrt(Math.Abs(x));
                    a = Math.Pow(c, 4) + Math.Pow(k, 3);
                    result = Math.Pow(Math.Log10(a), 3) + Math.Pow(Math.Cos(x), 3);
                    break;

                case 8:
                    b = 2.2; c = 3.7;
                    a = Math.Sin(b);
                    x = a + Math.Pow(b + c, 3);
                    result = 7 * Math.Exp(Math.Abs(k)) + Math.Pow(Math.Cos(x), 4);
                    break;

                case 9:
                    k = 1; m = 1.8;
                    x = Math.Exp(m * x);
                    c = Math.Pow(Math.Cos(m), 2) + Math.Pow(k, 2);
                    result = (3.0 / 4.0) * (Math.Pow(x, 2) + Math.Pow(c, 2));
                    break;

                case 10:
                    x = 2.8; b = 1.3;
                    a = Math.Pow(b, 3) + Math.Log(Math.Abs(k));
                    c = Math.Pow(a, 2) + Math.Pow(Math.Sqrt(b), 2);
                    result = Math.Exp(t) + 5.8;
                    break;

                case 11:
                    b = 7; x = 2;
                    c = Math.Log10(Math.Abs(b));
                    a = Math.Pow(b + x, 3);
                    result = Math.Pow(c, 2) + Math.Sqrt(Math.Abs(a));
                    break;

                case 12:
                    double q = 2; b = 1.8;
                    t = Math.Pow(b, 3) + Math.Exp(Math.Sqrt(t));
                    x = Math.Pow(t, 3) + Math.Pow(b, 2);
                    result = Math.Pow(Math.Atan(Math.Abs(x)), 2);
                    break;

                case 13:
                    x = 1.9; a = -0.9;
                    double w = Math.Pow(x, 2) * Math.Sqrt(Math.Abs(a + x));
                    result = a * Math.Pow(x, 2) + Math.Pow(Math.Sin(w), 2);
                    break;

                case 14:
                    b = 6; k = 3.4;
                    t = Math.Pow(b, 3) + Math.Pow(k, 3);
                    a = Math.Sqrt(b) + t;
                    result = Math.Pow(Math.Sin(Math.Pow(a, 2) + Math.Pow(b, 2)), 4);
                    break;

                case 15:
                    double p15 = 2; a = 3.7;
                    b = Math.Abs(a) + Math.Sqrt(a + Math.Pow(p15, 2));
                    x = Math.Exp(b);
                    result = Math.Pow(Math.Cos(x), 3) + Math.Abs(a);
                    break;

                case 16:
                    x = 8.52; c = 9;
                    b = x + Math.Pow(c, 2);
                    a = Math.Pow(b, 1.0 / 3.0) + c;
                    result = Math.Pow(Math.Cos(b), 2) + b * Math.Pow(Math.Cos(Math.Pow(a, 2)), 4);
                    break;

                case 17:
                    x = 0.9; t = 2;
                    b = Math.Pow(Math.Log10(Math.Abs(x)), 2);
                    a = t * x + Math.Sqrt(b);
                    result = Math.Pow(Math.Cos(a + Math.Pow(b, 3)), 3);
                    break;

                case 18:
                    x = -8; b = 9.5;
                    a = Math.Sqrt(Math.Abs(x)) + Math.Exp(Math.Sqrt(b));
                    c = Math.Log10(a) + Math.Pow(b, 2);
                    result = Math.Pow(a, 3) / Math.Cos(c);
                    break;

                case 19:
                    x = 4; a = 3.7;
                    p = Math.Pow(x, 2) - Math.Sqrt(Math.Abs(x));
                    t = Math.Pow(x, 2) + Math.Pow(a, 2);
                    result = x * Math.Pow(p, 2) + Math.Pow(t, 5);
                    break;

                case 20:
                    x = 1.4; p = 1.6;
                    a = Math.Log(Math.Abs(x));
                    b = Math.Pow(x, 4) + Math.Pow(Math.Log10(p), 3);
                    result = Math.Pow(Math.Sin(a * x), 3) + Math.Sqrt(b) * Math.Cos(Math.Pow(x, 2));
                    break;

                case 21:
                    double n = 8.1; b = 1.6;
                    x = Math.Pow(n, b) + Math.Pow(b, 2);
                    a = Math.Sin(Math.Pow(x, 2) + Math.Pow(b, 2));
                    result = Math.Log(a) / Math.Log10(Math.Pow(b, 3));
                    break;

                case 22:
                    m = 5.7; p = 4;
                    t = Math.Sin(Math.Pow(m, 3));
                    x = Math.Pow(p, 2) + t;
                    result = Math.Pow(Math.Log10(Math.Abs(x + t)), 4);
                    break;

                case 23:
                    b = 0.3; x = 5.2;
                    a = Math.Log10(Math.Abs(x + Math.Pow(b, 2)));
                    t = x * Math.Pow(b, 2) + Math.Sqrt(x);
                    result = Math.Log(a + b) + Math.Pow(a, 2) / (a + t);
                    break;

                case 24:
                    t = 6.2; b = 1.8;
                    a = Math.Pow(t, 2) * b;
                    x = Math.Pow(a, 3) + Math.Sqrt(t + b);
                    result = Math.Cos(Math.Pow(x, 3)) - b * Math.Pow(Math.Sin(x), 2);
                    break;

                case 25:
                    a = 2; p = 2.6;
                    double z = 1; // Assuming z is needed for this task
                    x = Math.Exp(Math.Sqrt(m * z));
                    t = Math.Pow(p, 3) + Math.Pow(a, 3);
                    result = Math.Pow(x, 3) / Math.Pow(t, 2);
                    break;

                case 26:
                    b = 8.1; t = 2;
                    a = Math.Sqrt(b + Math.Pow(t, 2));
                    x = Math.Pow(Math.Cos(b), 2) + Math.Pow(Math.Sin(a), 2);
                    result = Math.Pow(x, 4) + Math.Sqrt(Math.Abs(x));
                    break;

                case 27:
                    t = -3; a = 76;
                    c = Math.Pow(t, 2) + Math.Sqrt(a);
                    x = Math.Log(Math.Abs(c * t)) + Math.Pow(a, 2);
                    result = Math.Tan(4 * x) + Math.Sin(Math.Pow(x, 2));
                    break;

                case 28:
                    b = 2.19; k = 1.7;
                    t = Math.Pow(k, 2) + Math.Sqrt(b);
                    a = b + Math.Pow(t, 2) * Math.Exp(1); // Assuming e' is e^1
                    result = Math.Pow(Math.Cos(Math.Pow(a, 3) + b), 4);
                    break;

                case 29:
                    a = 6; b = 4.3;
                    x = Math.Exp(2 * a) + Math.Sqrt(b);
                    p = x * (a + Math.Pow(b, 3));
                    result = Math.Pow(Math.Log10(Math.Abs(p)), 3) + x;
                    break;

                case 30:
                    t = 3; b = 4.2;
                    a = t + Math.Pow(b, 3);
                    x = Math.Pow(t, 2) * Math.Sqrt(Math.Abs(a + b));
                    result = Math.Pow(Math.Log(Math.Abs(x + Math.Pow(a, 2))), 3);
                    break;

                default:
                    throw new ArgumentException("Invalid task number. Please enter a number between 1 and 30.");
            }

            return result;
        }
    }
}
