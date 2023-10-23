using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace prak111//ало почему не меняется
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

        private void Program_Click(object sender, RoutedEventArgs e) //Кнопка "О программе"
        {
            MessageBox.Show("Коннов Вадим Сергеевич,ИСП-34,вариант 5.\n Вычислить сумму целых случайных чисел, распределенных в диапазоне от 55 до 70ы,\r\nпока эта сумма не превышает некоторого числа K. Вывести на экран\r\nсгенерированные числа, значение суммы, и количество сгенерированных чисел.");
        }

        private void Exit_Click(object sender, RoutedEventArgs e) //Кнопка "Выход"
        {
            this.Close();
        }

        private void clear_Click(object sender, RoutedEventArgs e) //Кнопка "Очистить",которая очищает элементы TextBox от записей
        {
            kolvo.Clear();
            spisok.Clear();
            summa.Clear();
            chislok.Clear();
        }

        private void rez_Click(object sender, RoutedEventArgs e) //Кнопка "Рассчитать"
        {
         
            int k = int.Parse(chislok.Text);//Получаем значение числа K из элемента TextBox
            int sum = 0;//Вводим переменную,которая отвечает за сумму чисел и приравниваем ее к нулю
            int count = 0;//Вводим переменную,которая отвечает за количество чисел и приравниваем ее к нулю
            
            Random rnd = new Random();//Создаем класс Random для генерации случайных чисел

            while (sum <= k)//Выполняем цикл,пока сумма чисел не превысит значение числа K
            {
                
                int RandomNumber = rnd.Next(55,70);//Генерируем число в заданном диапазоне и сохраняем ее в переменную RandomNumber
                sum += RandomNumber;//Увеличиваем сумму на сгенерированное число
                count++;//Увеличиваем счетчик чисел на 1
                spisok.Text += RandomNumber.ToString() + " ";//Вывод сгенерированного числа в элемент TextBox

            }

            summa.Text += sum.ToString();//Вывод суммы в элемент TextBox
            kolvo.Text += count.ToString();//Вывод счетчика количества чисел в элемент TextBox
            

        }
            
        
        
    }
}
