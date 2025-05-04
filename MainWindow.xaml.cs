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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void onMakeUpdated(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox temp)
            {
                var x = temp.SelectedIndex;
                var y = temp.SelectedValue;

                if (temp.SelectedItem is ComboBoxItem z)
                {
                    MessageBox.Show(z.Content.ToString());
                }
            }
        }
    }
}