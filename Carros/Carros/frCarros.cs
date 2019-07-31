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
	}
}
