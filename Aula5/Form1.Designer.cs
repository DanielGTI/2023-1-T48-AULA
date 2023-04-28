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
            txt_escolha5 = new TextBox();
            txt_escolha3 = new TextBox();
            txt_escolha4 = new TextBox();
            txt_escolha2 = new TextBox();
            txt_escolha1 = new TextBox();
            label2 = new Label();
            lbl_record = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txt_Sorteado_1
            // 
            txt_Sorteado_1.Location = new Point(30, 33);
            txt_Sorteado_1.Name = "txt_Sorteado_1";
            txt_Sorteado_1.ReadOnly = true;
            txt_Sorteado_1.RightToLeft = RightToLeft.No;
            txt_Sorteado_1.Size = new Size(45, 23);
            txt_Sorteado_1.TabIndex = 0;
            txt_Sorteado_1.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_Sorteio
            // 
            btn_Sorteio.Enabled = false;
            btn_Sorteio.Location = new Point(30, 62);
            btn_Sorteio.Name = "btn_Sorteio";
            btn_Sorteio.Size = new Size(249, 23);
            btn_Sorteio.TabIndex = 1;
            btn_Sorteio.Text = "GERAR SORTEIO";
            btn_Sorteio.UseVisualStyleBackColor = true;
            btn_Sorteio.Click += btn_Sorteio_Click;
            // 
            // txt_Sorteado_2
            // 
            txt_Sorteado_2.Location = new Point(81, 33);
            txt_Sorteado_2.Name = "txt_Sorteado_2";
            txt_Sorteado_2.ReadOnly = true;
            txt_Sorteado_2.RightToLeft = RightToLeft.No;
            txt_Sorteado_2.Size = new Size(45, 23);
            txt_Sorteado_2.TabIndex = 2;
            txt_Sorteado_2.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_Sorteado_4
            // 
            txt_Sorteado_4.Location = new Point(183, 33);
            txt_Sorteado_4.Name = "txt_Sorteado_4";
            txt_Sorteado_4.ReadOnly = true;
            txt_Sorteado_4.RightToLeft = RightToLeft.No;
            txt_Sorteado_4.Size = new Size(45, 23);
            txt_Sorteado_4.TabIndex = 3;
            txt_Sorteado_4.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_Sorteado_3
            // 
            txt_Sorteado_3.Location = new Point(132, 33);
            txt_Sorteado_3.Name = "txt_Sorteado_3";
            txt_Sorteado_3.ReadOnly = true;
            txt_Sorteado_3.RightToLeft = RightToLeft.No;
            txt_Sorteado_3.Size = new Size(45, 23);
            txt_Sorteado_3.TabIndex = 3;
            txt_Sorteado_3.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_Sorteado_5
            // 
            txt_Sorteado_5.Location = new Point(234, 33);
            txt_Sorteado_5.Name = "txt_Sorteado_5";
            txt_Sorteado_5.ReadOnly = true;
            txt_Sorteado_5.RightToLeft = RightToLeft.No;
            txt_Sorteado_5.Size = new Size(45, 23);
            txt_Sorteado_5.TabIndex = 4;
            txt_Sorteado_5.TextAlign = HorizontalAlignment.Center;
            // 
            // lis_Numeros
            // 
            lis_Numeros.FormattingEnabled = true;
            lis_Numeros.ItemHeight = 15;
            lis_Numeros.Location = new Point(30, 91);
            lis_Numeros.Name = "lis_Numeros";
            lis_Numeros.Size = new Size(249, 244);
            lis_Numeros.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 6;
            label1.Text = "Sorteio:";
            // 
            // lbl_nSorteio
            // 
            lbl_nSorteio.AutoSize = true;
            lbl_nSorteio.Location = new Point(81, 9);
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
            // txt_escolha5
            // 
            txt_escolha5.Location = new Point(234, 400);
            txt_escolha5.Name = "txt_escolha5";
            txt_escolha5.RightToLeft = RightToLeft.No;
            txt_escolha5.Size = new Size(45, 23);
            txt_escolha5.TabIndex = 14;
            txt_escolha5.TextAlign = HorizontalAlignment.Center;
            txt_escolha5.TextChanged += txt_escolha5_TextChanged;
            // 
            // txt_escolha3
            // 
            txt_escolha3.Location = new Point(132, 400);
            txt_escolha3.Name = "txt_escolha3";
            txt_escolha3.RightToLeft = RightToLeft.No;
            txt_escolha3.Size = new Size(45, 23);
            txt_escolha3.TabIndex = 12;
            txt_escolha3.TextAlign = HorizontalAlignment.Center;
            txt_escolha3.TextChanged += txt_escolha3_TextChanged;
            // 
            // txt_escolha4
            // 
            txt_escolha4.Location = new Point(183, 400);
            txt_escolha4.Name = "txt_escolha4";
            txt_escolha4.RightToLeft = RightToLeft.No;
            txt_escolha4.Size = new Size(45, 23);
            txt_escolha4.TabIndex = 13;
            txt_escolha4.TextAlign = HorizontalAlignment.Center;
            txt_escolha4.TextChanged += txt_escolha4_TextChanged;
            // 
            // txt_escolha2
            // 
            txt_escolha2.Location = new Point(81, 400);
            txt_escolha2.Name = "txt_escolha2";
            txt_escolha2.RightToLeft = RightToLeft.No;
            txt_escolha2.Size = new Size(45, 23);
            txt_escolha2.TabIndex = 11;
            txt_escolha2.TextAlign = HorizontalAlignment.Center;
            txt_escolha2.TextChanged += txt_escolha2_TextChanged;
            // 
            // txt_escolha1
            // 
            txt_escolha1.Location = new Point(30, 400);
            txt_escolha1.Name = "txt_escolha1";
            txt_escolha1.RightToLeft = RightToLeft.No;
            txt_escolha1.Size = new Size(45, 23);
            txt_escolha1.TabIndex = 10;
            txt_escolha1.TextAlign = HorizontalAlignment.Center;
            txt_escolha1.TextChanged += txt_escolha1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 367);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 15;
            label2.Text = "Escolha 5 numeros:";
            // 
            // lbl_record
            // 
            lbl_record.AutoSize = true;
            lbl_record.Location = new Point(31, 469);
            lbl_record.Name = "lbl_record";
            lbl_record.Size = new Size(0, 15);
            lbl_record.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 451);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 17;
            label4.Text = "Record:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 493);
            Controls.Add(label4);
            Controls.Add(lbl_record);
            Controls.Add(label2);
            Controls.Add(txt_escolha5);
            Controls.Add(txt_escolha3);
            Controls.Add(txt_escolha4);
            Controls.Add(txt_escolha2);
            Controls.Add(txt_escolha1);
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
            Shown += Form1_Shown;
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
        private TextBox txt_escolha5;
        private TextBox txt_escolha3;
        private TextBox txt_escolha4;
        private TextBox txt_escolha2;
        private TextBox txt_escolha1;
        private Label label2;
        private Label lbl_record;
        private Label label4;
    }
}