namespace App_Cadastro
{
    partial class UcConsultarDados
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            fbDataReaderBindingSource = new BindingSource(components);
            colCodigo_Interno = new DataGridViewTextBoxColumn();
            colNcm = new DataGridViewTextBoxColumn();
            colCodigoBarra = new DataGridViewTextBoxColumn();
            colNomeProduto = new DataGridViewTextBoxColumn();
            colMarca = new DataGridViewTextBoxColumn();
            colPrecoCusto = new DataGridViewTextBoxColumn();
            colPrecoVenda = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            colUnMedida = new DataGridViewTextBoxColumn();
            colEstoqueMin = new DataGridViewTextBoxColumn();
            colEstoqueAtual = new DataGridViewTextBoxColumn();
            colDescricao = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fbDataReaderBindingSource).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(1021, 100);
            guna2Panel1.TabIndex = 0;
            // 
            // guna2DataGridView1
            // 
            guna2DataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 53;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.Columns.AddRange(new DataGridViewColumn[] { colCodigo_Interno, colNcm, colCodigoBarra, colNomeProduto, colMarca, colPrecoCusto, colPrecoVenda, Categoria, colUnMedida, colEstoqueMin, colEstoqueAtual, colDescricao });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.Dock = DockStyle.Fill;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(0, 100);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.ScrollBars = ScrollBars.Horizontal;
            guna2DataGridView1.Size = new Size(1021, 548);
            guna2DataGridView1.TabIndex = 1;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9.75F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 53;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9.75F);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 27;
            guna2DataGridView1.CellContentClick += guna2DataGridView1_CellContentClick;
            // 
            // fbDataReaderBindingSource
            // 
            fbDataReaderBindingSource.DataSource = typeof(FirebirdSql.Data.FirebirdClient.FbDataReader);
            // 
            // colCodigo_Interno
            // 
            colCodigo_Interno.HeaderText = "Código Interno";
            colCodigo_Interno.Name = "colCodigo_Interno";
            colCodigo_Interno.ReadOnly = true;
            // 
            // colNcm
            // 
            colNcm.HeaderText = "NCM";
            colNcm.Name = "colNcm";
            colNcm.ReadOnly = true;
            // 
            // colCodigoBarra
            // 
            colCodigoBarra.HeaderText = "Código de Barras";
            colCodigoBarra.Name = "colCodigoBarra";
            colCodigoBarra.ReadOnly = true;
            // 
            // colNomeProduto
            // 
            colNomeProduto.HeaderText = "Nome do Produto";
            colNomeProduto.Name = "colNomeProduto";
            colNomeProduto.ReadOnly = true;
            // 
            // colMarca
            // 
            colMarca.HeaderText = "Marca";
            colMarca.Name = "colMarca";
            colMarca.ReadOnly = true;
            // 
            // colPrecoCusto
            // 
            colPrecoCusto.HeaderText = "Preço de Custo";
            colPrecoCusto.Name = "colPrecoCusto";
            colPrecoCusto.ReadOnly = true;
            // 
            // colPrecoVenda
            // 
            colPrecoVenda.HeaderText = "Preco de Venda";
            colPrecoVenda.Name = "colPrecoVenda";
            colPrecoVenda.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // colUnMedida
            // 
            colUnMedida.HeaderText = "Unidade de Medida";
            colUnMedida.Name = "colUnMedida";
            colUnMedida.ReadOnly = true;
            // 
            // colEstoqueMin
            // 
            colEstoqueMin.HeaderText = "Estoque Minímo";
            colEstoqueMin.Name = "colEstoqueMin";
            colEstoqueMin.ReadOnly = true;
            // 
            // colEstoqueAtual
            // 
            colEstoqueAtual.HeaderText = "Estoque Atual";
            colEstoqueAtual.Name = "colEstoqueAtual";
            colEstoqueAtual.ReadOnly = true;
            // 
            // colDescricao
            // 
            colDescricao.HeaderText = "Descrição";
            colDescricao.Name = "colDescricao";
            colDescricao.ReadOnly = true;
            // 
            // UcConsultarDados
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2DataGridView1);
            Controls.Add(guna2Panel1);
            Name = "UcConsultarDados";
            Size = new Size(1021, 648);
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fbDataReaderBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private BindingSource fbDataReaderBindingSource;
        private DataGridViewTextBoxColumn colCodigo_Interno;
        private DataGridViewTextBoxColumn colNcm;
        private DataGridViewTextBoxColumn colCodigoBarra;
        private DataGridViewTextBoxColumn colNomeProduto;
        private DataGridViewTextBoxColumn colMarca;
        private DataGridViewTextBoxColumn colPrecoCusto;
        private DataGridViewTextBoxColumn colPrecoVenda;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn colUnMedida;
        private DataGridViewTextBoxColumn colEstoqueMin;
        private DataGridViewTextBoxColumn colEstoqueAtual;
        private DataGridViewTextBoxColumn colDescricao;
    }
}
