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

    public partial class MainWindow : Window
    {
        // globalized via Application.Current.MainWindow
        RPS t;

        private string _specialStr = string.Empty;
        public string SpecialStr   // property
        {
            get { return _specialStr; }   // get method
            set { _specialStr = value; }  // set method
        }



        public MainWindow()
        {
            InitializeComponent();
            t = new RPS(UserCB);
        }



    }
}