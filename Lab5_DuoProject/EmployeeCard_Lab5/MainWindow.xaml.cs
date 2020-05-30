using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace EmployeeCard_Lab5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] imgsArr = new string[2] {      "KliffBut.jpg",
                                                "Jotaro_Lena.jpg" };
                                                
        string[] lastNameArr = new string[2] {  "Бут",
                                                "Куджо" };
                                                
        string[] firstNameArr = new string[2] { "Клифф",
                                                "Джолена" };
        
        string[] middleNameArr = new string[2] {"Като",
                                                "ДжоДжо" };
        
        string[] positionArr = new string[2] {  "Телохранитель",
                                                "Пионер, стандоцкай" };
                                                    
        string[] departmentArr = new string[2] {"Отдел безопасности Рика Далтона",
                                                "Пионерлагерь Совёнок" };
        
        string[] statusArr = new string[2] {    "На тренировке",
                                                "В походе" };
        int i = 0;
        
        public MainWindow()
        {
            InitializeComponent();

            //img_Banner.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/" + imgsArr[i]));
            
            //lastNameLb.Content = lastNameArr[i];
            //firstNameLb.Content = firstNameArr[i];
            //middleNameLb.Content = middleNameArr[i];
            //positionLb.Content = positionArr[i];
            //departmentLb.Content = departmentArr[i];
            //statusLb.Content = statusArr[i];
        }

        //private void img_Banner_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    if (i == 1)
        //        i = 0;
        //    else
        //        i++;

        //    img_Banner.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/" + imgsArr[i]));

        //    lastNameLb.Content = lastNameArr[i];
        //    firstNameLb.Content = firstNameArr[i];
        //    middleNameLb.Content = middleNameArr[i];
        //    positionLb.Content = positionArr[i];
        //    departmentLb.Content = departmentArr[i];
        //    statusLb.Content = statusArr[i];
        //}

        //private void callBut_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("На связи...");
        //}

        //private void writeBut_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Передаю привет всем кто ставит лайки, передаю привет всем кто ставит дизлайки...");
        //}

        //private void posholOtsydaBut_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Уволен...");
        //}
    }
}