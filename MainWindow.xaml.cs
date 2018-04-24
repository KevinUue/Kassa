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

namespace Kassa
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Ostukorv.Items.Add(textbox1.Text);
            if(textbox1.Text == "")
            {
                MessageBox.Show("Palun täitke kõik väljad ära!");
                
            }

            Ostukorv2.Items.Add(textbox2.Text);
            if(textbox2.Text == "")
            {
                MessageBox.Show("Palun täitke kõik väljad ära!");

            }

            Ostukorv3.Items.Add(textbox3.Text);
            if(textbox3.Text == "")
            {
                MessageBox.Show("Palun täitke kõik väljad ära!");

            }
        }
    }
}
