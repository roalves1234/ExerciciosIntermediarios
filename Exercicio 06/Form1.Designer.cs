﻿namespace Exercicio_06
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
            button1 = new Button();
            edtValorVeiculo = new TextBox();
            label1 = new Label();
            memo = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(11, 55);
            button1.Name = "button1";
            button1.Size = new Size(100, 38);
            button1.TabIndex = 10;
            button1.Text = "Go!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // edtValorVeiculo
            // 
            edtValorVeiculo.Location = new Point(11, 26);
            edtValorVeiculo.Name = "edtValorVeiculo";
            edtValorVeiculo.Size = new Size(100, 23);
            edtValorVeiculo.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 8);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 6;
            label1.Text = "Valor do veículo";
            // 
            // memo
            // 
            memo.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            memo.Location = new Point(11, 110);
            memo.Name = "memo";
            memo.Size = new Size(862, 380);
            memo.TabIndex = 11;
            memo.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 502);
            Controls.Add(memo);
            Controls.Add(button1);
            Controls.Add(edtValorVeiculo);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox memResultado;
        private Button button1;
        private TextBox txtHoras;
        private Label label2;
        private TextBox edtValorVeiculo;
        private Label label1;
        private RichTextBox memo;
    }
}