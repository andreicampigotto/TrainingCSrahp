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
	public partial class frMarcas : Form
	{
		public frMarcas()
		{
			InitializeComponent();
		}

		private void FrMarcas_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'querrysInnerJoinDataSet.Marcas' table. You can move, or remove it, as needed.
			this.marcasTableAdapter.SelectQuery(this.querrysInnerJoinDataSet.Marcas);

		}

		private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			var marcasSelect = ((System.Data.DataRowView)
			   this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
			   as Carros.QuerrysInnerJoinDataSet.MarcasRow; ;

			switch (e.ColumnIndex)
			{
				case 0:
					{
						this.marcasTableAdapter.DeleteQuery(marcasSelect.Id);
						this.marcasTableAdapter.SelectQuery(this.querrysInnerJoinDataSet.Marcas);
					}
					break;
			}
			this.marcasTableAdapter.SelectQuery(querrysInnerJoinDataSet.Marcas);
		}
	}
}
