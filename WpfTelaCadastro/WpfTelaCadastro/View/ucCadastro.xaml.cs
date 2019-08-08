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

namespace WpfTelaCadastro.View
{
	/// <summary>
	/// Interaction logic for ucCadastro.xaml
	/// </summary>
	public partial class ucCadastro : UserControl
	{
		public ucCadastro()
		{
			InitializeComponent();
		}

		public event EventHandler TRY;

		private void tbNome_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Enter)
			{
				tbTelefone.Focus();
			}
		}

		private void TbTelefone_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Enter)
			{
				tbEMail.Focus();
			}
		}

		private void TbEMail_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.Key == Key.Enter)
			{

			}
		}

		private void Reg()
		{

		}
	}
}
