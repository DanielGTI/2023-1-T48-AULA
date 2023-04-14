namespace Aula5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Sorteio_Click(object sender, EventArgs e)
        {
            int i, j, num, limite = 60;
            int[] sorteio = new int[5];

            Random aleatorio = new Random();

            for (i = 0; i < 5; i++)
            {
                num = aleatorio.Next(limite) + 1;
                sorteio[i] = num;

                if (i > 0)
                    for (j = 0; j < i; j++)
                    {
                        if (sorteio[j] == sorteio[i])
                        {
                            num = aleatorio.Next(limite) + 1;
                            sorteio[i] = num;
                            j = -1;
                        }
                    }
            }
            //  0   1   2   3   4
            //  5 - 4 - 6 - 7 - 4 
            //  i = 4

            Array.Sort(sorteio);

            txt_Sorteado_1.Text = sorteio[0].ToString();
            txt_Sorteado_2.Text = sorteio[1].ToString();
            txt_Sorteado_3.Text = sorteio[2].ToString();
            txt_Sorteado_4.Text = sorteio[3].ToString();
            txt_Sorteado_5.Text = sorteio[4].ToString();



        }
    }
}