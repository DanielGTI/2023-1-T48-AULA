namespace Aula6
{
    partial class frm_Login
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
            txt_usuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_Senha = new TextBox();
            btn_Login = new Button();
            SuspendLayout();
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(90, 89);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(100, 23);
            txt_usuario.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 71);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 144);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // txt_Senha
            // 
            txt_Senha.Location = new Point(90, 162);
            txt_Senha.Name = "txt_Senha";
            txt_Senha.Size = new Size(100, 23);
            txt_Senha.TabIndex = 3;
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(90, 233);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(100, 23);
            btn_Login.TabIndex = 4;
            btn_Login.Text = "button1";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 355);
            Controls.Add(btn_Login);
            Controls.Add(txt_Senha);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_usuario);
            Name = "frm_Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_usuario;
        private Label label1;
        private Label label2;
        private TextBox txt_Senha;
        private Button btn_Login;
    }
}