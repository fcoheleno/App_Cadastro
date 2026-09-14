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
        private string connectionString = "User=SYSDBA;Password=helenin;Database=C:\\Bancos\\produtos.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=UTF8;";

        public FormConsulta()
        {
            InitializeComponent();
            Carregarprodutos();

        }

        private void Carregarprodutos()
        {

            flpProdutos.Controls.Clear();
            using (FbConnection conn = new FbConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT CODIGO, NOME, MARCA, VALOR, QUANTIDADE FROM PRODUTOS";

                    using (FbCommand cmd = new FbCommand(query, conn))
                    using (FbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string codigo = reader["CODIGO"].ToString();
                            string nome = reader["NOME"].ToString();
                            string marca = reader["MARCA"].ToString();
                            decimal valor = Convert.ToDecimal(reader["VALOR"]);
                            int quantidade = Convert.ToInt32(reader["QUANTIDADE"]);

                            Panel card = CriarCardProduto(codigo, nome, marca, valor, quantidade);
                            flpProdutos.Controls.Add(card);
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

            card.Controls.Add(lbl);
            return card;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 forminicial = new Form1();
            forminicial.Show();
            this.Hide();
        }
    }
}
