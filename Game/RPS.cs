using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Xml.Linq;

namespace BasicForm.Game
{
    public partial class RPS
    {
        private string _MyStr = "Yadda";


        public string MyStr
        {
            get => _MyStr;
            set { _MyStr = value; }
        }


        public RPS(ComboBox cb)
        {
            cb.SelectionChanged += (object sender, SelectionChangedEventArgs e) => { };
            cb.SelectionChanged += onFruitUpdated;
        }

        private void UpdateImage(string s)
        {
            if (Application.Current.MainWindow is MainWindow MW)
            {
                Image imgElement = (Image)MW.computer_image;
                string path = "/images/" + s + ".jpg";
                BitmapImage bm = new BitmapImage(new Uri(@path, UriKind.Relative));
                imgElement.Source = bm;
                imgElement.Width = bm.Width;
                imgElement.Height = bm.Height;
            }


        }

        private void onFruitUpdated(object sender, SelectionChangedEventArgs e)
        {

            ComboBox temp = (ComboBox)sender;


            string? userChoice = ((ComboBoxItem)temp.SelectedItem).Content?.ToString();

            if (userChoice != null)
            {
                UpdateImage(userChoice);

            }

        }

        public void SayHello()
        {
            // Use a null check to ensure MainWindow is not null before casting
            if (Application.Current.MainWindow is MainWindow MW)
            {

            }

        }
    }
}
