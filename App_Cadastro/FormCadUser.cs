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

        private void nomeUser_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void senhaUser_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void emailUser_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            string nome = nomeUser.Text.Trim();
            string senha = senhaUser.Text.Trim();
            string email = emailUser.Text.Trim();

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
                    string insertQuery = "INSERT INTO ADMINISTRADORES(USUARIO, EMAIL, SENHA_HASH) VALUES(@nome, @email, @senhaHash);";
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
    }
}
