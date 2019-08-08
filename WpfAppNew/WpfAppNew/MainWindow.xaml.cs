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
using WpfAppNew.Data;

namespace WpfAppNew
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

		public BibliotecaDBContext context;

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			context = new BibliotecaDBContext();
		}

		private void Blaaaa(object sender, RoutedEventArgs e)
		{
			MessageBox.Show(context.Usuarios.FirstOrDefault(x => x.Id > 0).Usuario);

			var runList = context.Usuarios.OrderBy(x => x.Usuario).ToList<Usuarios>();

			gvBlaaaa.ItemsSource = runList;
		}
	}
}
