using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPrincipalBibliotecaHbsis.View
{
	public partial class frmViewAutores : Form
	{
		public frmViewAutores()
		{
			InitializeComponent();
		}

		private void ViewAutores_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'bibliotecaHbsisDataSet.Autores' table. You can move, or remove it, as needed.
			this.autoresTableAdapter.Fill(this.bibliotecaHbsisDataSet.Autores);

		}
	}
}
