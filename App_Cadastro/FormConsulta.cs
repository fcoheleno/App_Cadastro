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
        public FormConsulta()
        {
            InitializeComponent();

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

        private Panel CriarCardProdutos(string codigo, string nome, string marca, decimal valor, int quantidade)
        {
            Panel card = new Panel
            {
                Width = 350,
                Height = 80,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(5)
            };

            Label lbl = new Label
            {
                Text = $"Código: {codigo} | Nome: {nome} | Marca: {marca} | Valor: {valor} | Quantidade: {quantidade} |"
            }
        }
    }
}
