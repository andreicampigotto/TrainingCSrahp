namespace GridViewDbAcess
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
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.reviewDataSet = new GridViewDbAcess.ReviewDataSet();
			this.alunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.alunosTableAdapter = new GridViewDbAcess.ReviewDataSetTableAdapters.AlunosTableAdapter();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.alunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.usuIncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.datIncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usuAltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.datAltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.reviewDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.alunoDataGridViewTextBoxColumn,
            this.ativoDataGridViewCheckBoxColumn,
            this.usuIncDataGridViewTextBoxColumn,
            this.datIncDataGridViewTextBoxColumn,
            this.usuAltDataGridViewTextBoxColumn,
            this.datAltDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.alunosBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(1, 109);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(929, 258);
			this.dataGridView1.TabIndex = 0;
			// 
			// reviewDataSet
			// 
			this.reviewDataSet.DataSetName = "ReviewDataSet";
			this.reviewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// alunosBindingSource
			// 
			this.alunosBindingSource.DataMember = "Alunos";
			this.alunosBindingSource.DataSource = this.reviewDataSet;
			// 
			// alunosTableAdapter
			// 
			this.alunosTableAdapter.ClearBeforeFill = true;
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
			// alunoDataGridViewTextBoxColumn
			// 
			this.alunoDataGridViewTextBoxColumn.DataPropertyName = "Aluno";
			this.alunoDataGridViewTextBoxColumn.HeaderText = "Aluno";
			this.alunoDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.alunoDataGridViewTextBoxColumn.Name = "alunoDataGridViewTextBoxColumn";
			this.alunoDataGridViewTextBoxColumn.Width = 125;
			// 
			// ativoDataGridViewCheckBoxColumn
			// 
			this.ativoDataGridViewCheckBoxColumn.DataPropertyName = "Ativo";
			this.ativoDataGridViewCheckBoxColumn.HeaderText = "Ativo";
			this.ativoDataGridViewCheckBoxColumn.MinimumWidth = 6;
			this.ativoDataGridViewCheckBoxColumn.Name = "ativoDataGridViewCheckBoxColumn";
			this.ativoDataGridViewCheckBoxColumn.Width = 125;
			// 
			// usuIncDataGridViewTextBoxColumn
			// 
			this.usuIncDataGridViewTextBoxColumn.DataPropertyName = "UsuInc";
			this.usuIncDataGridViewTextBoxColumn.HeaderText = "UsuInc";
			this.usuIncDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.usuIncDataGridViewTextBoxColumn.Name = "usuIncDataGridViewTextBoxColumn";
			this.usuIncDataGridViewTextBoxColumn.Width = 125;
			// 
			// datIncDataGridViewTextBoxColumn
			// 
			this.datIncDataGridViewTextBoxColumn.DataPropertyName = "DatInc";
			this.datIncDataGridViewTextBoxColumn.HeaderText = "DatInc";
			this.datIncDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.datIncDataGridViewTextBoxColumn.Name = "datIncDataGridViewTextBoxColumn";
			this.datIncDataGridViewTextBoxColumn.Width = 125;
			// 
			// usuAltDataGridViewTextBoxColumn
			// 
			this.usuAltDataGridViewTextBoxColumn.DataPropertyName = "UsuAlt";
			this.usuAltDataGridViewTextBoxColumn.HeaderText = "UsuAlt";
			this.usuAltDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.usuAltDataGridViewTextBoxColumn.Name = "usuAltDataGridViewTextBoxColumn";
			this.usuAltDataGridViewTextBoxColumn.Width = 125;
			// 
			// datAltDataGridViewTextBoxColumn
			// 
			this.datAltDataGridViewTextBoxColumn.DataPropertyName = "DatAlt";
			this.datAltDataGridViewTextBoxColumn.HeaderText = "DatAlt";
			this.datAltDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.datAltDataGridViewTextBoxColumn.Name = "datAltDataGridViewTextBoxColumn";
			this.datAltDataGridViewTextBoxColumn.Width = 125;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(929, 367);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.reviewDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private ReviewDataSet reviewDataSet;
		private System.Windows.Forms.BindingSource alunosBindingSource;
		private ReviewDataSetTableAdapters.AlunosTableAdapter alunosTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn alunoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn usuIncDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn datIncDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn usuAltDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn datAltDataGridViewTextBoxColumn;
	}
}

