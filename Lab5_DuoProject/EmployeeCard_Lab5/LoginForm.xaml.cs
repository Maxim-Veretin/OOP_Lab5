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
    /// Логика взаимодействия для LoginForm.xaml
    /// </summary>
    public partial class LoginForm : UserControl
    {
        public LoginForm()
        {
            InitializeComponent();

            LoginTxt.TextChanged += LoginTxt_TextChanged;
            PasswordTxt.TextChanged += PasswordTxt_TextChanged;
            OKButton.Click += OKButton_Click;
        }

        public static readonly DependencyProperty LoginProperty = DependencyProperty.Register(
                    "Login", // имя параметра в разметке
                    typeof(string), // тип данных параметра
                    typeof(LoginForm), // тип данных элемента управления
                    new PropertyMetadata(string.Empty, LoginChanged)); // метаданные - значение параметра по
                                                                       // умолчанию и обработчик изменения параметра
        public string Login
        {
            get { return (string)GetValue(LoginProperty); }
            set { SetValue(LoginProperty, value); }
        }

        private static void LoginChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var loginForm = obj as LoginForm;
            loginForm.LoginTxt.Text = loginForm.Login;
        }

        private void LoginTxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public static readonly DependencyProperty PasswordProperty = DependencyProperty.Register(
                    "Password", // имя параметра в разметке
                    typeof(string), // тип данных параметра
                    typeof(LoginForm), // тип данных элемента управления
                    new PropertyMetadata(string.Empty, PasswordChanged)); // метаданные - значение параметра по
                                                                          // умолчанию и обработчик изменения параметра
        public string Password
        {
            get {
                //string returnPass = "";
                //for (int i = 0; i < GetValue(PasswordProperty).ToString().Length; i++)
                //{
                //    returnPass += "*";
                //}
                //return returnPass;
                return (string)GetValue(PasswordProperty);
            }
            set { SetValue(PasswordProperty, value); }
        }

        private static void PasswordChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var loginForm = obj as LoginForm;
            loginForm.PasswordTxt.Text = loginForm.Password;
        }

        private void PasswordTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void validData()
        {
            // длина логина должна быть не менее 4 символов,
            // а длина пароля - не менее 8 символов

            bool isDataValid = Login.Length >= 4 && Password.Length >= 8;

            if (isDataValid)
                OKButton.IsEnabled = true;
            else
                OKButton.IsEnabled = false;
        }
    }
}
