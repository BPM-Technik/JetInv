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
using System.Windows.Shapes;

namespace JetInv.Controller.Vertrieb
{
    /// <summary>
    /// Interaktionslogik für MainVertrieb.xaml
    /// </summary>
    public partial class MainVertrieb : Window
    {
        public MainVertrieb()
        {
            InitializeComponent();
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Window wd = null;

            if (btn.Name == "Angebot")
            {
                
            }
            else if (btn.Name == "Ausgangsrechnung")
            {
                wd = new C_Ausgangsrechnung();
            }
            else if (btn.Name == "Lieferschein")
            {
                
            }
            else if (btn.Name == "Mietvertrag")
            {
                
            }

            try
            {
                wd.ShowDialog();
            }
            catch (NullReferenceException)
            {
                // Button noch nicht ausführbar

                MessageBox.Show("Funktion '" + btn.Name + "' ist noch nicht verfügbar", "Meldung");
                if (!this.IsActive)
                {
                    this.Show();
                }
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
