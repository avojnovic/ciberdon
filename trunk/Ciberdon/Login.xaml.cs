using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ControlObjects;


namespace Ciberdon
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {

            textBlockFail.Text = "";
            var context = new CiberdonDbContext();

            string usertxt = textBoxEmail.Text.Trim();
            string pswtxt = passwordBox1.Password.Trim();

            var user = UserManager.Get(usertxt, pswtxt);


            if (user.Count() == 1)
            {

                MainWindow mw = new MainWindow();
                mw._user = user.First();
                mw.Show();
                Close();
            }
            else
            {
                if (user.Count() > 1)
                {
                    textBlockFail.Text = "Usuario y Contraseña duplicados";
                }
                else
                {
                    textBlockFail.Text = "Usuario o Contraseña incorrecto";
                }
            }

        }


        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        
    }
}
