namespace Carros
{
	partial class frUsuario
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
			this.querrysInnerJoinDataSet = new Carros.QuerrysInnerJoinDataSet();
			this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.usuariosTableAdapter = new Carros.QuerrysInnerJoinDataSetTableAdapters.UsuariosTableAdapter();
			this.Deleta = new System.Windows.Forms.DataGridViewButtonColumn();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.usuIncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usuAltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.datIncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.datAltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.deletCommandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btAdiciona = new System.Windows.Forms.Button();
			this.btVendas = new System.Windows.Forms.Button();
			this.btMarcas = new System.Windows.Forms.Button();
			this.btCarros = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.querrysInnerJoinDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deleta,
            this.idDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.ativoDataGridViewCheckBoxColumn,
            this.usuIncDataGridViewTextBoxColumn,
            this.usuAltDataGridViewTextBoxColumn,
            this.datIncDataGridViewTextBoxColumn,
            this.datAltDataGridViewTextBoxColumn,
            this.deletCommandDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.usuariosBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 58);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(776, 380);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
			// 
			// querrysInnerJoinDataSet
			// 
			this.querrysInnerJoinDataSet.DataSetName = "QuerrysInnerJoinDataSet";
			this.querrysInnerJoinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// usuariosBindingSource
			// 
			this.usuariosBindingSource.DataMember = "Usuarios";
			this.usuariosBindingSource.DataSource = this.querrysInnerJoinDataSet;
			// 
			// usuariosTableAdapter
			// 
			this.usuariosTableAdapter.ClearBeforeFill = true;
			// 
			// Deleta
			// 
			this.Deleta.DataPropertyName = "DeletCommand";
			this.Deleta.HeaderText = "Deleta";
			this.Deleta.MinimumWidth = 6;
			this.Deleta.Name = "Deleta";
			this.Deleta.ReadOnly = true;
			this.Deleta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Deleta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Deleta.Width = 125;
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
			// usuarioDataGridViewTextBoxColumn
			// 
			this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
			this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
			this.usuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
			this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
			this.usuarioDataGridViewTextBoxColumn.Width = 125;
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
			// deletCommandDataGridViewTextBoxColumn
			// 
			this.deletCommandDataGridViewTextBoxColumn.DataPropertyName = "DeletCommand";
			this.deletCommandDataGridViewTextBoxColumn.HeaderText = "DeletCommand";
			this.deletCommandDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.deletCommandDataGridViewTextBoxColumn.Name = "deletCommandDataGridViewTextBoxColumn";
			this.deletCommandDataGridViewTextBoxColumn.ReadOnly = true;
			this.deletCommandDataGridViewTextBoxColumn.Width = 125;
			// 
			// btAdiciona
			// 
			this.btAdiciona.Location = new System.Drawing.Point(12, 12);
			this.btAdiciona.Name = "btAdiciona";
			this.btAdiciona.Size = new System.Drawing.Size(112, 40);
			this.btAdiciona.TabIndex = 1;
			this.btAdiciona.Text = "Adicionar";
			this.btAdiciona.UseVisualStyleBackColor = true;
			// 
			// btVendas
			// 
			this.btVendas.Location = new System.Drawing.Point(366, 12);
			this.btVendas.Name = "btVendas";
			this.btVendas.Size = new System.Drawing.Size(112, 40);
			this.btVendas.TabIndex = 2;
			this.btVendas.Text = "Vendas";
			this.btVendas.UseVisualStyleBackColor = true;
			// 
			// btMarcas
			// 
			this.btMarcas.Location = new System.Drawing.Point(248, 12);
			this.btMarcas.Name = "btMarcas";
			this.btMarcas.Size = new System.Drawing.Size(112, 40);
			this.btMarcas.TabIndex = 3;
			this.btMarcas.Text = "Marcas";
			this.btMarcas.UseVisualStyleBackColor = true;
			// 
			// btCarros
			// 
			this.btCarros.Location = new System.Drawing.Point(130, 12);
			this.btCarros.Name = "btCarros";
			this.btCarros.Size = new System.Drawing.Size(112, 40);
			this.btCarros.TabIndex = 4;
			this.btCarros.Text = "Carros";
			this.btCarros.UseVisualStyleBackColor = true;
			// 
			// frUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btCarros);
			this.Controls.Add(this.btMarcas);
			this.Controls.Add(this.btVendas);
			this.Controls.Add(this.btAdiciona);
			this.Controls.Add(this.dataGridView1);
			this.Name = "frUsuario";
			this.Text = "frUsuario";
			this.Load += new System.EventHandler(this.FrUsuario_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.querrysInnerJoinDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private QuerrysInnerJoinDataSet querrysInnerJoinDataSet;
		private System.Windows.Forms.BindingSource usuariosBindingSource;
		private QuerrysInnerJoinDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
		private System.Windows.Forms.DataGridViewButtonColumn Deleta;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn usuIncDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn usuAltDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn datIncDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn datAltDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn deletCommandDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button btAdiciona;
		private System.Windows.Forms.Button btVendas;
		private System.Windows.Forms.Button btMarcas;
		private System.Windows.Forms.Button btCarros;
	}
}