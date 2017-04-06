using System;
using System.Collections.Generic;
using System.IO;
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

			//Button-Click-Events
			if (btn.Name == "Vertrieb")
			{
				MessageBox.Show("Die Funktion '" + btn.Name + "' ist zur Zeit nicht verfügbar", "Meldung");
			}
			else if (btn.Name == "Einkauf")
			{
				MessageBox.Show("Die Funktion '" + btn.Name + "' ist zur Zeit nicht verfügbar", "Meldung");
			}
			else if (btn.Name == "Kunden")
			{
				MessageBox.Show("Die Funktion '" + btn.Name + "' ist zur Zeit nicht verfügbar", "Meldung");
			}
			else if (btn.Name == "Lager")
			{
				MessageBox.Show("Die Funktion '" + btn.Name + "' ist zur Zeit nicht verfügbar", "Meldung");
			}

		}
	}
}
