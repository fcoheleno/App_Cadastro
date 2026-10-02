using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App_Cadastro
{
    public partial class UcConsultarDados : UserControl
    {
        public UcConsultarDados()
        {
            InitializeComponent();
            ConfigurarColunas();
            CarregarProdutos();
        }

        DataGridView dgvProdutos = new DataGridView();

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            dgvProdutos.AutoGenerateColumns = false;
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.BorderStyle = BorderStyle.None;
            dgvProdutos.BackgroundColor = Color.White;
            dgvProdutos.GridColor = Color.FromArgb(235, 235, 235);
            dgvProdutos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 64);
            dgvProdutos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProdutos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvProdutos.ColumnHeadersHeight = 40;
            dgvProdutos.EnableHeadersVisualStyles = false;
            dgvProdutos.RowTemplate.Height = 35;
            dgvProdutos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 250);
            dgvProdutos.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvProdutos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 0, 64);
            dgvProdutos.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void CarregarProdutos()
        {
            dgvProdutos.Columns.Add("colCodigo", "Código");
            dgvProdutos.Columns.Add("colNcm", "NCM");
            dgvProdutos.Columns.Add("colCodigoBarra", "Código de Barras");
            dgvProdutos.Columns.Add("colNomeProduto", "Nome do Produto");
            dgvProdutos.Columns.Add("colCategoria", "Categoria");
            dgvProdutos.Columns.Add("colUnMedida", "Unidade de Medida");
            dgvProdutos.Columns.Add("colMarca", "Marca");
            dgvProdutos.Columns.Add("colPrecoCusto", "Preço de Custo");
            dgvProdutos.Columns.Add("colPrecoVenda", "Preço de Venda");
            dgvProdutos.Columns.Add("colEstoqueAtual", "Estoque Atual");
            dgvProdutos.Columns.Add("colEstoqueMin", "Estoque Mínimo");
            dgvProdutos.Columns.Add("colDescricao", "Descrição");

            dgvProdutos.Columns["colCodigo"].DataPropertyName = "CODIGO";
        }
    }
}
