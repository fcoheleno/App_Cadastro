namespace App_Cadastro
{
    partial class FormCadUser
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
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnCriarConta = new Button();
            label1 = new Label();
            emailUser = new TextBox();
            senhaUser = new TextBox();
            nomeUser = new TextBox();
            btnVoltar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnCriarConta);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(emailUser);
            panel1.Controls.Add(senhaUser);
            panel1.Controls.Add(nomeUser);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(282, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(622, 612);
            panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Navy;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = Color.White;
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(222, 553);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(175, 21);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Já possue uma conta?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(130, 281);
            label4.Name = "label4";
            label4.Size = new Size(86, 32);
            label4.TabIndex = 7;
            label4.Text = "E-mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(134, 366);
            label3.Name = "label3";
            label3.Size = new Size(82, 32);
            label3.TabIndex = 6;
            label3.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(130, 192);
            label2.Name = "label2";
            label2.Size = new Size(213, 32);
            label2.TabIndex = 5;
            label2.Text = "Nome do usuário";
            // 
            // btnCriarConta
            // 
            btnCriarConta.BackColor = Color.White;
            btnCriarConta.FlatStyle = FlatStyle.Popup;
            btnCriarConta.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCriarConta.ForeColor = Color.Navy;
            btnCriarConta.Location = new Point(222, 471);
            btnCriarConta.Name = "btnCriarConta";
            btnCriarConta.Size = new Size(148, 55);
            btnCriarConta.TabIndex = 4;
            btnCriarConta.Text = "Criar";
            btnCriarConta.UseVisualStyleBackColor = false;
            btnCriarConta.Click += btnCriarConta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(190, 110);
            label1.Name = "label1";
            label1.Size = new Size(235, 40);
            label1.TabIndex = 3;
            label1.Text = "Crie a sua conta";
            // 
            // emailUser
            // 
            emailUser.BorderStyle = BorderStyle.None;
            emailUser.Font = new Font("Segoe UI", 15.75F);
            emailUser.Location = new Point(129, 315);
            emailUser.Margin = new Padding(5);
            emailUser.Multiline = true;
            emailUser.Name = "emailUser";
            emailUser.PlaceholderText = " ";
            emailUser.Size = new Size(347, 37);
            emailUser.TabIndex = 2;
            emailUser.UseSystemPasswordChar = true;
            emailUser.TextChanged += emailUser_TextChanged;
            // 
            // senhaUser
            // 
            senhaUser.BorderStyle = BorderStyle.None;
            senhaUser.Font = new Font("Segoe UI", 15.75F);
            senhaUser.Location = new Point(129, 403);
            senhaUser.Margin = new Padding(5);
            senhaUser.Multiline = true;
            senhaUser.Name = "senhaUser";
            senhaUser.PlaceholderText = " ";
            senhaUser.Size = new Size(347, 37);
            senhaUser.TabIndex = 1;
            senhaUser.UseSystemPasswordChar = true;
            senhaUser.TextChanged += senhaUser_TextChanged;
            // 
            // nomeUser
            // 
            nomeUser.BorderStyle = BorderStyle.None;
            nomeUser.Font = new Font("Segoe UI", 15.75F);
            nomeUser.Location = new Point(129, 229);
            nomeUser.Margin = new Padding(5);
            nomeUser.Multiline = true;
            nomeUser.Name = "nomeUser";
            nomeUser.PlaceholderText = " ";
            nomeUser.Size = new Size(347, 37);
            nomeUser.TabIndex = 0;
            nomeUser.UseSystemPasswordChar = true;
            nomeUser.TextChanged += nomeUser_TextChanged;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Navy;
            btnVoltar.FlatStyle = FlatStyle.Popup;
            btnVoltar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(54, 473);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(148, 55);
            btnVoltar.TabIndex = 1;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FormCadUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 612);
            Controls.Add(btnVoltar);
            Controls.Add(panel1);
            Name = "FormCadUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox emailUser;
        private TextBox senhaUser;
        private TextBox nomeUser;
        private Button btnCriarConta;
        private Label label2;
        private Label label4;
        private Label label3;
        private LinkLabel linkLabel1;
        private Button btnVoltar;
    }
}