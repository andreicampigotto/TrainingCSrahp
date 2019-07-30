using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alunos.Classes
{
	public partial class TelaCadastro : Form
	{
		public TelaCadastro()
		{
			InitializeComponent();
		}
		public CadastraAlunos NovoAluno = new CadastraAlunos();
		private void BtSalva_Click(object sender, EventArgs e)
		{
			NovoAluno.Nome = txNome.Text;
			NovoAluno.Idade = (int)nrIdade.Value;

			this.Close();
		}
	}
}
