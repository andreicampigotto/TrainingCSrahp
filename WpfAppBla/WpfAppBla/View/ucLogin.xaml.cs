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
	/// Interaction logic for ucLogin.xaml
	/// </summary>
	public partial class ucLogin : UserControl
	{
		public ucLogin()
		{
			InitializeComponent();
		}

		public event EventHandler sucess;
		public event EventHandler fail;

		public Model1 context = new Model1();

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			var userName = tbLogin.Text;
			var userPass = tbSenha.Password;

			var result = context.Usuarios.FirstOrDefault(x => x.Login == userName && x.Senha == userPass);

			if (result?.Id > 0)
				sucess("Logado!", new EventArgs());
			

			else
				fail($"Falha ao logar {userName}", new EventArgs());
		}
	}
}
