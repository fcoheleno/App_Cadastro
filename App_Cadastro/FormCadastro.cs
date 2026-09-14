using System;
using System.Collections.Generic;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using System.Windows.Forms;



namespace App_Cadastro
{

    public partial class FormCadastro : Form
    {
        private string connectionString = "User=SYSDBA;Password=helenin;Database=C:\\Bancos\\produtos.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=UTF8;";

        public FormCadastro()
        {
            InitializeComponent();
        }

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button BotaoVoltar;
        private TextBox txtQuantidade;
        private TextBox txtCodigo;
        private TextBox txtValor;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button BtnCadastro;
        private Label label6;
        private TextBox txtMarca;
        private Button button1;
        private Label label7;
        private PictureBox pictureBox1;
        private TextBox txtNome;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            panel1 = new Panel();
            label7 = new Label();
            button1 = new Button();
            BotaoVoltar = new Button();
            label1 = new Label();
            txtNome = new TextBox();
            panel2 = new Panel();
            label6 = new Label();
            txtMarca = new TextBox();
            BtnCadastro = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtQuantidade = new TextBox();
            txtCodigo = new TextBox();
            txtValor = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(BotaoVoltar);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 707);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("MicrogrammaDBolExt", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(80, 118);
            label7.Name = "label7";
            label7.Size = new Size(281, 31);
            label7.TabIndex = 11;
            label7.Text = "Seção de cadastro";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(0, 0, 64);
            button1.Location = new Point(143, 494);
            button1.Name = "button1";
            button1.Size = new Size(175, 60);
            button1.TabIndex = 10;
            button1.Text = "Consultar \r\nEstoque\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // BotaoVoltar
            // 
            BotaoVoltar.BackColor = Color.White;
            BotaoVoltar.Cursor = Cursors.Hand;
            BotaoVoltar.FlatStyle = FlatStyle.Flat;
            BotaoVoltar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotaoVoltar.ForeColor = Color.FromArgb(0, 0, 64);
            BotaoVoltar.Location = new Point(143, 582);
            BotaoVoltar.Name = "BotaoVoltar";
            BotaoVoltar.Size = new Size(175, 62);
            BotaoVoltar.TabIndex = 2;
            BotaoVoltar.Text = "Voltar";
            BotaoVoltar.UseVisualStyleBackColor = false;
            BotaoVoltar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("MicrogrammaDBolExt", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(641, 68);
            label1.Name = "label1";
            label1.Size = new Size(232, 62);
            label1.TabIndex = 1;
            label1.Text = "Preencha os \r\ncampos abaixo:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtNome
            // 
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(607, 284);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Digite aqui...";
            txtNome.Size = new Size(310, 36);
            txtNome.TabIndex = 0;
            txtNome.TabStop = false;
            txtNome.TextChanged += EntradaNome_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtMarca);
            panel2.Controls.Add(BtnCadastro);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtQuantidade);
            panel2.Controls.Add(txtCodigo);
            panel2.Controls.Add(txtValor);
            panel2.Controls.Add(txtNome);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1035, 707);
            panel2.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MicrogrammaDBolExt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 0, 64);
            label6.Location = new Point(607, 344);
            label6.Name = "label6";
            label6.Size = new Size(221, 24);
            label6.TabIndex = 9;
            label6.Text = "Marca do Produto:";
            // 
            // txtMarca
            // 
            txtMarca.Cursor = Cursors.IBeam;
            txtMarca.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMarca.Location = new Point(607, 371);
            txtMarca.Multiline = true;
            txtMarca.Name = "txtMarca";
            txtMarca.PlaceholderText = "Digite aqui...";
            txtMarca.Size = new Size(310, 36);
            txtMarca.TabIndex = 8;
            txtMarca.TabStop = false;
            txtMarca.TextChanged += MarcaProduto_TextChanged;
            // 
            // BtnCadastro
            // 
            BtnCadastro.BackColor = Color.FromArgb(0, 0, 64);
            BtnCadastro.Cursor = Cursors.Hand;
            BtnCadastro.FlatStyle = FlatStyle.Flat;
            BtnCadastro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCadastro.ForeColor = Color.White;
            BtnCadastro.Location = new Point(680, 610);
            BtnCadastro.Name = "BtnCadastro";
            BtnCadastro.Size = new Size(165, 53);
            BtnCadastro.TabIndex = 3;
            BtnCadastro.Text = "Cadastrar";
            BtnCadastro.UseVisualStyleBackColor = false;
            BtnCadastro.Click += BtnCadastro_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MicrogrammaDBolExt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(607, 512);
            label5.Name = "label5";
            label5.Size = new Size(278, 24);
            label5.TabIndex = 7;
            label5.Text = "Quantidade do Produto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MicrogrammaDBolExt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(607, 175);
            label4.Name = "label4";
            label4.Size = new Size(226, 24);
            label4.TabIndex = 6;
            label4.Text = "Código do Produto:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MicrogrammaDBolExt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(607, 428);
            label3.Name = "label3";
            label3.Size = new Size(209, 24);
            label3.TabIndex = 5;
            label3.Text = "Valor do Produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MicrogrammaDBolExt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(607, 257);
            label2.Name = "label2";
            label2.Size = new Size(215, 24);
            label2.TabIndex = 4;
            label2.Text = "Nome do Produto:";
            label2.Click += label2_Click;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Cursor = Cursors.IBeam;
            txtQuantidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantidade.Location = new Point(607, 539);
            txtQuantidade.Multiline = true;
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.PlaceholderText = "Digite aqui...";
            txtQuantidade.Size = new Size(310, 36);
            txtQuantidade.TabIndex = 3;
            txtQuantidade.TabStop = false;
            txtQuantidade.TextChanged += QuantidadeProduto_TextChanged;
            // 
            // txtCodigo
            // 
            txtCodigo.Cursor = Cursors.IBeam;
            txtCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigo.Location = new Point(607, 202);
            txtCodigo.Multiline = true;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PlaceholderText = "Digite aqui...";
            txtCodigo.Size = new Size(310, 36);
            txtCodigo.TabIndex = 2;
            txtCodigo.TabStop = false;
            txtCodigo.TextChanged += CodigoProduto_TextChanged;
            // 
            // txtValor
            // 
            txtValor.Cursor = Cursors.IBeam;
            txtValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValor.Location = new Point(607, 455);
            txtValor.Multiline = true;
            txtValor.Name = "txtValor";
            txtValor.PlaceholderText = "Digite aqui...";
            txtValor.Size = new Size(310, 36);
            txtValor.TabIndex = 1;
            txtValor.TabStop = false;
            txtValor.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(80, 175);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(295, 252);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // FormCadastro
            // 
            ClientSize = new Size(1035, 707);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // botao de voltar 
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 formInicial = new Form1();
            formInicial.Show();
            this.Hide();
        }

        // recebe o nome do produto
        private void EntradaNome_TextChanged(object sender, EventArgs e)
        {

        }

        // recebe o valor do produto
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CodigoProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuantidadeProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim().ToUpper();
            string nome = txtNome.Text.Trim().ToUpper();
            string marca = txtMarca.Text.Trim().ToUpper();
            string valorTexto = txtValor.Text.Trim().ToUpper();
            string quantidade = txtQuantidade.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("É necessário preencher todos os campos para poder cadastrar o produto.");
                return;
            }
            if (!decimal.TryParse(valorTexto, out decimal valor))
            {
                MessageBox.Show("O valor do produto não é válido.");
                return;
            }

            using (FbConnection conn = new FbConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string selectQuery = "SELECT COUNT(*) FROM PRODUTOS WHERE CODIGO = @codigo";
                    using (FbCommand selectCmd = new FbCommand(selectQuery, conn))
                    {
                        selectCmd.Parameters.AddWithValue("@codigo", codigo);
                        int count = Convert.ToInt32(selectCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Produto já cadastrado");
                            return;
                        }
                    }



                    string insertQuery = "INSERT INTO PRODUTOS(CODIGO, NOME, MARCA, VALOR, QUANTIDADE) VALUES (@codigo, @nome, @marca, @valor, @quantidade)";
                    using (FbCommand insertCmd = new FbCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@codigo", codigo);
                        insertCmd.Parameters.AddWithValue("@nome", nome);
                        insertCmd.Parameters.AddWithValue("@marca", marca);
                        insertCmd.Parameters.AddWithValue("@valor", valor);
                        insertCmd.Parameters.AddWithValue("@quantidade", quantidade);
                        insertCmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Produto cadastrado com sucesso!");
                    LimparCampos();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar: " + ex.Message);
                }

            }

        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtMarca.Clear();
            txtValor.Clear();
            txtQuantidade.Clear();
        }

        private void MarcaProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormConsulta formConsulta = new FormConsulta();
            formConsulta.Show();
            this.Hide();
        }
    }
}
