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
	public partial class frUsuario : Form
	{
		public frUsuario()
		{
			InitializeComponent();
		}

		private void FrUsuario_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'querrysInnerJoinDataSet.Usuarios' table. You can move, or remove it, as needed.
			this.usuariosTableAdapter.SelectQuery(this.querrysInnerJoinDataSet.Usuarios);

		}

		private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			var usuarioSelect = ((System.Data.DataRowView)
			   this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
			   as Carros.QuerrysInnerJoinDataSet.UsuariosRow;

			switch (e.ColumnIndex)
			{
				case 0:
					{
						this.usuariosTableAdapter.DeleteQuery(usuarioSelect.Id);
						this.usuariosTableAdapter.SelectQuery(this.querrysInnerJoinDataSet.Usuarios);
					}
					break;
			}
			this.usuariosTableAdapter.SelectQuery(querrysInnerJoinDataSet.Usuarios);
		}
	}
}
