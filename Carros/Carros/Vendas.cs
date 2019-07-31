using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carros
{
	public partial class frVendas : Form
	{
		public frVendas()
		{
			InitializeComponent();
		}

		private void Vendas_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'querrysInnerJoinDataSet.Vendas' table. You can move, or remove it, as needed.
			this.vendasTableAdapter.SelectQuery(this.querrysInnerJoinDataSet.Vendas);

		}

		private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//var carSelect = 
		}
	}
}
