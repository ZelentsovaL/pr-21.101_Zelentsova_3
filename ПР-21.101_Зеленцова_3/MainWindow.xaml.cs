using System;
using System.Collections.Generic;
using System.Linq;
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


namespace ПР_21._101_Зеленцова_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_sort_Click(object sender, RoutedEventArgs e)
        {
            int N;
            int max;
            int min;
            try
            {
                N = int.Parse(tb_N.Text);
                min = int.Parse(tb_min.Text);
                max = int.Parse(tb_max.Text);

            }
            catch(Exception) 
            {
                MessageBox.Show("Введите числа!");
                return;
            }
            

            if(tb_N.Text == string.Empty)
            {
                MessageBox.Show("Введите размер массива!");
                return;
            }
            if ((tb_min.Text == string.Empty) || (tb_max.Text == string.Empty))
            {
                MessageBox.Show("Введите границы!");
                return;
            }
            if (N <= 0)
            {
                MessageBox.Show("Размер массива должен быть положительным числом");
                return;
            }
            if (min > max)
            {
                MessageBox.Show("Нижняя граница диапазона должна быть меньше верхней границы");
                return;
            }


            try
            {
                int[] massiv = new int[N];

                Random random = new Random();
                for (int i = 0; i < massiv.Length; i++)
                {
                    massiv[i] = random.Next(min, max);
                }

                int[] sorted = new int[N];
                int count = 0;

                for (int i = 0; i < massiv.Length; i++)
                {
                    if (massiv[i] % 2 == 0)
                    {
                        sorted[count] = massiv[i];
                        count++;
                    }
                }
                for (int i = 0; i < massiv.Length; i++)
                {
                    if (massiv[i] % 2 != 0)
                    {
                        sorted[count] = massiv[i];
                        count++;
                    }
                }
                string array = "";
                for (int i = 0; i < massiv.Length; i++)
                {
                    array += sorted[i] + " ";
                }

                MessageBox.Show(array);
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }



    }
     
    
}

