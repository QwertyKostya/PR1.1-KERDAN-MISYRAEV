using System;
using System.Windows;
using System.Windows.Controls;

namespace PR1._1_KERDAN_MISYRAEV
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            // Проверяем, введены ли данные
            if (string.IsNullOrWhiteSpace(InputX.Text) || string.IsNullOrWhiteSpace(InputY.Text))
            {
                MessageBox.Show("Пожалуйста, введите значения X и Y.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            double x, y;
            if (!double.TryParse(InputX.Text, out x) || !double.TryParse(InputY.Text, out y))
            {
                MessageBox.Show("Некорректные входные данные. Пожалуйста, введите числовые значения.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Выбираем функцию в зависимости от выбранного переключателя
            double result = 0;
            if (Shx.IsChecked == true)
            {
                result = Math.Sinh(x); // Гиперболический синус
            }
            else if (X2.IsChecked == true)
            {
                result = Math.Pow(x, 2); // Квадрат числа
            }
            else if (Ex.IsChecked == true)
            {
                result = Math.Exp(x); // Экспоненциальная функция
            }

            ResultTextBox.Text = result.ToString(); // Выводим результат
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            InputX.Clear();
            InputY.Clear();
            ResultTextBox.Clear();
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение выхода", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result != MessageBoxResult.Yes)
            {
                e.Cancel = true;
            }
            base.OnClosing(e);
        }
    }
}