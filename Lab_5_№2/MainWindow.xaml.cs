using Microsoft.Win32;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_5__2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Получение введенных чисел
            if (!int.TryParse(NTextBox, out int n) || n <= 0)
            {
                ResultTextBlock.Text = "Некорректное количество чисел.";
                return;
            }

            // Создание массива для случайных чисел
            int[] numbers = new int[n];
            Random random = new Random();

            // Генерация случайных чисел
            for (int i = 0; i < n; i++)
            {
                numbers[i] = random.Next(-10, 10); // Случайные числа от -10 до 9
            }

            // Нахождение чисел <3 и их перемножение
            int product = 1;
            foreach (int number in numbers)
            {
                if (number < 3)
                {
                    product *= number;
                }
            }

            // Вывод результата
            ResultTextBlock.Text = $"Произведение чисел <3: {product}";
        }
    
private void Exit_click(object sender, RoutedEventArgs e)
            {
                Close();
            }
            private void Open_click(object sender, RoutedEventArgs e)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                if (openFileDialog.ShowDialog() == true)
                {
                    // Получаем путь к файлу
                    string filePath = openFileDialog.FileName;

                    // Открываем файл и считываем данные
                    try
                    {

                        MessageBox.Show($"Содержимое файла:");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка открытия файла: {ex.Message}");
                    }
                }
            }
           
            private void Button_Click_1(object sender, RoutedEventArgs e)

            {
                MessageBox.Show("Орлов Арсений, \n Ввести n целых чисел. Найти произведение чисел <3. Результат вывести на экран. \n ИСП-34", "О программе");
            }
            private void Save_Click(object sender, RoutedEventArgs e)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == true)
                {
                    // Получаем путь к файлу
                    string filePath = saveFileDialog.FileName;

                    // Сохраняем данные в файл 
                    try
                    {

                       //edit github
                        MessageBox.Show("Файл успешно сохранен.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка сохранения файла: {ex.Message}");
                    }
                }
            }

            private void MenuItem_Click_1(object sender, RoutedEventArgs e)
            {

            }
              
        }
    }

        
    


    
