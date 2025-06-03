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

namespace TickTakToe
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

        private void Change_Color(object sender, RoutedEventArgs e)
        {
            //클릭시 색 변경
            Button clickedButton = (Button)sender;
            if(clickedButton.Background == Brushes.White)
            {
                clickedButton.Background = Brushes.Gray;
            }
            else if(clickedButton.Background == Brushes.Gray)
            {
                clickedButton.Background = Brushes.Yellow;
            }
            else
            {
                clickedButton.Background = Brushes.White;
            }
        }
    }
}