namespace Alunos.Classes
{
	partial class TelaCadastro
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txNome = new System.Windows.Forms.TextBox();
			this.nrIdade = new System.Windows.Forms.NumericUpDown();
			this.btSalva = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nrIdade)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Idade:";
			// 
			// txNome
			// 
			this.txNome.Location = new System.Drawing.Point(58, 6);
			this.txNome.Name = "txNome";
			this.txNome.ShortcutsEnabled = false;
			this.txNome.Size = new System.Drawing.Size(287, 22);
			this.txNome.TabIndex = 2;
			this.txNome.Text = "Nome do aluno";
			// 
			// nrIdade
			// 
			this.nrIdade.Location = new System.Drawing.Point(58, 42);
			this.nrIdade.Name = "nrIdade";
			this.nrIdade.Size = new System.Drawing.Size(93, 22);
			this.nrIdade.TabIndex = 3;
			// 
			// btSalva
			// 
			this.btSalva.Location = new System.Drawing.Point(222, 94);
			this.btSalva.Name = "btSalva";
			this.btSalva.Size = new System.Drawing.Size(123, 52);
			this.btSalva.TabIndex = 4;
			this.btSalva.Text = "Salvar";
			this.btSalva.UseVisualStyleBackColor = true;
			this.btSalva.Click += new System.EventHandler(this.BtSalva_Click);
			// 
			// TelaCadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(357, 158);
			this.Controls.Add(this.btSalva);
			this.Controls.Add(this.nrIdade);
			this.Controls.Add(this.txNome);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "TelaCadastro";
			this.Text = "TelaCadastro";
			((System.ComponentModel.ISupportInitialize)(this.nrIdade)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txNome;
		private System.Windows.Forms.NumericUpDown nrIdade;
		private System.Windows.Forms.Button btSalva;
	}
}