namespace frmPrincipalBibliotecaHbsis.View
{
	partial class frmViewAutores
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.idCriacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idAlteracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataCriacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataAlteracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.autoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bibliotecaHbsisDataSet = new frmPrincipalBibliotecaHbsis.BibliotecaHbsisDataSet();
			this.autoresTableAdapter = new frmPrincipalBibliotecaHbsis.BibliotecaHbsisDataSetTableAdapters.AutoresTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bibliotecaHbsisDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.ativoDataGridViewCheckBoxColumn,
            this.idCriacaoDataGridViewTextBoxColumn,
            this.idAlteracaoDataGridViewTextBoxColumn,
            this.dataCriacaoDataGridViewTextBoxColumn,
            this.dataAlteracaoDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.autoresBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(1, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(728, 435);
			this.dataGridView1.TabIndex = 0;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Width = 125;
			// 
			// nomeDataGridViewTextBoxColumn
			// 
			this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
			this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
			this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
			this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
			this.nomeDataGridViewTextBoxColumn.Width = 125;
			// 
			// descricaoDataGridViewTextBoxColumn
			// 
			this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
			this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
			this.descricaoDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
			this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
			this.descricaoDataGridViewTextBoxColumn.Width = 125;
			// 
			// ativoDataGridViewCheckBoxColumn
			// 
			this.ativoDataGridViewCheckBoxColumn.DataPropertyName = "Ativo";
			this.ativoDataGridViewCheckBoxColumn.HeaderText = "Ativo";
			this.ativoDataGridViewCheckBoxColumn.MinimumWidth = 6;
			this.ativoDataGridViewCheckBoxColumn.Name = "ativoDataGridViewCheckBoxColumn";
			this.ativoDataGridViewCheckBoxColumn.ReadOnly = true;
			this.ativoDataGridViewCheckBoxColumn.Width = 125;
			// 
			// idCriacaoDataGridViewTextBoxColumn
			// 
			this.idCriacaoDataGridViewTextBoxColumn.DataPropertyName = "IdCriacao";
			this.idCriacaoDataGridViewTextBoxColumn.HeaderText = "IdCriacao";
			this.idCriacaoDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.idCriacaoDataGridViewTextBoxColumn.Name = "idCriacaoDataGridViewTextBoxColumn";
			this.idCriacaoDataGridViewTextBoxColumn.ReadOnly = true;
			this.idCriacaoDataGridViewTextBoxColumn.Width = 125;
			// 
			// idAlteracaoDataGridViewTextBoxColumn
			// 
			this.idAlteracaoDataGridViewTextBoxColumn.DataPropertyName = "IdAlteracao";
			this.idAlteracaoDataGridViewTextBoxColumn.HeaderText = "IdAlteracao";
			this.idAlteracaoDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.idAlteracaoDataGridViewTextBoxColumn.Name = "idAlteracaoDataGridViewTextBoxColumn";
			this.idAlteracaoDataGridViewTextBoxColumn.ReadOnly = true;
			this.idAlteracaoDataGridViewTextBoxColumn.Width = 125;
			// 
			// dataCriacaoDataGridViewTextBoxColumn
			// 
			this.dataCriacaoDataGridViewTextBoxColumn.DataPropertyName = "DataCriacao";
			this.dataCriacaoDataGridViewTextBoxColumn.HeaderText = "DataCriacao";
			this.dataCriacaoDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.dataCriacaoDataGridViewTextBoxColumn.Name = "dataCriacaoDataGridViewTextBoxColumn";
			this.dataCriacaoDataGridViewTextBoxColumn.ReadOnly = true;
			this.dataCriacaoDataGridViewTextBoxColumn.Width = 125;
			// 
			// dataAlteracaoDataGridViewTextBoxColumn
			// 
			this.dataAlteracaoDataGridViewTextBoxColumn.DataPropertyName = "DataAlteracao";
			this.dataAlteracaoDataGridViewTextBoxColumn.HeaderText = "DataAlteracao";
			this.dataAlteracaoDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.dataAlteracaoDataGridViewTextBoxColumn.Name = "dataAlteracaoDataGridViewTextBoxColumn";
			this.dataAlteracaoDataGridViewTextBoxColumn.ReadOnly = true;
			this.dataAlteracaoDataGridViewTextBoxColumn.Width = 125;
			// 
			// autoresBindingSource
			// 
			this.autoresBindingSource.DataMember = "Autores";
			this.autoresBindingSource.DataSource = this.bibliotecaHbsisDataSet;
			// 
			// bibliotecaHbsisDataSet
			// 
			this.bibliotecaHbsisDataSet.DataSetName = "BibliotecaHbsisDataSet";
			this.bibliotecaHbsisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// autoresTableAdapter
			// 
			this.autoresTableAdapter.ClearBeforeFill = true;
			// 
			// frmViewAutores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Name = "frmViewAutores";
			this.Text = "viewAutores";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.ViewAutores_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bibliotecaHbsisDataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private BibliotecaHbsisDataSet bibliotecaHbsisDataSet;
		private System.Windows.Forms.BindingSource autoresBindingSource;
		private BibliotecaHbsisDataSetTableAdapters.AutoresTableAdapter autoresTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idCriacaoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idAlteracaoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataCriacaoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataAlteracaoDataGridViewTextBoxColumn;
	}
}