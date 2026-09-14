namespace App_Cadastro
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            nomeUsuario = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            linkCadastrar = new LinkLabel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 704);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Controls.Add(linkCadastrar);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(nomeUsuario);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(321, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(651, 704);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(291, 123);
            label1.Name = "label1";
            label1.Size = new Size(94, 40);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // nomeUsuario
            // 
            nomeUsuario.Location = new Point(150, 251);
            nomeUsuario.Multiline = true;
            nomeUsuario.Name = "nomeUsuario";
            nomeUsuario.Size = new Size(356, 38);
            nomeUsuario.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 401);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(356, 38);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(150, 206);
            label2.Name = "label2";
            label2.Size = new Size(215, 32);
            label2.TabIndex = 3;
            label2.Text = "Nome do Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(159, 357);
            label3.Name = "label3";
            label3.Size = new Size(82, 32);
            label3.TabIndex = 4;
            label3.Text = "Senha";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(0, 0, 64);
            btnLogin.Location = new Point(252, 508);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(144, 47);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Logar";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // linkCadastrar
            // 
            linkCadastrar.AutoSize = true;
            linkCadastrar.Cursor = Cursors.Hand;
            linkCadastrar.DisabledLinkColor = Color.White;
            linkCadastrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkCadastrar.ForeColor = Color.White;
            linkCadastrar.LinkBehavior = LinkBehavior.NeverUnderline;
            linkCadastrar.LinkColor = Color.White;
            linkCadastrar.Location = new Point(209, 585);
            linkCadastrar.Name = "linkCadastrar";
            linkCadastrar.Size = new Size(227, 21);
            linkCadastrar.TabIndex = 6;
            linkCadastrar.TabStop = true;
            linkCadastrar.Text = "Ainda não posssuo uma conta";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 704);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormLogin";
            Text = "Form2";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private TextBox nomeUsuario;
        private Label label1;
        private LinkLabel linkCadastrar;
        private Button btnLogin;
    }
}