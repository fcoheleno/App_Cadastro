using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App_Cadastro
{
    public partial class FormLogin : Form
    {

        private Form formAnterior;
        public FormLogin(Form origem)
        {
            InitializeComponent();
            formAnterior = origem;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            formAnterior.Show();
            this.Close();
        }

        private void linkCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCadUser formCadUser = new FormCadUser(this);
            formCadUser.Show();
            this.Hide();
        }

        private void senhaUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = nomeUsuario.Text;
            string senhaDigitada = senhaUsuario.Text;

            using (FbConnection conn = Conexao.AbrirConexao())
            {
                try
                {
                    string query = "SELECT SENHA_HASH FROM ADMINISTRADORES WHERE USUARIO = @usuario;";
                    using (FbCommand cmd = new FbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        object resultado = cmd.ExecuteScalar();

                        if (resultado == null)
                        {
                            MessageBox.Show("Usuário não encontrado");
                            return;
                        }

                        string senhaHashSalva = resultado.ToString();
                        bool senhaCorreta = BCrypt.Net.BCrypt.Verify(senhaDigitada, senhaHashSalva);

                        if (senhaCorreta = true)
                        {
                            string selectId = "SELECT ID FROM ADMINISTRADORES WHERE USUARIO = @usuario;";
                            using (FbCommand cmdId = new FbCommand(selectId, conn))
                            {
                                cmdId.Parameters.AddWithValue("@usuario", usuario);
                                UsuarioLogado.Id = Convert.ToInt32(cmdId.ExecuteScalar());
                                UsuarioLogado.Nome = usuario;
                            }
                            ;
                            MessageBox.Show("Login feito com sucesso");
                            Form1 form1 = new Form1();
                            form1.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível fazer o login: senha incorreta!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:" + ex.Message);
                }

                }
                
            }
        }
    }

