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

namespace EmployeeCard_Lab5
{
    /// <summary>
    /// Логика взаимодействия для Card.xaml
    /// </summary>
    public partial class Card : UserControl
    {
        public Card()
        {
            InitializeComponent();
        }

        #region имя
        public static readonly DependencyProperty cardFirstNameProperty = DependencyProperty.Register(
               "cardFName",
               typeof(string),
               typeof(Card),
               new PropertyMetadata(string.Empty, crdFNameChanged));

        public string FName
        {
            get { return (string)GetValue(cardFirstNameProperty); }
            set { SetValue(cardFirstNameProperty, value); }
        }

        private static void crdFNameChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var crdFNameForm = obj as Card;
            crdFNameForm.cardFirstNameLb.Content = crdFNameForm.FName.ToString();
        }
        #endregion

        #region фамилия
        public static readonly DependencyProperty cardSecondNameProperty = DependencyProperty.Register(
               "cardSName",
               typeof(string),
               typeof(Card),
               new PropertyMetadata(string.Empty, crdSNameChanged));

        public string SName
        {
            get { return (string)GetValue(cardSecondNameProperty); }
            set { SetValue(cardSecondNameProperty, value); }
        }

        private static void crdSNameChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var crdSNameForm = obj as Card;
            crdSNameForm.cardSecondNameLb.Content = crdSNameForm.SName.ToString();
        }
        #endregion

        #region должность
        public static readonly DependencyProperty cardPositionProperty = DependencyProperty.Register(
           "cardPosition",
           typeof(string),
           typeof(Card),
           new PropertyMetadata(string.Empty, crdPositionChanged));

        public string Position
        {
            get { return (string)GetValue(cardPositionProperty); }
            set { SetValue(cardPositionProperty, value); }
        }

        private static void crdPositionChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var crdPositionForm = obj as Card;
            crdPositionForm.cardPositionLb.Content = crdPositionForm.Position.ToString();
        }
        #endregion

        #region отдел
        public static readonly DependencyProperty cardDepartmentProperty = DependencyProperty.Register(
               "cardDepartment",
               typeof(string),
               typeof(Card),
               new PropertyMetadata(string.Empty, crdDepartmentChanged));

        public string Department
        {
            get { return (string)GetValue(cardDepartmentProperty); }
            set { SetValue(cardDepartmentProperty, value); }
        }

        private static void crdDepartmentChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var crdDepartmentForm = obj as Card;
            crdDepartmentForm.cardDepartmentLb.Content = crdDepartmentForm.Department.ToString();
        }
        #endregion

        #region статус
        public static readonly DependencyProperty cardStatusProperty = DependencyProperty.Register(
               "cardStatus",
               typeof(string),
               typeof(Card),
               new PropertyMetadata(string.Empty, crdStatusChanged));

        public string Status
        {
            get { return (string)GetValue(cardStatusProperty); }
            set { SetValue(cardStatusProperty, value); }
        }

        private static void crdStatusChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var crdStatusForm = obj as Card;
            crdStatusForm.cardStatusLb.Content = crdStatusForm.Status.ToString();
        }
        #endregion

        #region гравюра
        public static readonly DependencyProperty cardImageProperty = DependencyProperty.Register(
           "cardImage",
           typeof(string),
           typeof(Card),
           new PropertyMetadata(string.Empty, EmpImgChanged));

        public string Image
        {
            get { return (string)GetValue(cardImageProperty); }
            set { SetValue(cardImageProperty, value); }
        }

        private static void EmpImgChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var crdImageForm = obj as Card;
            crdImageForm.cardImage.Source = new BitmapImage(new Uri($"pack://application:,,,/{crdImageForm.Image}"));
        }
        #endregion

        #region кнопки
        private void callBut_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("На связи...");
        }

        private void writeBut_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Передаю привет всем кто ставит лайки, передаю привет всем кто ставит дизлайки...");
        }

        private void posholOtsydaBut_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Не удалось выполнить запрос");
        }
        #endregion
    }
}