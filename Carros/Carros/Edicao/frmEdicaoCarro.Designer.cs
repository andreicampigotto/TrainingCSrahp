namespace Carros.Edicao
{
	partial class frmEdicaoCarro
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
			this.components = new System.ComponentModel.Container();
			this.lbModelo = new System.Windows.Forms.Label();
			this.lbAno = new System.Windows.Forms.Label();
			this.txModelo = new System.Windows.Forms.TextBox();
			this.detData = new System.Windows.Forms.DateTimePicker();
			this.cbMarca = new System.Windows.Forms.ComboBox();
			this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.querrysInnerJoinDataSet = new Carros.QuerrysInnerJoinDataSet();
			this.lbMarca = new System.Windows.Forms.Label();
			this.marcasTableAdapter = new Carros.QuerrysInnerJoinDataSetTableAdapters.MarcasTableAdapter();
			this.btnSalvar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.querrysInnerJoinDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// lbModelo
			// 
			this.lbModelo.AutoSize = true;
			this.lbModelo.Location = new System.Drawing.Point(12, 9);
			this.lbModelo.Name = "lbModelo";
			this.lbModelo.Size = new System.Drawing.Size(54, 17);
			this.lbModelo.TabIndex = 0;
			this.lbModelo.Text = "Modelo";
			// 
			// lbAno
			// 
			this.lbAno.AutoSize = true;
			this.lbAno.Location = new System.Drawing.Point(36, 42);
			this.lbAno.Name = "lbAno";
			this.lbAno.Size = new System.Drawing.Size(33, 17);
			this.lbAno.TabIndex = 1;
			this.lbAno.Text = "Ano";
			// 
			// txModelo
			// 
			this.txModelo.Location = new System.Drawing.Point(72, 6);
			this.txModelo.Name = "txModelo";
			this.txModelo.Size = new System.Drawing.Size(263, 22);
			this.txModelo.TabIndex = 2;
			// 
			// detData
			// 
			this.detData.CustomFormat = "dd/MM/yyyy";
			this.detData.Location = new System.Drawing.Point(72, 37);
			this.detData.Name = "detData";
			this.detData.Size = new System.Drawing.Size(263, 22);
			this.detData.TabIndex = 3;
			// 
			// cbMarca
			// 
			this.cbMarca.DataSource = this.marcasBindingSource;
			this.cbMarca.DisplayMember = "Nome";
			this.cbMarca.FormattingEnabled = true;
			this.cbMarca.Location = new System.Drawing.Point(72, 65);
			this.cbMarca.Name = "cbMarca";
			this.cbMarca.Size = new System.Drawing.Size(263, 24);
			this.cbMarca.TabIndex = 4;
			this.cbMarca.ValueMember = "Id";
			// 
			// marcasBindingSource
			// 
			this.marcasBindingSource.DataMember = "Marcas";
			this.marcasBindingSource.DataSource = this.querrysInnerJoinDataSet;
			// 
			// querrysInnerJoinDataSet
			// 
			this.querrysInnerJoinDataSet.DataSetName = "QuerrysInnerJoinDataSet";
			this.querrysInnerJoinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// lbMarca
			// 
			this.lbMarca.AutoSize = true;
			this.lbMarca.Location = new System.Drawing.Point(22, 68);
			this.lbMarca.Name = "lbMarca";
			this.lbMarca.Size = new System.Drawing.Size(47, 17);
			this.lbMarca.TabIndex = 5;
			this.lbMarca.Text = "Marca";
			// 
			// marcasTableAdapter
			// 
			this.marcasTableAdapter.ClearBeforeFill = true;
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(242, 109);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(93, 37);
			this.btnSalvar.TabIndex = 7;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			// 
			// frmEdicaoCarro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(345, 157);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.lbMarca);
			this.Controls.Add(this.cbMarca);
			this.Controls.Add(this.detData);
			this.Controls.Add(this.txModelo);
			this.Controls.Add(this.lbAno);
			this.Controls.Add(this.lbModelo);
			this.Name = "frmEdicaoCarro";
			this.Text = "frmEdicaoCarro";
			this.Load += new System.EventHandler(this.FrmEdicaoCarro_Load);
			((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.querrysInnerJoinDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbModelo;
		private System.Windows.Forms.Label lbAno;
		private System.Windows.Forms.TextBox txModelo;
		private System.Windows.Forms.DateTimePicker detData;
		private System.Windows.Forms.ComboBox cbMarca;
		private System.Windows.Forms.Label lbMarca;
		private QuerrysInnerJoinDataSet querrysInnerJoinDataSet;
		private System.Windows.Forms.BindingSource marcasBindingSource;
		private QuerrysInnerJoinDataSetTableAdapters.MarcasTableAdapter marcasTableAdapter;
		private System.Windows.Forms.Button btnSalvar;
	}
}