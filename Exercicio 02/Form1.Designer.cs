namespace Exercicio_02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSegundoNumero = new Label();
            lblPrimeiroNumero = new Label();
            lblSegundo = new Label();
            lblPrimeiro = new Label();
            button1 = new Button();
            txtNumero = new TextBox();
            label1 = new Label();
            lblTerceiroNumero = new Label();
            lblTerceiro = new Label();
            SuspendLayout();
            // 
            // lblSegundoNumero
            // 
            lblSegundoNumero.AutoSize = true;
            lblSegundoNumero.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblSegundoNumero.Location = new Point(140, 227);
            lblSegundoNumero.Name = "lblSegundoNumero";
            lblSegundoNumero.Size = new Size(28, 32);
            lblSegundoNumero.TabIndex = 13;
            lblSegundoNumero.Text = "0";
            lblSegundoNumero.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPrimeiroNumero
            // 
            lblPrimeiroNumero.AutoSize = true;
            lblPrimeiroNumero.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrimeiroNumero.Location = new Point(140, 261);
            lblPrimeiroNumero.Name = "lblPrimeiroNumero";
            lblPrimeiroNumero.Size = new Size(28, 32);
            lblPrimeiroNumero.TabIndex = 12;
            lblPrimeiroNumero.Text = "0";
            lblPrimeiroNumero.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSegundo
            // 
            lblSegundo.AutoSize = true;
            lblSegundo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSegundo.Location = new Point(46, 239);
            lblSegundo.Name = "lblSegundo";
            lblSegundo.Size = new Size(56, 15);
            lblSegundo.TabIndex = 11;
            lblSegundo.Text = "Número:";
            // 
            // lblPrimeiro
            // 
            lblPrimeiro.AutoSize = true;
            lblPrimeiro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrimeiro.Location = new Point(46, 209);
            lblPrimeiro.Name = "lblPrimeiro";
            lblPrimeiro.Size = new Size(56, 15);
            lblPrimeiro.TabIndex = 10;
            lblPrimeiro.Text = "Número:";
            // 
            // button1
            // 
            button1.Location = new Point(125, 102);
            button1.Name = "button1";
            button1.Size = new Size(100, 47);
            button1.TabIndex = 9;
            button1.Text = "Go!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(125, 53);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 35);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 7;
            label1.Text = "Informe o número";
            // 
            // lblTerceiroNumero
            // 
            lblTerceiroNumero.AutoSize = true;
            lblTerceiroNumero.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTerceiroNumero.Location = new Point(140, 195);
            lblTerceiroNumero.Name = "lblTerceiroNumero";
            lblTerceiroNumero.Size = new Size(28, 32);
            lblTerceiroNumero.TabIndex = 15;
            lblTerceiroNumero.Text = "0";
            lblTerceiroNumero.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTerceiro
            // 
            lblTerceiro.AutoSize = true;
            lblTerceiro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTerceiro.Location = new Point(46, 269);
            lblTerceiro.Name = "lblTerceiro";
            lblTerceiro.Size = new Size(56, 15);
            lblTerceiro.TabIndex = 14;
            lblTerceiro.Text = "Número:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 450);
            Controls.Add(lblTerceiroNumero);
            Controls.Add(lblTerceiro);
            Controls.Add(lblSegundoNumero);
            Controls.Add(lblPrimeiroNumero);
            Controls.Add(lblSegundo);
            Controls.Add(lblPrimeiro);
            Controls.Add(button1);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSegundoNumero;
        private Label lblPrimeiroNumero;
        private Label lblSegundo;
        private Label lblPrimeiro;
        private Button button1;
        private TextBox txtNumero;
        private Label label1;
        private Label lblTerceiroNumero;
        private Label lblTerceiro;
    }
}