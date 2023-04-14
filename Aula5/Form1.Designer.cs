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
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // txt_Sorteado_1
            // 
            txt_Sorteado_1.Location = new Point(121, 32);
            txt_Sorteado_1.Name = "txt_Sorteado_1";
            txt_Sorteado_1.RightToLeft = RightToLeft.No;
            txt_Sorteado_1.Size = new Size(45, 23);
            txt_Sorteado_1.TabIndex = 0;
            txt_Sorteado_1.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_Sorteio
            // 
            btn_Sorteio.Location = new Point(121, 76);
            btn_Sorteio.Name = "btn_Sorteio";
            btn_Sorteio.Size = new Size(249, 23);
            btn_Sorteio.TabIndex = 1;
            btn_Sorteio.Text = "GERAR SORTEIO";
            btn_Sorteio.UseVisualStyleBackColor = true;
            btn_Sorteio.Click += btn_Sorteio_Click;
            // 
            // txt_Sorteado_2
            // 
            txt_Sorteado_2.Location = new Point(172, 32);
            txt_Sorteado_2.Name = "txt_Sorteado_2";
            txt_Sorteado_2.RightToLeft = RightToLeft.No;
            txt_Sorteado_2.Size = new Size(45, 23);
            txt_Sorteado_2.TabIndex = 2;
            txt_Sorteado_2.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_Sorteado_4
            // 
            txt_Sorteado_4.Location = new Point(274, 32);
            txt_Sorteado_4.Name = "txt_Sorteado_4";
            txt_Sorteado_4.RightToLeft = RightToLeft.No;
            txt_Sorteado_4.Size = new Size(45, 23);
            txt_Sorteado_4.TabIndex = 3;
            txt_Sorteado_4.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_Sorteado_3
            // 
            txt_Sorteado_3.Location = new Point(223, 32);
            txt_Sorteado_3.Name = "txt_Sorteado_3";
            txt_Sorteado_3.RightToLeft = RightToLeft.No;
            txt_Sorteado_3.Size = new Size(45, 23);
            txt_Sorteado_3.TabIndex = 3;
            txt_Sorteado_3.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_Sorteado_5
            // 
            txt_Sorteado_5.Location = new Point(325, 32);
            txt_Sorteado_5.Name = "txt_Sorteado_5";
            txt_Sorteado_5.RightToLeft = RightToLeft.No;
            txt_Sorteado_5.Size = new Size(45, 23);
            txt_Sorteado_5.TabIndex = 4;
            txt_Sorteado_5.TextAlign = HorizontalAlignment.Center;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(121, 119);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(249, 124);
            listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 370);
            Controls.Add(listBox1);
            Controls.Add(txt_Sorteado_5);
            Controls.Add(txt_Sorteado_3);
            Controls.Add(txt_Sorteado_4);
            Controls.Add(txt_Sorteado_2);
            Controls.Add(btn_Sorteio);
            Controls.Add(txt_Sorteado_1);
            Name = "Form1";
            Text = "Sorteios";
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
        private ListBox listBox1;
    }
}