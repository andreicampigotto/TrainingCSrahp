﻿namespace Form_Lanchonete
{
	partial class Form1
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
			this.btCadastro = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btCadastro
			// 
			this.btCadastro.Location = new System.Drawing.Point(42, 45);
			this.btCadastro.Name = "btCadastro";
			this.btCadastro.Size = new System.Drawing.Size(103, 46);
			this.btCadastro.TabIndex = 0;
			this.btCadastro.Text = "Cadastrar";
			this.btCadastro.UseVisualStyleBackColor = true;
			this.btCadastro.Click += new System.EventHandler(this.BtCadastro_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btCadastro);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btCadastro;
	}
}

