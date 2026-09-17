using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace App_Cadastro
{
    public partial class FormConsulta : Form
    {

        public Form formAnterior;
        public FormConsulta(Form origem)
        {
            InitializeComponent();
            Carregarprodutos();
            formAnterior = origem;

        }

        private void Carregarprodutos()
        {

            flpProdutos.Controls.Clear();
            using (FbConnection conn = new FbConnection(Conexao.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT CODIGO, NOME, MARCA, VALOR, QUANTIDADE FROM PRODUTOS WHERE USUARIO_ID = @usuarioId";

                    using (FbCommand cmd = new FbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuarioId", UsuarioLogado.Id);

                        using (FbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string codigo = reader["CODIGO"].ToString();
                                string nome = reader["NOME"].ToString();
                                string marca = reader["MARCA"].ToString();
                                decimal valor = Convert.ToDecimal(reader["VALOR"]);
                                int quantidade = Convert.ToInt32(reader["QUANTIDADE"]);
                                string labelTxtValor = valor.ToString("C2", new System.Globalization.CultureInfo("pt-BR"));

                                Panel card = CriarCardProduto(codigo, nome, marca, valor, quantidade);
                                flpProdutos.Controls.Add(card);
                            }
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os produtos:" + ex.Message);
                }
            }
        }

        private Panel CriarCardProduto(string codigo, string nome, string marca, decimal valor, int quantidade)
        {
            Panel card = new Panel
            {
                Width = flpProdutos.Size.Width - 40,
                Height = 100,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(5)
            };

            Label lbl = new Label
            {
                Text = $"Código: {codigo} | Nome: {nome.ToUpper()} | Marca: {marca.ToUpper()} | Valor: {valor} | Quantidade: {quantidade} |",
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(8),
                Font = new Font("Segoe UI", 16F, FontStyle.Regular),
                ForeColor = Color.FromArgb(0, 0, 64)
            };

            Button btnEditar = new Button
            {
                Text = "Editar",
                Dock = DockStyle.Right,
                Width = 80
            };

            btnEditar.Click += (sender, e) => AbrirEdicao(codigo, nome, marca, valor, quantidade);

            card.Controls.Add(lbl);
            card.Controls.Add(btnEditar);
            return card;
        }

        private void AbrirEdicao(string codigo, string nome, string marca, decimal valor, int quantidade)
        {
            FormCadastro formEdicao = new FormCadastro(this, codigo, nome, marca, valor, quantidade);
            formEdicao.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formAnterior.Show();
            this.Hide();
        }

        private void flpProdutos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
