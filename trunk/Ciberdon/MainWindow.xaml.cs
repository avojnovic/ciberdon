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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ControlObjects;
using BussinesObjects;

namespace Ciberdon
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



        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var user = new User
            {
                Email = "j.smith@gmail.com",
                Name = "John",
                Lastname = "Smith",
                Psw = "123"
            };

            var context = new CiberdonDbContext();
            context.User.Add(user);
            context.SaveChanges();
        }
    }
}
