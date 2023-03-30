namespace Aula_4
{
    partial class frm_Caixa
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
            btn_01 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn_01
            // 
            btn_01.BackColor = SystemColors.Control;
            btn_01.FlatAppearance.BorderSize = 0;
            btn_01.Location = new Point(77, 60);
            btn_01.Name = "btn_01";
            btn_01.Size = new Size(90, 28);
            btn_01.TabIndex = 0;
            btn_01.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.FlatAppearance.BorderSize = 0;
            button1.Location = new Point(77, 108);
            button1.Name = "button1";
            button1.Size = new Size(90, 28);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            // 
            // frm_Caixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Tela_Caixa_Banco;
            ClientSize = new Size(734, 561);
            Controls.Add(button1);
            Controls.Add(btn_01);
            Name = "frm_Caixa";
            Text = "Caixa";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_01;
        private Button button1;
    }
}