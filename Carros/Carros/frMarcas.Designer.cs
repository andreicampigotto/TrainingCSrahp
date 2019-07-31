namespace Carros
{
	partial class frMarcas
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
			this.DeletCommand = new System.Windows.Forms.DataGridViewButtonColumn();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.usuIncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usuAltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.datIncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.datAltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.querrysInnerJoinDataSet = new Carros.QuerrysInnerJoinDataSet();
			this.marcasTableAdapter = new Carros.QuerrysInnerJoinDataSetTableAdapters.MarcasTableAdapter();
			this.btCarros = new System.Windows.Forms.Button();
			this.btUsuarios = new System.Windows.Forms.Button();
			this.btVendas = new System.Windows.Forms.Button();
			this.btAdiciona = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.querrysInnerJoinDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeletCommand,
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.ativoDataGridViewCheckBoxColumn,
            this.usuIncDataGridViewTextBoxColumn,
            this.usuAltDataGridViewTextBoxColumn,
            this.datIncDataGridViewTextBoxColumn,
            this.datAltDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.marcasBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 58);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(776, 380);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
			// 
			// DeletCommand
			// 
			this.DeletCommand.DataPropertyName = "DeletCommand";
			this.DeletCommand.HeaderText = "Deletar";
			this.DeletCommand.MinimumWidth = 6;
			this.DeletCommand.Name = "DeletCommand";
			this.DeletCommand.ReadOnly = true;
			this.DeletCommand.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.DeletCommand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.DeletCommand.Width = 125;
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
			// usuAltDataGridViewTextBoxColumn
			// 
			this.usuAltDataGridViewTextBoxColumn.DataPropertyName = "UsuAlt";
			this.usuAltDataGridViewTextBoxColumn.HeaderText = "UsuAlt";
			this.usuAltDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.usuAltDataGridViewTextBoxColumn.Name = "usuAltDataGridViewTextBoxColumn";
			this.usuAltDataGridViewTextBoxColumn.ReadOnly = true;
			this.usuAltDataGridViewTextBoxColumn.Width = 125;
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
			// datAltDataGridViewTextBoxColumn
			// 
			this.datAltDataGridViewTextBoxColumn.DataPropertyName = "DatAlt";
			this.datAltDataGridViewTextBoxColumn.HeaderText = "DatAlt";
			this.datAltDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.datAltDataGridViewTextBoxColumn.Name = "datAltDataGridViewTextBoxColumn";
			this.datAltDataGridViewTextBoxColumn.ReadOnly = true;
			this.datAltDataGridViewTextBoxColumn.Width = 125;
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
			// marcasTableAdapter
			// 
			this.marcasTableAdapter.ClearBeforeFill = true;
			// 
			// btCarros
			// 
			this.btCarros.Location = new System.Drawing.Point(130, 12);
			this.btCarros.Name = "btCarros";
			this.btCarros.Size = new System.Drawing.Size(112, 40);
			this.btCarros.TabIndex = 8;
			this.btCarros.Text = "Carros";
			this.btCarros.UseVisualStyleBackColor = true;
			// 
			// btUsuarios
			// 
			this.btUsuarios.Location = new System.Drawing.Point(248, 12);
			this.btUsuarios.Name = "btUsuarios";
			this.btUsuarios.Size = new System.Drawing.Size(112, 40);
			this.btUsuarios.TabIndex = 7;
			this.btUsuarios.Text = "Usuarios";
			this.btUsuarios.UseVisualStyleBackColor = true;
			// 
			// btVendas
			// 
			this.btVendas.Location = new System.Drawing.Point(366, 12);
			this.btVendas.Name = "btVendas";
			this.btVendas.Size = new System.Drawing.Size(112, 40);
			this.btVendas.TabIndex = 6;
			this.btVendas.Text = "Vendas";
			this.btVendas.UseVisualStyleBackColor = true;
			// 
			// btAdiciona
			// 
			this.btAdiciona.Location = new System.Drawing.Point(12, 12);
			this.btAdiciona.Name = "btAdiciona";
			this.btAdiciona.Size = new System.Drawing.Size(112, 40);
			this.btAdiciona.TabIndex = 5;
			this.btAdiciona.Text = "Adicionar";
			this.btAdiciona.UseVisualStyleBackColor = true;
			// 
			// frMarcas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btCarros);
			this.Controls.Add(this.btUsuarios);
			this.Controls.Add(this.btVendas);
			this.Controls.Add(this.btAdiciona);
			this.Controls.Add(this.dataGridView1);
			this.Name = "frMarcas";
			this.Text = "frMarcas";
			this.Load += new System.EventHandler(this.FrMarcas_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.querrysInnerJoinDataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private QuerrysInnerJoinDataSet querrysInnerJoinDataSet;
		private System.Windows.Forms.BindingSource marcasBindingSource;
		private QuerrysInnerJoinDataSetTableAdapters.MarcasTableAdapter marcasTableAdapter;
		private System.Windows.Forms.DataGridViewButtonColumn DeletCommand;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn usuIncDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn usuAltDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn datIncDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn datAltDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button btCarros;
		private System.Windows.Forms.Button btUsuarios;
		private System.Windows.Forms.Button btVendas;
		private System.Windows.Forms.Button btAdiciona;
	}
}