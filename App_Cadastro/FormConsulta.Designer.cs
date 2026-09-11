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
            panel1 = new Panel();
            flpProdutos = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 741);
            panel1.TabIndex = 0;
            // 
            // flpProdutos
            // 
            flpProdutos.AutoScroll = true;
            flpProdutos.Dock = DockStyle.Fill;
            flpProdutos.FlowDirection = FlowDirection.TopDown;
            flpProdutos.Location = new Point(335, 0);
            flpProdutos.Name = "flpProdutos";
            flpProdutos.Size = new Size(814, 741);
            flpProdutos.TabIndex = 1;
            // 
            // FormConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 741);
            Controls.Add(flpProdutos);
            Controls.Add(panel1);
            Name = "FormConsulta";
            Text = "FormConsulta";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flpProdutos;
    }
}