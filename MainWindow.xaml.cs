using BasicForm.Game;
using System.Data;
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


namespace BasicForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private RPS t = new RPS();

        public MainWindow()
        {
            InitializeComponent();
            Image imgElement = ((Image)computer_image);
            BitmapImage bm = new BitmapImage(new Uri(@"/images/rock.jpg", UriKind.Relative));
            imgElement.Source = bm;
            imgElement.Width = bm.Width;
            imgElement.Height = bm.Height;
        }

        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void onMakeUpdated(object sender, SelectionChangedEventArgs e)
        {

            ComboBox temp = (ComboBox)sender;
            string? userChoice = ((ComboBoxItem)temp.SelectedItem).Content?.ToString();

            if (userChoice != null)
            {
                MessageBox.Show(userChoice);

            }


        }
    }
}