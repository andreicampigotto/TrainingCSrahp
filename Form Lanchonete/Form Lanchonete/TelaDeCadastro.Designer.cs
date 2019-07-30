namespace Form_Lanchonete
{
	partial class TelaDeCadastro
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btSalvar = new System.Windows.Forms.Button();
			this.lbNome = new System.Windows.Forms.Label();
			this.txNome = new System.Windows.Forms.TextBox();
			this.lbQtda = new System.Windows.Forms.Label();
			this.nrQtda = new System.Windows.Forms.NumericUpDown();
			this.txValor = new System.Windows.Forms.TextBox();
			this.lbValor = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nrQtda)).BeginInit();
			this.SuspendLayout();
			// 
			// btSalvar
			// 
			this.btSalvar.Location = new System.Drawing.Point(194, 172);
			this.btSalvar.Name = "btSalvar";
			this.btSalvar.Size = new System.Drawing.Size(105, 49);
			this.btSalvar.TabIndex = 0;
			this.btSalvar.Text = "Salvar";
			this.btSalvar.UseVisualStyleBackColor = true;
			this.btSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
			// 
			// lbNome
			// 
			this.lbNome.AutoSize = true;
			this.lbNome.Location = new System.Drawing.Point(12, 27);
			this.lbNome.Name = "lbNome";
			this.lbNome.Size = new System.Drawing.Size(53, 17);
			this.lbNome.TabIndex = 1;
			this.lbNome.Text = "Nome: ";
			// 
			// txNome
			// 
			this.txNome.Location = new System.Drawing.Point(60, 27);
			this.txNome.Name = "txNome";
			this.txNome.Size = new System.Drawing.Size(239, 22);
			this.txNome.TabIndex = 2;
			// 
			// lbQtda
			// 
			this.lbQtda.AutoSize = true;
			this.lbQtda.Location = new System.Drawing.Point(12, 67);
			this.lbQtda.Name = "lbQtda";
			this.lbQtda.Size = new System.Drawing.Size(86, 17);
			this.lbQtda.TabIndex = 3;
			this.lbQtda.Text = "Quantidade:";
			// 
			// nrQtda
			// 
			this.nrQtda.Location = new System.Drawing.Point(96, 65);
			this.nrQtda.Name = "nrQtda";
			this.nrQtda.Size = new System.Drawing.Size(203, 22);
			this.nrQtda.TabIndex = 4;
			// 
			// txValor
			// 
			this.txValor.Location = new System.Drawing.Point(76, 108);
			this.txValor.Name = "txValor";
			this.txValor.Size = new System.Drawing.Size(223, 22);
			this.txValor.TabIndex = 6;
			// 
			// lbValor
			// 
			this.lbValor.AutoSize = true;
			this.lbValor.Location = new System.Drawing.Point(12, 108);
			this.lbValor.Name = "lbValor";
			this.lbValor.Size = new System.Drawing.Size(67, 17);
			this.lbValor.TabIndex = 5;
			this.lbValor.Text = "Valor R$:";
			// 
			// TelaDeCadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(315, 243);
			this.Controls.Add(this.txValor);
			this.Controls.Add(this.lbValor);
			this.Controls.Add(this.nrQtda);
			this.Controls.Add(this.lbQtda);
			this.Controls.Add(this.txNome);
			this.Controls.Add(this.lbNome);
			this.Controls.Add(this.btSalvar);
			this.Name = "TelaDeCadastro";
			this.Text = "TelaDeCadastro";
			((System.ComponentModel.ISupportInitialize)(this.nrQtda)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btSalvar;
		private System.Windows.Forms.Label lbNome;
		private System.Windows.Forms.TextBox txNome;
		private System.Windows.Forms.Label lbQtda;
		private System.Windows.Forms.NumericUpDown nrQtda;
		private System.Windows.Forms.TextBox txValor;
		private System.Windows.Forms.Label lbValor;
	}
}