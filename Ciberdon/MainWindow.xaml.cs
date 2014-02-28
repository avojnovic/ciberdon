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
        public User _user;
        private List<Product> _products;
        public MainWindow()
        {
            InitializeComponent();
            _products = ProductManager.Get().ToList();

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


            var product = new Product
            {
                
               
                Name = "Producto1",

            };



            context.SaveChanges();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
