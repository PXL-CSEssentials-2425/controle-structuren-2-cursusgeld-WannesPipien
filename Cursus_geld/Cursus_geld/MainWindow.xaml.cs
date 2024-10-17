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

namespace Cursus_geld
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

        int jaartal;

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            string jear = jearTextBox.Text;
            int hours = int.Parse(hoursTextBox.Text);
            double amount = hours * 1.5;
            string decentia = jear.Substring(2, 2);
            int century = (jaartal - int.Parse(decentia));
            if(int.Parse(decentia) % 4 == 0 && century % 400 == 0)
            {
                amount += 1.5;
                leapjearLabel.Content = "Is schrikkeljaar";
            }
            else
            {
                leapjearLabel.Content = "Is geen schrikkeljaar";
            }

            amountToPayTextBox.Text = amount.ToString();
        }

        private void checkButton_Click(object sender, RoutedEventArgs e)
        {
            bool nummeriek = int.TryParse(jearTextBox.Text, out jaartal);
            if(nummeriek)
            {
                numberLabel.Content = "Is nummeriek";
            }
            else
            {
                numberLabel.Content = "Geef een correct jaartal!";
            }
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}