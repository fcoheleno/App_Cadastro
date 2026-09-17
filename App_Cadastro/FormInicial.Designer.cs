namespace App_Cadastro
{
    partial class FormInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicial));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnIniciar = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 720);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(69, 477);
            label1.Name = "label1";
            label1.Size = new Size(186, 37);
            label1.TabIndex = 1;
            label1.Text = "GeniusCad";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(50, 196);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnIniciar);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(353, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(643, 720);
            panel2.TabIndex = 1;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(0, 0, 64);
            btnIniciar.FlatStyle = FlatStyle.Popup;
            btnIniciar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(270, 489);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(144, 61);
            btnIniciar.TabIndex = 3;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(161, 163);
            label2.Name = "label2";
            label2.Size = new Size(371, 280);
            label2.TabIndex = 2;
            label2.Text = "Seja bem vindo \r\nao nosso sistema de \r\ngerenciamento!\r\n\r\nAcompanhe todas os\r\nprocessos internos de sua\r\nloja";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 720);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnIniciar;
        private Label label2;
    }
}