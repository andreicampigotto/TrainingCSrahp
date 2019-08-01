using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carros.Edicao
{
	public partial class frmEdicaoCarro : Form
	{
		public frmEdicaoCarro()
		{
			InitializeComponent();
		}

		public Carros.QuerrysInnerJoinDataSet.CarrosRow CarrosRow;

	private void FrmEdicaoCarro_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'querrysInnerJoinDataSet.Marcas' table. You can move, or remove it, as needed.
			this.marcasTableAdapter.FillBy(this.querrysInnerJoinDataSet.Marcas);

			txModelo.Text = CarrosRow.Modelo;
			detData.Value = CarrosRow.Ano;
			cbMarca.SelectedValue = CarrosRow.Marca;

		}

		private void FillByToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.marcasTableAdapter.FillBy(this.querrysInnerJoinDataSet.Marcas);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}
	}
}
