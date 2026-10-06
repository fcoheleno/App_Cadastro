using System.Windows.Forms;

namespace App_Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            AbrirCadastro();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void AbrirConsulta(object sender, EventArgs e)
        {
            panelConteudo.Controls.Clear();
            UcConsultarDados cd = new UcConsultarDados();
            cd.Dock = DockStyle.Fill;
            panelConteudo.Controls.Add(cd);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AbrirCadastro()
        {

            panelConteudo.Controls.Clear();
            UcCadastro uc = new UcCadastro();
            uc.Dock = DockStyle.Fill;
            panelConteudo.Controls.Add(uc);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FormInicial form = new FormInicial();
            form.Show();
            UsuarioLogado.Logout();
            this.Close();
        }
    }
}