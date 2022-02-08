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

namespace WPFNumberKeep
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NumberList numberList = new NumberList();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddNumber_Click(object sender, RoutedEventArgs e)
        {
            int iNumber;
            bool result = int.TryParse(tbNumAdd.Text , out iNumber);
            if (result)
            {
                numberList.AddNumber(iNumber);
                lvNumbers.Items.Add(iNumber);
                tbNumAdd.Text = "";
            }
            else
            {
                MessageBox.Show("Please type a number");
            }
        }

        private void btnCountRef_Click(object sender, RoutedEventArgs e)
        {
            int iNumber;
            bool result = int.TryParse(tbNumReference.Text, out iNumber);
            if (result)
            {
                MessageBox.Show(iNumber + " bestaat " + numberList.RefNumber(iNumber) + " keer");
            }
            else
            {
                MessageBox.Show("Please type a number");
            }
        }
        private void btnMaxNumber_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show(numberList.MaxNumber().ToString());
        }

        private void btnMinNumber_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show(numberList.MinNumber().ToString());
        }

        

        private void btnAverageNumber_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(numberList.AverageNumber().ToString());
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
