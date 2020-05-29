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
        string[] imgsArr = new string[5] {      "God.jpg",
                                                "van.jpg",
                                                "RicardoHerington.jpg",
                                                "Jotaro_Lena.jpg",
                                                "Shcheglov.jpg" };
                                                
        string[] lastNameArr = new string[5] {  "Herrington",
                                                "Darkholm",
                                                "Milos",
                                                "Kujo",
                                                "Щеглов" };
                                                
        string[] firstNameArr = new string[5] { "Billy",
                                                "Van",
                                                "Ricardo",
                                                "Jolena",
                                                "Максим" };
        
        string[] middleNameArr = new string[5] {"Aniki",
                                                "Tadashi",
                                                "Ronaldinho",
                                                "JoJo",
                                                "Евгеньевич" };
        
        string[] positionArr = new string[5] {  "Boss",
                                                "Master, Performance Artist",
                                                "Dancer, stand user",
                                                "Пионер, стандоцкай",
                                                "Старший преподаватель" };
                                                    
        string[] departmentArr = new string[5] {"Gym",
                                                "Dungeon",
                                                "Gay patry",
                                                "Пионерлагерь Совёнок",
                                                "САПР" };
        
        string[] statusArr = new string[5] {    "В Иисусьей качалке",
                                                "Садит картошечку",
                                                "In the gym",
                                                "В походе",
                                                "Стримит" };
        int i = 4;
        
        public MainWindow()
        {
            InitializeComponent();

            img_Banner.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/" + imgsArr[i]));
            
            lastNameLb.Content = lastNameArr[i];
            firstNameLb.Content = firstNameArr[i];
            middleNameLb.Content = middleNameArr[i];
            positionLb.Content = positionArr[i];
            departmentLb.Content = departmentArr[i];
            statusLb.Content = statusArr[i];
        }

        private void img_Banner_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (i == 0)
                i = 4;
            else
                i--;

            img_Banner.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/" + imgsArr[i]));
            
            lastNameLb.Content = lastNameArr[i];
            firstNameLb.Content = firstNameArr[i];
            middleNameLb.Content = middleNameArr[i];
            positionLb.Content = positionArr[i];
            departmentLb.Content = departmentArr[i];
            statusLb.Content = statusArr[i];
        }

        private void callBut_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("За ним уже выехали...");
        }

        private void writeBut_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Передаю привет всем кто ставит лайки, передаю привет всем кто ставит дизлайки...");
        }

        private void posholOtsydaBut_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("На помойку...");
        }
    }
}