﻿namespace Aula6
{
    partial class frm_Sistema
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
            lbl_Usuario = new Label();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbl_Usuario
            // 
            lbl_Usuario.AutoSize = true;
            lbl_Usuario.Location = new Point(85, 9);
            lbl_Usuario.Name = "lbl_Usuario";
            lbl_Usuario.Size = new Size(53, 15);
            lbl_Usuario.TabIndex = 0;
            lbl_Usuario.Text = "SISTEMA";
            // 
            // button1
            // 
            button1.Location = new Point(12, 138);
            button1.Name = "button1";
            button1.Size = new Size(207, 23);
            button1.TabIndex = 1;
            button1.Text = "Abrir Tela 2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 2;
            label1.Text = "Bem vindo:";
            label1.Click += label1_Click;
            // 
            // frm_Sistema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(231, 310);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(lbl_Usuario);
            Name = "frm_Sistema";
            Text = "Sistema";
            Load += frm_Sistema_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Usuario;
        private Button button1;
        private Label label1;
    }
}