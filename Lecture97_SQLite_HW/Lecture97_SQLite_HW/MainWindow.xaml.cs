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

namespace Lecture97_SQLite_HW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataAccess.InitializeDatabase();
        }

        private void saveBT_Click(object sender, RoutedEventArgs e)
        {
            DataAccess.AddData(firstName_TxT.Text, lastName_TxT.Text, Email_TxT.Text);
            firstName_TxT.Text = "First Name";
            lastName_TxT.Text = "Last Name";
            Email_TxT.Text = "Email";
            MessageBox.Show("Saved successfully");

        }

        private void ShowBT_Click(object sender, RoutedEventArgs e)
        {
            string Showdata = "";
            foreach (string i in DataAccess.GetData())
            {
                Showdata = Showdata + i + "\n";
            }
            MessageBox.Show(Showdata);


        }

        private void firstName_TxT_GotFocus(object sender, RoutedEventArgs e)
        {
            firstName_TxT.Text = "";
        }

        private void lastName_TxT_GotFocus(object sender, RoutedEventArgs e)
        {
            lastName_TxT.Text = "";
        }

        private void Email_TxT_GotFocus(object sender, RoutedEventArgs e)
        {
            Email_TxT.Text = "";
        }
    }
}
