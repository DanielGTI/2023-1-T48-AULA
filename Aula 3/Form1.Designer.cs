namespace Aula_3
{
    partial class frmSomar
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
            lbl_AV1 = new Label();
            lbl_AV2 = new Label();
            txtAV1 = new TextBox();
            txtAV2 = new TextBox();
            txtResultado = new TextBox();
            lbl_Resultado = new Label();
            btnInteiros = new Button();
            btnReais = new Button();
            button1 = new Button();
            button2 = new Button();
            lbl_Status = new Label();
            SuspendLayout();
            // 
            // lbl_AV1
            // 
            lbl_AV1.AutoSize = true;
            lbl_AV1.Location = new Point(47, 32);
            lbl_AV1.Name = "lbl_AV1";
            lbl_AV1.Size = new Size(27, 15);
            lbl_AV1.TabIndex = 0;
            lbl_AV1.Text = "AV1";
            // 
            // lbl_AV2
            // 
            lbl_AV2.AutoSize = true;
            lbl_AV2.Location = new Point(47, 91);
            lbl_AV2.Name = "lbl_AV2";
            lbl_AV2.Size = new Size(27, 15);
            lbl_AV2.TabIndex = 1;
            lbl_AV2.Text = "AV2";
            // 
            // txtAV1
            // 
            txtAV1.Location = new Point(95, 24);
            txtAV1.Name = "txtAV1";
            txtAV1.Size = new Size(100, 23);
            txtAV1.TabIndex = 2;
            // 
            // txtAV2
            // 
            txtAV2.Location = new Point(95, 83);
            txtAV2.Name = "txtAV2";
            txtAV2.Size = new Size(100, 23);
            txtAV2.TabIndex = 3;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(95, 148);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 4;
            // 
            // lbl_Resultado
            // 
            lbl_Resultado.AutoSize = true;
            lbl_Resultado.Location = new Point(30, 156);
            lbl_Resultado.Name = "lbl_Resultado";
            lbl_Resultado.Size = new Size(59, 15);
            lbl_Resultado.TabIndex = 5;
            lbl_Resultado.Text = "Resultado";
            // 
            // btnInteiros
            // 
            btnInteiros.Location = new Point(235, 24);
            btnInteiros.Name = "btnInteiros";
            btnInteiros.Size = new Size(75, 23);
            btnInteiros.TabIndex = 6;
            btnInteiros.Text = "INTEIROS";
            btnInteiros.UseVisualStyleBackColor = true;
            btnInteiros.Click += btnInteiros_Click;
            // 
            // btnReais
            // 
            btnReais.Location = new Point(235, 83);
            btnReais.Name = "btnReais";
            btnReais.Size = new Size(75, 23);
            btnReais.TabIndex = 7;
            btnReais.Text = "REAIS";
            btnReais.UseVisualStyleBackColor = true;
            btnReais.Click += btnReais_Click;
            // 
            // button1
            // 
            button1.Location = new Point(235, 148);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Média";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(235, 209);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Aprovação";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lbl_Status
            // 
            lbl_Status.AutoSize = true;
            lbl_Status.Location = new Point(95, 213);
            lbl_Status.Name = "lbl_Status";
            lbl_Status.Size = new Size(0, 15);
            lbl_Status.TabIndex = 10;
            // 
            // frmSomar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 287);
            Controls.Add(lbl_Status);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnReais);
            Controls.Add(btnInteiros);
            Controls.Add(lbl_Resultado);
            Controls.Add(txtResultado);
            Controls.Add(txtAV2);
            Controls.Add(txtAV1);
            Controls.Add(lbl_AV2);
            Controls.Add(lbl_AV1);
            Name = "frmSomar";
            Text = "Somar Notas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_AV1;
        private Label lbl_AV2;
        private TextBox txtAV1;
        private TextBox txtAV2;
        private TextBox txtResultado;
        private Label lbl_Resultado;
        private Button btnInteiros;
        private Button btnReais;
        private Button button1;
        private Button button2;
        private Label lbl_Status;
    }
}