namespace DataGRidViewExemple
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
			this.btAdiciona = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.diariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.reviewDataSet = new DataGRidViewExemple.ReviewDataSet();
			this.turmaAlunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.turmaAlunosTableAdapter = new DataGRidViewExemple.ReviewDataSetTableAdapters.TurmaAlunosTableAdapter();
			this.notasBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.notasTableAdapter = new DataGRidViewExemple.ReviewDataSetTableAdapters.NotasTableAdapter();
			this.diariosTableAdapter = new DataGRidViewExemple.ReviewDataSetTableAdapters.DiariosTableAdapter();
			this.deletCommand = new System.Windows.Forms.DataGridViewButtonColumn();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.turmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.obsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.usuIncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.datIncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usuAltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.datAltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.diariosBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.reviewDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.turmaAlunosBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// btAdiciona
			// 
			this.btAdiciona.Location = new System.Drawing.Point(12, 12);
			this.btAdiciona.Name = "btAdiciona";
			this.btAdiciona.Size = new System.Drawing.Size(387, 59);
			this.btAdiciona.TabIndex = 0;
			this.btAdiciona.Text = "Adicionar";
			this.btAdiciona.UseVisualStyleBackColor = true;
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
            this.deletCommand,
            this.idDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.turmaDataGridViewTextBoxColumn,
            this.obsDataGridViewTextBoxColumn,
            this.ativoDataGridViewCheckBoxColumn,
            this.usuIncDataGridViewTextBoxColumn,
            this.datIncDataGridViewTextBoxColumn,
            this.usuAltDataGridViewTextBoxColumn,
            this.datAltDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.diariosBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(13, 91);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(775, 347);
			this.dataGridView1.TabIndex = 1;
			// 
			// diariosBindingSource
			// 
			this.diariosBindingSource.DataMember = "Diarios";
			this.diariosBindingSource.DataSource = this.reviewDataSet;
			// 
			// reviewDataSet
			// 
			this.reviewDataSet.DataSetName = "ReviewDataSet";
			this.reviewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// turmaAlunosBindingSource
			// 
			this.turmaAlunosBindingSource.DataMember = "TurmaAlunos";
			this.turmaAlunosBindingSource.DataSource = this.reviewDataSet;
			// 
			// turmaAlunosTableAdapter
			// 
			this.turmaAlunosTableAdapter.ClearBeforeFill = true;
			// 
			// notasBindingSource
			// 
			this.notasBindingSource.DataMember = "Notas";
			this.notasBindingSource.DataSource = this.reviewDataSet;
			// 
			// notasTableAdapter
			// 
			this.notasTableAdapter.ClearBeforeFill = true;
			// 
			// diariosTableAdapter
			// 
			this.diariosTableAdapter.ClearBeforeFill = true;
			// 
			// deletCommand
			// 
			this.deletCommand.DataPropertyName = "DeletCommand";
			this.deletCommand.HeaderText = "Deletar";
			this.deletCommand.MinimumWidth = 6;
			this.deletCommand.Name = "deletCommand";
			this.deletCommand.ReadOnly = true;
			this.deletCommand.Width = 125;
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
			// dataDataGridViewTextBoxColumn
			// 
			this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
			this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
			this.dataDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
			this.dataDataGridViewTextBoxColumn.ReadOnly = true;
			this.dataDataGridViewTextBoxColumn.Width = 125;
			// 
			// turmaDataGridViewTextBoxColumn
			// 
			this.turmaDataGridViewTextBoxColumn.DataPropertyName = "Turma";
			this.turmaDataGridViewTextBoxColumn.HeaderText = "Turma";
			this.turmaDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.turmaDataGridViewTextBoxColumn.Name = "turmaDataGridViewTextBoxColumn";
			this.turmaDataGridViewTextBoxColumn.ReadOnly = true;
			this.turmaDataGridViewTextBoxColumn.Width = 125;
			// 
			// obsDataGridViewTextBoxColumn
			// 
			this.obsDataGridViewTextBoxColumn.DataPropertyName = "Obs";
			this.obsDataGridViewTextBoxColumn.HeaderText = "Obs";
			this.obsDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.obsDataGridViewTextBoxColumn.Name = "obsDataGridViewTextBoxColumn";
			this.obsDataGridViewTextBoxColumn.ReadOnly = true;
			this.obsDataGridViewTextBoxColumn.Width = 125;
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
			// usuIncDataGridViewTextBoxColumn
			// 
			this.usuIncDataGridViewTextBoxColumn.DataPropertyName = "UsuInc";
			this.usuIncDataGridViewTextBoxColumn.HeaderText = "UsuInc";
			this.usuIncDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.usuIncDataGridViewTextBoxColumn.Name = "usuIncDataGridViewTextBoxColumn";
			this.usuIncDataGridViewTextBoxColumn.ReadOnly = true;
			this.usuIncDataGridViewTextBoxColumn.Width = 125;
			// 
			// datIncDataGridViewTextBoxColumn
			// 
			this.datIncDataGridViewTextBoxColumn.DataPropertyName = "DatInc";
			this.datIncDataGridViewTextBoxColumn.HeaderText = "DatInc";
			this.datIncDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.datIncDataGridViewTextBoxColumn.Name = "datIncDataGridViewTextBoxColumn";
			this.datIncDataGridViewTextBoxColumn.ReadOnly = true;
			this.datIncDataGridViewTextBoxColumn.Width = 125;
			// 
			// usuAltDataGridViewTextBoxColumn
			// 
			this.usuAltDataGridViewTextBoxColumn.DataPropertyName = "UsuAlt";
			this.usuAltDataGridViewTextBoxColumn.HeaderText = "UsuAlt";
			this.usuAltDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.usuAltDataGridViewTextBoxColumn.Name = "usuAltDataGridViewTextBoxColumn";
			this.usuAltDataGridViewTextBoxColumn.ReadOnly = true;
			this.usuAltDataGridViewTextBoxColumn.Width = 125;
			// 
			// datAltDataGridViewTextBoxColumn
			// 
			this.datAltDataGridViewTextBoxColumn.DataPropertyName = "DatAlt";
			this.datAltDataGridViewTextBoxColumn.HeaderText = "DatAlt";
			this.datAltDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.datAltDataGridViewTextBoxColumn.Name = "datAltDataGridViewTextBoxColumn";
			this.datAltDataGridViewTextBoxColumn.ReadOnly = true;
			this.datAltDataGridViewTextBoxColumn.Width = 125;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btAdiciona);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.diariosBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.reviewDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.turmaAlunosBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btAdiciona;
		private System.Windows.Forms.DataGridView dataGridView1;
		private ReviewDataSet reviewDataSet;
		private System.Windows.Forms.BindingSource turmaAlunosBindingSource;
		private ReviewDataSetTableAdapters.TurmaAlunosTableAdapter turmaAlunosTableAdapter;
		private System.Windows.Forms.BindingSource notasBindingSource;
		private ReviewDataSetTableAdapters.NotasTableAdapter notasTableAdapter;
		private System.Windows.Forms.BindingSource diariosBindingSource;
		private ReviewDataSetTableAdapters.DiariosTableAdapter diariosTableAdapter;
		private System.Windows.Forms.DataGridViewButtonColumn deletCommand;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn turmaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn obsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn usuIncDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn datIncDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn usuAltDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn datAltDataGridViewTextBoxColumn;
	}
}

