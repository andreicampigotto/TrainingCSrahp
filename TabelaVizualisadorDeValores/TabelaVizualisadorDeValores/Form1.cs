using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabelaVizualisadorDeValores.Model;

namespace TabelaVizualisadorDeValores
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		List<Contrac> listContracs = new List<Contrac>();

		private void BtAdiciona_Click(object sender, EventArgs e)
		{
			listContracs.Add(new Contrac()
			{
				Id = listContracs.Count,
				Value = new Random().Next(100),
				DatInc = DateTime.Now
			});

			dataGridView1.DataSource = null;
			dataGridView1.DataSource = listContracs;
		}

		private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
