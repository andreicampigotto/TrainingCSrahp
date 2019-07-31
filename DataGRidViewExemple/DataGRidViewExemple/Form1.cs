using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGRidViewExemple
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'reviewDataSet.Diarios' table. You can move, or remove it, as needed.
			this.diariosTableAdapter.CustomQuery(this.reviewDataSet.Diarios);
			// TODO: This line of code loads data into the 'reviewDataSet.Notas' table. You can move, or remove it, as needed.
			//this.diariosTableAdapter.DeleteQuery(0);
			// TODO: This line of code loads data into the 'reviewDataSet.TurmaAlunos' table. You can move, or remove it, as needed.
			this.turmaAlunosTableAdapter.Fill(this.reviewDataSet.TurmaAlunos);

		}
	}
}
