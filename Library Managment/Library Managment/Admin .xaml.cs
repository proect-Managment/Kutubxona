using Library_Managment;
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
using System.Windows.Shapes;
using static MaterialDesignThemes.Wpf.Theme;

namespace Library_Managment
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void textBoxClic_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as System.Windows.Controls.TextBox;
            if (textBox != null )
            {                
                textBox.CaretIndex = textBox.Text.Length;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             
             

            string correctPassword = "12345";

            if (correctPassword.Length > 5)
            {
                MessageBox.Show("Parol to'g'ri");
                 
            }
            else
            {
                MessageBox.Show("Parol noto'g'ri");
            }
        }      

        private void Button_Clicked(object sender, RoutedEventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            Close();
        }
    }
}
