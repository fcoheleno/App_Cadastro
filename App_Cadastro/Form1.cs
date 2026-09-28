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

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormConsulta formConsulta = new FormConsulta(this);
            formConsulta.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AbrirCadastro() {

            panelConteudo.Controls.Clear();
            UcCadastro uc = new UcCadastro();
            uc.Dock = DockStyle.Fill;
            panelConteudo.Controls.Add(uc);
        }
    }
}