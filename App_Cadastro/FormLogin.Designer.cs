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
            btnVoltar = new Button();
            panel2 = new Panel();
            linkCadastrar = new LinkLabel();
            btnLogin = new Button();
            label3 = new Label();
            label2 = new Label();
            senhaUsuario = new TextBox();
            nomeUsuario = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnVoltar);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 659);
            panel1.TabIndex = 0;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Navy;
            btnVoltar.FlatStyle = FlatStyle.Popup;
            btnVoltar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(111, 452);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(133, 50);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(linkCadastrar);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(senhaUsuario);
            panel2.Controls.Add(nomeUsuario);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(321, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(564, 659);
            panel2.TabIndex = 1;
            // 
            // linkCadastrar
            // 
            linkCadastrar.ActiveLinkColor = Color.ForestGreen;
            linkCadastrar.AutoSize = true;
            linkCadastrar.Cursor = Cursors.Hand;
            linkCadastrar.DisabledLinkColor = Color.White;
            linkCadastrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkCadastrar.ForeColor = Color.White;
            linkCadastrar.LinkBehavior = LinkBehavior.NeverUnderline;
            linkCadastrar.LinkColor = Color.White;
            linkCadastrar.Location = new Point(169, 529);
            linkCadastrar.Name = "linkCadastrar";
            linkCadastrar.Size = new Size(221, 21);
            linkCadastrar.TabIndex = 6;
            linkCadastrar.TabStop = true;
            linkCadastrar.Text = "Ainda não possui uma conta?";
            linkCadastrar.LinkClicked += linkCadastrar_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Navy;
            btnLogin.Location = new Point(212, 452);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(133, 50);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Logar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(119, 315);
            label3.Name = "label3";
            label3.Size = new Size(82, 32);
            label3.TabIndex = 4;
            label3.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(110, 188);
            label2.Name = "label2";
            label2.Size = new Size(215, 32);
            label2.TabIndex = 3;
            label2.Text = "Nome do Usuário";
            // 
            // senhaUsuario
            // 
            senhaUsuario.Location = new Point(110, 359);
            senhaUsuario.Multiline = true;
            senhaUsuario.Name = "senhaUsuario";
            senhaUsuario.Size = new Size(333, 41);
            senhaUsuario.TabIndex = 2;
            senhaUsuario.TextChanged += senhaUsuario_TextChanged;
            // 
            // nomeUsuario
            // 
            nomeUsuario.Location = new Point(110, 233);
            nomeUsuario.Multiline = true;
            nomeUsuario.Name = "nomeUsuario";
            nomeUsuario.Size = new Size(333, 41);
            nomeUsuario.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(251, 105);
            label1.Name = "label1";
            label1.Size = new Size(94, 40);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 659);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private TextBox senhaUsuario;
        private TextBox nomeUsuario;
        private Label label1;
        private LinkLabel linkCadastrar;
        private Button btnLogin;
        private Button btnVoltar;
    }
}