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
using WpfAppBla.Data;

namespace WpfAppBla.View
{
	/// <summary>
	/// Interaction logic for ucGridView.xaml
	/// </summary>
	public partial class ucGridView : UserControl
	{
		public ucGridView()
		{
			InitializeComponent();
		}

		public Model1 context = new Model1();

		private void DtGRidView_Loaded(object sender, RoutedEventArgs e)
		{
			dtGRidView.ItemsSource = context.Usuarios.ToList<Usuario>();
		}
	}
}
