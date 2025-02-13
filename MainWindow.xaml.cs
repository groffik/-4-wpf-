using System;
using System.Windows;

namespace практическая_4_wpf
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
                    ResultTextBlock.Text = $"результат {taskNumber}: {result}";
                }
                catch (Exception ex)
                {
                    ResultTextBlock.Text = $"ошибка: {ex.Message}";
                }
            }
            else
            {
                ResultTextBlock.Text = "Введдите действительнвй номер задачи.";
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
                    k = 4; 
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

                default:
                    throw new ArgumentException("Напишите число от 1 до 15.");
            }

            return result;
        }
    }
}