using Form_Lanchonete.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Lanchonete
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public List<Lanche> lanches = new List<Lanche>();

		private void BtCadastro_Click(object sender, EventArgs e)
		{
			TelaDeCadastro cad = new TelaDeCadastro();
			cad.ShowDialog();
			lanches.Add(cad.novoLanche);
		}
	}
}
