namespace Aula_2
{
    partial class frmContato
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
            lblNome = new Label();
            txtNome = new TextBox();
            btnMensagem = new Button();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(21, 101);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(70, 93);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(165, 23);
            txtNome.TabIndex = 1;
            // 
            // btnMensagem
            // 
            btnMensagem.Location = new Point(70, 156);
            btnMensagem.Name = "btnMensagem";
            btnMensagem.Size = new Size(166, 23);
            btnMensagem.TabIndex = 2;
            btnMensagem.Text = "Mensagem";
            btnMensagem.UseVisualStyleBackColor = true;
            btnMensagem.Click += btnMensagem_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(21, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(259, 45);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Nome do Aluno";
            // 
            // frmContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 219);
            Controls.Add(lblTitulo);
            Controls.Add(btnMensagem);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "frmContato";
            Text = "Formulário de Contato";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Button btnMensagem;
        private Label lblTitulo;
    }
}