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
	public partial class TelaDeCadastro : Form
	{
		public TelaDeCadastro()
		{
			InitializeComponent();
		}

		public Lanche novoLanche = new Lanche();

		private void BtSalvar_Click(object sender, EventArgs e)
		{
			novoLanche.Nome = txNome.Text;
			novoLanche.Quantidade = (int)nrQtda.Value;
			novoLanche.Valor = double.Parse(txValor.Text);

			this.Close();
		}
	}
}
