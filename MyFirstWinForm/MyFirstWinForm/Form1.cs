using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinForm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		int countPress = 0;

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Juntos e shallow now");
			countPress++;
		}
	}
}
