namespace App_Cadastro
{
    partial class FormConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsulta));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            voltarBtn = new Button();
            flpProdutos = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(voltarBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 740);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 72);
            label1.Name = "label1";
            label1.Size = new Size(304, 37);
            label1.TabIndex = 1;
            label1.Text = "Produtos cadastrados ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 151);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 271);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // voltarBtn
            // 
            voltarBtn.BackColor = Color.White;
            voltarBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            voltarBtn.ForeColor = Color.FromArgb(0, 0, 64);
            voltarBtn.Location = new Point(93, 570);
            voltarBtn.Name = "voltarBtn";
            voltarBtn.Size = new Size(151, 61);
            voltarBtn.TabIndex = 0;
            voltarBtn.Text = "Voltar";
            voltarBtn.UseVisualStyleBackColor = false;
            voltarBtn.Click += button1_Click;
            // 
            // flpProdutos
            // 
            flpProdutos.AutoScroll = true;
            flpProdutos.Dock = DockStyle.Fill;
            flpProdutos.FlowDirection = FlowDirection.TopDown;
            flpProdutos.Location = new Point(359, 0);
            flpProdutos.Name = "flpProdutos";
            flpProdutos.Size = new Size(718, 740);
            flpProdutos.TabIndex = 1;
            flpProdutos.WrapContents = false;
            flpProdutos.Paint += flpProdutos_Paint;
            // 
            // FormConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 740);
            Controls.Add(flpProdutos);
            Controls.Add(panel1);
            Name = "FormConsulta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormConsulta";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flpProdutos;
        private Button voltarBtn;
        private Label label1;
        private PictureBox pictureBox1;
    }
}