using Alunos.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alunos
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public List<CadastraAlunos> Alunos = new List<CadastraAlunos>();

		private void BtCadastrar_Click(object sender, EventArgs e)
		{
			TelaCadastro cad = new TelaCadastro();
			cad.ShowDialog();
			Alunos.Add(cad.NovoAluno);
		}
	}
}
