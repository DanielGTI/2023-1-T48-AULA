namespace Aula5
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
            txt_Sorteado_1 = new TextBox();
            btn_Sorteio = new Button();
            txt_Sorteado_2 = new TextBox();
            txt_Sorteado_4 = new TextBox();
            txt_Sorteado_3 = new TextBox();
            txt_Sorteado_5 = new TextBox();
            lis_Numeros = new ListBox();
            label1 = new Label();
            lbl_nSorteio = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            list_TotalNumeros_1 = new ListBox();
            list_TotalNumeros_2 = new ListBox();
            SuspendLayout();
            // 
            // txt_Sorteado_1
            // 
            txt_Sorteado_1.Location = new Point(28, 95);
            txt_Sorteado_1.Name = "txt_Sorteado_1";
            txt_Sorteado_1.RightToLeft = RightToLeft.No;
            txt_Sorteado_1.Size = new Size(45, 23);
            txt_Sorteado_1.TabIndex = 0;
            txt_Sorteado_1.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_Sorteio
            // 
            btn_Sorteio.Location = new Point(28, 174);
            btn_Sorteio.Name = "btn_Sorteio";
            btn_Sorteio.Size = new Size(249, 23);
            btn_Sorteio.TabIndex = 1;
            btn_Sorteio.Text = "GERAR SORTEIO";
            btn_Sorteio.UseVisualStyleBackColor = true;
            btn_Sorteio.Click += btn_Sorteio_Click;
            // 
            // txt_Sorteado_2
            // 
            txt_Sorteado_2.Location = new Point(79, 95);
            txt_Sorteado_2.Name = "txt_Sorteado_2";
            txt_Sorteado_2.RightToLeft = RightToLeft.No;
            txt_Sorteado_2.Size = new Size(45, 23);
            txt_Sorteado_2.TabIndex = 2;
            txt_Sorteado_2.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_Sorteado_4
            // 
            txt_Sorteado_4.Location = new Point(181, 95);
            txt_Sorteado_4.Name = "txt_Sorteado_4";
            txt_Sorteado_4.RightToLeft = RightToLeft.No;
            txt_Sorteado_4.Size = new Size(45, 23);
            txt_Sorteado_4.TabIndex = 3;
            txt_Sorteado_4.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_Sorteado_3
            // 
            txt_Sorteado_3.Location = new Point(130, 95);
            txt_Sorteado_3.Name = "txt_Sorteado_3";
            txt_Sorteado_3.RightToLeft = RightToLeft.No;
            txt_Sorteado_3.Size = new Size(45, 23);
            txt_Sorteado_3.TabIndex = 3;
            txt_Sorteado_3.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_Sorteado_5
            // 
            txt_Sorteado_5.Location = new Point(232, 95);
            txt_Sorteado_5.Name = "txt_Sorteado_5";
            txt_Sorteado_5.RightToLeft = RightToLeft.No;
            txt_Sorteado_5.Size = new Size(45, 23);
            txt_Sorteado_5.TabIndex = 4;
            txt_Sorteado_5.TextAlign = HorizontalAlignment.Center;
            // 
            // lis_Numeros
            // 
            lis_Numeros.FormattingEnabled = true;
            lis_Numeros.ItemHeight = 15;
            lis_Numeros.Location = new Point(28, 243);
            lis_Numeros.Name = "lis_Numeros";
            lis_Numeros.Size = new Size(249, 244);
            lis_Numeros.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 49);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 6;
            label1.Text = "Sorteio:";
            // 
            // lbl_nSorteio
            // 
            lbl_nSorteio.AutoSize = true;
            lbl_nSorteio.Location = new Point(81, 49);
            lbl_nSorteio.Name = "lbl_nSorteio";
            lbl_nSorteio.Size = new Size(13, 15);
            lbl_nSorteio.TabIndex = 7;
            lbl_nSorteio.Text = "0";
            // 
            // list_TotalNumeros_1
            // 
            list_TotalNumeros_1.FormattingEnabled = true;
            list_TotalNumeros_1.ItemHeight = 15;
            list_TotalNumeros_1.Location = new Point(321, 33);
            list_TotalNumeros_1.Name = "list_TotalNumeros_1";
            list_TotalNumeros_1.Size = new Size(111, 454);
            list_TotalNumeros_1.TabIndex = 8;
            // 
            // list_TotalNumeros_2
            // 
            list_TotalNumeros_2.FormattingEnabled = true;
            list_TotalNumeros_2.ItemHeight = 15;
            list_TotalNumeros_2.Location = new Point(451, 33);
            list_TotalNumeros_2.Name = "list_TotalNumeros_2";
            list_TotalNumeros_2.Size = new Size(111, 454);
            list_TotalNumeros_2.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 493);
            Controls.Add(list_TotalNumeros_2);
            Controls.Add(list_TotalNumeros_1);
            Controls.Add(lbl_nSorteio);
            Controls.Add(label1);
            Controls.Add(lis_Numeros);
            Controls.Add(txt_Sorteado_5);
            Controls.Add(txt_Sorteado_3);
            Controls.Add(txt_Sorteado_4);
            Controls.Add(txt_Sorteado_2);
            Controls.Add(btn_Sorteio);
            Controls.Add(txt_Sorteado_1);
            Name = "Form1";
            Text = "Sorteios";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Sorteado_1;
        private Button btn_Sorteio;
        private TextBox txt_Sorteado_2;
        private TextBox txt_Sorteado_4;
        private TextBox txt_Sorteado_3;
        private TextBox txt_Sorteado_5;
        private ListBox lis_Numeros;
        private Label label1;
        private Label lbl_nSorteio;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListBox list_TotalNumeros_1;
        private ListBox list_TotalNumeros_2;
    }
}