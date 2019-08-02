namespace frmPrincipalBibliotecaHbsis
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
			this.btAutores = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btAutores
			// 
			this.btAutores.Location = new System.Drawing.Point(24, 25);
			this.btAutores.Name = "btAutores";
			this.btAutores.Size = new System.Drawing.Size(86, 35);
			this.btAutores.TabIndex = 0;
			this.btAutores.Text = "Autores";
			this.btAutores.UseVisualStyleBackColor = true;
			this.btAutores.Click += new System.EventHandler(this.BtAutores_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(739, 423);
			this.Controls.Add(this.btAutores);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btAutores;
	}
}

