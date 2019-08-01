using Carros.Edicao;
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
	public partial class frCarros : Form
	{
		public frCarros()
		{
			InitializeComponent();
		}

		private void FrCarros_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'querrysInnerJoinDataSet.Carros' table. You can move, or remove it, as needed.
			this.carrosTableAdapter.SelectQuery(this.querrysInnerJoinDataSet.Carros);

		}

		private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			var carrosSelect = ((System.Data.DataRowView)
			   this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
			   as Carros.QuerrysInnerJoinDataSet.CarrosRow;


			switch (e.ColumnIndex)
			{
				case 0:
					{
						frmEdicaoCarro editarCaaro = new frmEdicaoCarro();
						editarCaaro.CarrosRow = carrosSelect;
						editarCaaro.ShowDialog();
						//this.carrosTableAdapter.DeleteQuery(carrosSelect.Id);
						//this.carrosTableAdapter.SelectQuery(this.querrysInnerJoinDataSet.Carros);
					}
					break;
				case 7:
					{
						this.carrosTableAdapter.DeleteQuery(carrosSelect.Id);
						//this.carrosTableAdapter.SelectQuery(this.querrysInnerJoinDataSet.Carros);
					}
					break;
			}
			this.carrosTableAdapter.SelectQuery(querrysInnerJoinDataSet.Carros);
		}
	}
}
