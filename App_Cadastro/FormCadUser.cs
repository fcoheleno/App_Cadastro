using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BCrypt.Net;
using FirebirdSql.Data.FirebirdClient;

namespace App_Cadastro
{
    public partial class FormCadUser : Form
    {
        private Form formAnterior;
        public FormCadUser(Form origem)
        {
            InitializeComponent();
            formAnterior = origem;
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnCriar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string senha = txtSenhaUser.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Preencha todos os campos acima!");
                return;
            }

            string senhaHash = BCrypt.Net.BCrypt.HashPassword(senha);

            using (FbConnection conn = new FbConnection(Conexao.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string insertQuery = "INSERT INTO ADMINISTRADORES(NOME_USER, EMAIL, SENHA_HASH) VALUES(@nome, @email, @senhaHash);";
                    using (FbCommand cmd = new FbCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@senhaHash", senhaHash);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("erro ao cadastrar: " + ex.Message);
                }
            }
        }

        private void btnCriar_MouseEnter(object sender, EventArgs e)
        {
            btnCriar.BackColor = Color.FromArgb(230, 230, 230);
        }

        private void btnCriar_MouseLeave(object sender, EventArgs e)
        {
            btnCriar.BackColor = Color.White;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            formAnterior.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin formLogin = new FormLogin(this);
            formLogin.Show();
            this.Hide();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenhaUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
