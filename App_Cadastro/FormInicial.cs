using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App_Cadastro
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin(this);
            formLogin.Show();
            this.Hide();
        }
    }
}
