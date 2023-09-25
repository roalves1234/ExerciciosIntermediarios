namespace Exercicio_03
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
            label1 = new Label();
            txtValorHora = new TextBox();
            txtHoras = new TextBox();
            label2 = new Label();
            button1 = new Button();
            memResultado = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor da hora";
            // 
            // txtValorHora
            // 
            txtValorHora.Location = new Point(12, 36);
            txtValorHora.Name = "txtValorHora";
            txtValorHora.Size = new Size(100, 23);
            txtValorHora.TabIndex = 1;
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(12, 101);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(100, 23);
            txtHoras.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 2;
            label2.Text = "Horas trabalhadas";
            // 
            // button1
            // 
            button1.Location = new Point(14, 146);
            button1.Name = "button1";
            button1.Size = new Size(98, 38);
            button1.TabIndex = 4;
            button1.Text = "Go!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // memResultado
            // 
            memResultado.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            memResultado.Location = new Point(201, 22);
            memResultado.Name = "memResultado";
            memResultado.Size = new Size(548, 162);
            memResultado.TabIndex = 5;
            memResultado.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(memResultado);
            Controls.Add(button1);
            Controls.Add(txtHoras);
            Controls.Add(label2);
            Controls.Add(txtValorHora);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtValorHora;
        private TextBox txtHoras;
        private Label label2;
        private Button button1;
        private RichTextBox memResultado;
    }
}