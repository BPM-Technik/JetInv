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

namespace JetInv
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Window wd = null;

            if (btn.Name == "Vertrieb")
            {
                wd = new Controller.Vertrieb.MainVertrieb();
            }
            else if (btn.Name == "Einkauf")
            {
                MessageBox.Show("Funktion '" + btn.Name + "' ist noch nicht verfügbar", "Meldung");
            }
            else if (btn.Name == "Kunden")
            {
                MessageBox.Show("Funktion '" + btn.Name + "' ist noch nicht verfügbar", "Meldung");
            }
            else if (btn.Name == "Lager")
            {
                MessageBox.Show("Funktion '" + btn.Name + "' ist noch nicht verfügbar", "Meldung");
            }

            try
            {
                wd.ShowDialog();
            }
            catch (NullReferenceException)
            {
                if (!this.IsActive)
                {
                    this.Show();
                }
            }
        }
    }
}
