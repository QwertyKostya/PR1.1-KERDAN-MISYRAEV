using System;
using System.Windows;

namespace PR1._1_KERDAN_MISYRAEV
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            // Получение введённых значений
            double x = double.Parse(txtX.Text);
            int m = int.Parse(txtM.Text);

            string result = "";

            if (rbOption1.IsChecked == true)
            {
                // Логика для первого варианта
                result = $"Результат для Варианта 1: {x * m}";
            }
            else if (rbOption2.IsChecked == true)
            {
                // Логика для второго варианта
                result = $"Результат для Варианта 2: {(x + m)}";
            }
            else if (rbOption3.IsChecked == true)
            {
                // Логика для третьего варианта
                result = $"Результат для Варианта 3: {Math.Pow(x, m)}";
            }

            lblResult.Text = result;
        }
    }
}