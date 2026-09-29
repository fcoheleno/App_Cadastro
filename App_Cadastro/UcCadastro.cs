using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App_Cadastro
{
    public partial class UcCadastro : UserControl
    {
        public UcCadastro()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtNomeProduto = new Guna.UI2.WinForms.Guna2TextBox();
            labelNome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            labelMarca = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtMarca = new Guna.UI2.WinForms.Guna2TextBox();
            lableEstoqueMin = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtEstoqueMin = new Guna.UI2.WinForms.Guna2TextBox();
            labelTitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            labelEstoqueAtual = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtEstoqueAtual = new Guna.UI2.WinForms.Guna2TextBox();
            labelCdBarras = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtCdBarras = new Guna.UI2.WinForms.Guna2TextBox();
            labelPrecoCusto = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtPrecoCusto = new Guna.UI2.WinForms.Guna2TextBox();
            labelPrecoVenda = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtPrecoVenda = new Guna.UI2.WinForms.Guna2TextBox();
            labelDescricao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtDescricao = new Guna.UI2.WinForms.Guna2TextBox();
            labelNcm = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtNcm = new Guna.UI2.WinForms.Guna2TextBox();
            labelUnidadeMedida = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtUnMedida = new Guna.UI2.WinForms.Guna2TextBox();
            btnCadastrar = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            labelCategoria = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.BorderRadius = 5;
            txtNomeProduto.CustomizableEdges = customizableEdges1;
            txtNomeProduto.DefaultText = "";
            txtNomeProduto.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNomeProduto.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNomeProduto.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNomeProduto.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNomeProduto.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNomeProduto.Font = new Font("Segoe UI", 9F);
            txtNomeProduto.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNomeProduto.Location = new Point(44, 159);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.PlaceholderText = "";
            txtNomeProduto.SelectedText = "";
            txtNomeProduto.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtNomeProduto.Size = new Size(365, 36);
            txtNomeProduto.TabIndex = 0;
            txtNomeProduto.TextChanged += txtNomeProduto_TextChanged;
            // 
            // labelNome
            // 
            labelNome.BackColor = Color.Transparent;
            labelNome.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNome.ForeColor = Color.Navy;
            labelNome.Location = new Point(55, 120);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(180, 32);
            labelNome.TabIndex = 1;
            labelNome.Text = "Nome do produto";
            // 
            // labelMarca
            // 
            labelMarca.BackColor = Color.Transparent;
            labelMarca.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMarca.ForeColor = Color.Navy;
            labelMarca.Location = new Point(55, 206);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(180, 32);
            labelMarca.TabIndex = 3;
            labelMarca.Text = "Marca do produto";
            // 
            // txtMarca
            // 
            txtMarca.BorderRadius = 5;
            txtMarca.CustomizableEdges = customizableEdges3;
            txtMarca.DefaultText = "";
            txtMarca.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMarca.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMarca.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMarca.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMarca.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMarca.Font = new Font("Segoe UI", 9F);
            txtMarca.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMarca.Location = new Point(44, 244);
            txtMarca.Name = "txtMarca";
            txtMarca.PlaceholderText = "";
            txtMarca.SelectedText = "";
            txtMarca.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtMarca.Size = new Size(365, 36);
            txtMarca.TabIndex = 2;
            txtMarca.TextChanged += txtMarca_TextChanged;
            // 
            // lableEstoqueMin
            // 
            lableEstoqueMin.BackColor = Color.Transparent;
            lableEstoqueMin.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lableEstoqueMin.ForeColor = Color.Navy;
            lableEstoqueMin.Location = new Point(55, 375);
            lableEstoqueMin.Name = "lableEstoqueMin";
            lableEstoqueMin.Size = new Size(159, 32);
            lableEstoqueMin.TabIndex = 5;
            lableEstoqueMin.Text = "Estoque Mínimo";
            // 
            // txtEstoqueMin
            // 
            txtEstoqueMin.BorderRadius = 5;
            txtEstoqueMin.CustomizableEdges = customizableEdges5;
            txtEstoqueMin.DefaultText = "";
            txtEstoqueMin.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEstoqueMin.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEstoqueMin.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEstoqueMin.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEstoqueMin.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEstoqueMin.Font = new Font("Segoe UI", 9F);
            txtEstoqueMin.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEstoqueMin.Location = new Point(44, 414);
            txtEstoqueMin.Name = "txtEstoqueMin";
            txtEstoqueMin.PlaceholderText = "";
            txtEstoqueMin.SelectedText = "";
            txtEstoqueMin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtEstoqueMin.Size = new Size(365, 36);
            txtEstoqueMin.TabIndex = 4;
            txtEstoqueMin.TextChanged += txtEstoqueMin_TextChanged;
            // 
            // labelTitulo
            // 
            labelTitulo.BackColor = Color.Transparent;
            labelTitulo.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.Navy;
            labelTitulo.Location = new Point(44, 42);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(268, 39);
            labelTitulo.TabIndex = 6;
            labelTitulo.Text = "Cadastro de produtos";
            // 
            // labelEstoqueAtual
            // 
            labelEstoqueAtual.BackColor = Color.Transparent;
            labelEstoqueAtual.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEstoqueAtual.ForeColor = Color.Navy;
            labelEstoqueAtual.Location = new Point(55, 291);
            labelEstoqueAtual.Name = "labelEstoqueAtual";
            labelEstoqueAtual.Size = new Size(136, 32);
            labelEstoqueAtual.TabIndex = 8;
            labelEstoqueAtual.Text = "Estoque Atual";
            // 
            // txtEstoqueAtual
            // 
            txtEstoqueAtual.BorderRadius = 5;
            txtEstoqueAtual.CustomizableEdges = customizableEdges7;
            txtEstoqueAtual.DefaultText = "";
            txtEstoqueAtual.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEstoqueAtual.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEstoqueAtual.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEstoqueAtual.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEstoqueAtual.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEstoqueAtual.Font = new Font("Segoe UI", 9F);
            txtEstoqueAtual.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEstoqueAtual.Location = new Point(44, 330);
            txtEstoqueAtual.Name = "txtEstoqueAtual";
            txtEstoqueAtual.PlaceholderText = "";
            txtEstoqueAtual.SelectedText = "";
            txtEstoqueAtual.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtEstoqueAtual.Size = new Size(365, 36);
            txtEstoqueAtual.TabIndex = 7;
            txtEstoqueAtual.TextChanged += txtEstoqueAtual_TextChanged;
            // 
            // labelCdBarras
            // 
            labelCdBarras.BackColor = Color.Transparent;
            labelCdBarras.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCdBarras.ForeColor = Color.Navy;
            labelCdBarras.Location = new Point(462, 204);
            labelCdBarras.Name = "labelCdBarras";
            labelCdBarras.Size = new Size(169, 32);
            labelCdBarras.TabIndex = 10;
            labelCdBarras.Text = "Código de Barras";
            // 
            // txtCdBarras
            // 
            txtCdBarras.BorderRadius = 5;
            txtCdBarras.CustomizableEdges = customizableEdges9;
            txtCdBarras.DefaultText = "";
            txtCdBarras.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCdBarras.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCdBarras.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCdBarras.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCdBarras.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCdBarras.Font = new Font("Segoe UI", 9F);
            txtCdBarras.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCdBarras.Location = new Point(451, 243);
            txtCdBarras.Name = "txtCdBarras";
            txtCdBarras.PlaceholderText = "";
            txtCdBarras.SelectedText = "";
            txtCdBarras.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtCdBarras.Size = new Size(365, 36);
            txtCdBarras.TabIndex = 9;
            txtCdBarras.TextChanged += txtCdBarras_TextChanged;
            // 
            // labelPrecoCusto
            // 
            labelPrecoCusto.BackColor = Color.Transparent;
            labelPrecoCusto.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrecoCusto.ForeColor = Color.Navy;
            labelPrecoCusto.Location = new Point(55, 546);
            labelPrecoCusto.Name = "labelPrecoCusto";
            labelPrecoCusto.Size = new Size(148, 32);
            labelPrecoCusto.TabIndex = 12;
            labelPrecoCusto.Text = "Preço de Custo";
            // 
            // txtPrecoCusto
            // 
            txtPrecoCusto.BorderRadius = 5;
            txtPrecoCusto.CustomizableEdges = customizableEdges11;
            txtPrecoCusto.DefaultText = "";
            txtPrecoCusto.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPrecoCusto.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPrecoCusto.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPrecoCusto.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPrecoCusto.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrecoCusto.Font = new Font("Segoe UI", 9F);
            txtPrecoCusto.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrecoCusto.Location = new Point(44, 585);
            txtPrecoCusto.Name = "txtPrecoCusto";
            txtPrecoCusto.PlaceholderText = "";
            txtPrecoCusto.SelectedText = "";
            txtPrecoCusto.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtPrecoCusto.Size = new Size(365, 36);
            txtPrecoCusto.TabIndex = 11;
            txtPrecoCusto.TextChanged += txtPrecoCusto_TextChanged;
            // 
            // labelPrecoVenda
            // 
            labelPrecoVenda.BackColor = Color.Transparent;
            labelPrecoVenda.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrecoVenda.ForeColor = Color.Navy;
            labelPrecoVenda.Location = new Point(462, 120);
            labelPrecoVenda.Name = "labelPrecoVenda";
            labelPrecoVenda.Size = new Size(153, 32);
            labelPrecoVenda.TabIndex = 14;
            labelPrecoVenda.Text = "Preço de Venda";
            labelPrecoVenda.Click += guna2HtmlLabel1_Click;
            // 
            // txtPrecoVenda
            // 
            txtPrecoVenda.BorderRadius = 5;
            txtPrecoVenda.CustomizableEdges = customizableEdges13;
            txtPrecoVenda.DefaultText = "";
            txtPrecoVenda.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPrecoVenda.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPrecoVenda.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPrecoVenda.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPrecoVenda.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrecoVenda.Font = new Font("Segoe UI", 9F);
            txtPrecoVenda.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrecoVenda.Location = new Point(451, 159);
            txtPrecoVenda.Name = "txtPrecoVenda";
            txtPrecoVenda.PlaceholderText = "";
            txtPrecoVenda.SelectedText = "";
            txtPrecoVenda.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtPrecoVenda.Size = new Size(365, 36);
            txtPrecoVenda.TabIndex = 13;
            txtPrecoVenda.TextChanged += guna2TextBox6_TextChanged;
            // 
            // labelDescricao
            // 
            labelDescricao.BackColor = Color.Transparent;
            labelDescricao.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDescricao.ForeColor = Color.Navy;
            labelDescricao.Location = new Point(462, 443);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(95, 32);
            labelDescricao.TabIndex = 16;
            labelDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.BorderRadius = 5;
            txtDescricao.CustomizableEdges = customizableEdges15;
            txtDescricao.DefaultText = "";
            txtDescricao.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDescricao.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDescricao.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDescricao.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDescricao.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDescricao.Font = new Font("Segoe UI", 9F);
            txtDescricao.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDescricao.Location = new Point(451, 482);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "";
            txtDescricao.SelectedText = "";
            txtDescricao.ShadowDecoration.CustomizableEdges = customizableEdges16;
            txtDescricao.Size = new Size(365, 96);
            txtDescricao.TabIndex = 15;
            txtDescricao.TextChanged += txtDescricao_TextChanged;
            // 
            // labelNcm
            // 
            labelNcm.BackColor = Color.Transparent;
            labelNcm.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNcm.ForeColor = Color.Navy;
            labelNcm.Location = new Point(462, 285);
            labelNcm.Name = "labelNcm";
            labelNcm.Size = new Size(51, 32);
            labelNcm.TabIndex = 18;
            labelNcm.Text = "NCM";
            // 
            // txtNcm
            // 
            txtNcm.BorderRadius = 5;
            txtNcm.CustomizableEdges = customizableEdges17;
            txtNcm.DefaultText = "";
            txtNcm.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNcm.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNcm.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNcm.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNcm.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNcm.Font = new Font("Segoe UI", 9F);
            txtNcm.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNcm.Location = new Point(451, 324);
            txtNcm.Name = "txtNcm";
            txtNcm.PlaceholderText = "";
            txtNcm.SelectedText = "";
            txtNcm.ShadowDecoration.CustomizableEdges = customizableEdges18;
            txtNcm.Size = new Size(365, 36);
            txtNcm.TabIndex = 17;
            txtNcm.TextChanged += txtNcm_TextChanged;
            // 
            // labelUnidadeMedida
            // 
            labelUnidadeMedida.BackColor = Color.Transparent;
            labelUnidadeMedida.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUnidadeMedida.ForeColor = Color.Navy;
            labelUnidadeMedida.Location = new Point(55, 459);
            labelUnidadeMedida.Name = "labelUnidadeMedida";
            labelUnidadeMedida.Size = new Size(191, 32);
            labelUnidadeMedida.TabIndex = 20;
            labelUnidadeMedida.Text = "Unidade de Medida";
            // 
            // txtUnMedida
            // 
            txtUnMedida.BorderRadius = 5;
            txtUnMedida.CustomizableEdges = customizableEdges19;
            txtUnMedida.DefaultText = "";
            txtUnMedida.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUnMedida.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUnMedida.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUnMedida.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUnMedida.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUnMedida.Font = new Font("Segoe UI", 9F);
            txtUnMedida.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUnMedida.Location = new Point(44, 498);
            txtUnMedida.Name = "txtUnMedida";
            txtUnMedida.PlaceholderText = "";
            txtUnMedida.SelectedText = "";
            txtUnMedida.ShadowDecoration.CustomizableEdges = customizableEdges20;
            txtUnMedida.Size = new Size(365, 36);
            txtUnMedida.TabIndex = 19;
            txtUnMedida.TextChanged += txtUnMedida_TextChanged;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Transparent;
            btnCadastrar.BorderRadius = 10;
            btnCadastrar.CustomizableEdges = customizableEdges21;
            btnCadastrar.DisabledState.BorderColor = Color.DarkGray;
            btnCadastrar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCadastrar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCadastrar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCadastrar.FillColor = Color.Navy;
            btnCadastrar.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(451, 612);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.ShadowDecoration.CustomizableEdges = customizableEdges22;
            btnCadastrar.Size = new Size(172, 66);
            btnCadastrar.TabIndex = 21;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderRadius = 10;
            guna2Button1.CustomizableEdges = customizableEdges23;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Navy;
            guna2Button1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(644, 612);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges24;
            guna2Button1.Size = new Size(172, 66);
            guna2Button1.TabIndex = 22;
            guna2Button1.Text = "Limpar";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // labelCategoria
            // 
            labelCategoria.BackColor = Color.Transparent;
            labelCategoria.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCategoria.ForeColor = Color.Navy;
            labelCategoria.Location = new Point(462, 369);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(96, 32);
            labelCategoria.TabIndex = 24;
            labelCategoria.Text = "Categoria";
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BorderRadius = 5;
            guna2TextBox1.CustomizableEdges = customizableEdges25;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(451, 408);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges26;
            guna2TextBox1.Size = new Size(365, 36);
            guna2TextBox1.TabIndex = 23;
            guna2TextBox1.TextChanged += guna2TextBox1_TextChanged;
            // 
            // UcCadastro
            // 
            Controls.Add(labelCategoria);
            Controls.Add(guna2TextBox1);
            Controls.Add(guna2Button1);
            Controls.Add(btnCadastrar);
            Controls.Add(labelUnidadeMedida);
            Controls.Add(txtUnMedida);
            Controls.Add(labelNcm);
            Controls.Add(txtNcm);
            Controls.Add(labelDescricao);
            Controls.Add(txtDescricao);
            Controls.Add(labelPrecoVenda);
            Controls.Add(txtPrecoVenda);
            Controls.Add(labelPrecoCusto);
            Controls.Add(txtPrecoCusto);
            Controls.Add(labelCdBarras);
            Controls.Add(txtCdBarras);
            Controls.Add(labelEstoqueAtual);
            Controls.Add(txtEstoqueAtual);
            Controls.Add(labelTitulo);
            Controls.Add(lableEstoqueMin);
            Controls.Add(txtEstoqueMin);
            Controls.Add(labelMarca);
            Controls.Add(txtMarca);
            Controls.Add(labelNome);
            Controls.Add(txtNomeProduto);
            Name = "UcCadastro";
            Size = new Size(871, 724);
            ResumeLayout(false);
            PerformLayout();

        }




        private Guna.UI2.WinForms.Guna2TextBox txtNomeProduto;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelNome;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelMarca;
        private Guna.UI2.WinForms.Guna2TextBox txtMarca;
        private Guna.UI2.WinForms.Guna2HtmlLabel lableEstoqueMin;
        private Guna.UI2.WinForms.Guna2TextBox txtEstoqueMin;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelTitulo;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelEstoqueAtual;
        private Guna.UI2.WinForms.Guna2TextBox txtEstoqueAtual;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelCdBarras;
        private Guna.UI2.WinForms.Guna2TextBox txtCdBarras;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelPrecoCusto;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecoCusto;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelPrecoVenda;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecoVenda;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelDescricao;
        private Guna.UI2.WinForms.Guna2TextBox txtDescricao;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelNcm;
        private Guna.UI2.WinForms.Guna2TextBox txtNcm;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelUnidadeMedida;
        private Guna.UI2.WinForms.Guna2TextBox txtUnMedida;
        private Guna.UI2.WinForms.Guna2Button btnCadastrar;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelCategoria;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nomeProduto = txtNomeProduto.Text;
            string marca = txtMarca.Text;
            string estoqueAtual = txtEstoqueAtual.Text;
            string estoqueMin = txtEstoqueMin.Text;
            string unMedida = txtUnMedida.Text;
            string descricao = txtDescricao.Text;
            string precoCusto = txtPrecoCusto.Text;
            string precoVenda = txtPrecoVenda.Text;
        }

        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEstoqueAtual_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEstoqueMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUnMedida_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNcm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecoCusto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCdBarras_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
