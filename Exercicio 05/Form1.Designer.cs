namespace Exercicio_05
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
            memo = new RichTextBox();
            panel1 = new Panel();
            button1 = new Button();
            edtTamanho = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // memo
            // 
            memo.Dock = DockStyle.Bottom;
            memo.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            memo.Location = new Point(0, 71);
            memo.Name = "memo";
            memo.Size = new Size(996, 675);
            memo.TabIndex = 0;
            memo.Text = "";
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(edtTamanho);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(996, 71);
            panel1.TabIndex = 0;
            panel1.TabStop = true;
            // 
            // button1
            // 
            button1.Location = new Point(133, 32);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Go!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // edtTamanho
            // 
            edtTamanho.Location = new Point(15, 32);
            edtTamanho.Name = "edtTamanho";
            edtTamanho.Size = new Size(100, 23);
            edtTamanho.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Tamanho:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 746);
            Controls.Add(panel1);
            Controls.Add(memo);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox memo;
        private Panel panel1;
        private TextBox edtTamanho;
        private Label label1;
        private Button button1;
    }
}