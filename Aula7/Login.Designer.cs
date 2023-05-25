namespace Aula7
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
            btn_Login = new Button();
            SuspendLayout();
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(62, 116);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(114, 27);
            btn_Login.TabIndex = 0;
            btn_Login.Text = "ENTRAR";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(232, 272);
            Controls.Add(btn_Login);
            Name = "frm_Login";
            Text = "Login";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Login;
    }
}