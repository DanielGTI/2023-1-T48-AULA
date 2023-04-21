namespace Aula5
{
    public partial class Form1 : Form
    {
        public class Dados
        {
            //  Matriz de valores
            public static int[,] valores =new int[61, 2];
        }
        
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_Sorteio_Click(object sender, EventArgs e)
        {
            int i, j, num, limite = 60;
            int[] sorteio = new int[5];

            list_TotalNumeros_1.Items.Clear();
            list_TotalNumeros_2.Items.Clear();


            Random aleatorio = new Random();

            for (i = 0; i < 5; i++)
            {
                num = aleatorio.Next(limite) + 1;
                sorteio[i] = num;
                // CONTAR QUANTIDADE
                Dados.valores[num, 0] += 1;

                if (i > 0)
                    for (j = 0; j < i; j++)
                    {
                        if (sorteio[j] == sorteio[i])
                        {
                            Dados.valores[sorteio[i], 0] -= 1; 
                            num = aleatorio.Next(limite) + 1;
                            sorteio[i] = num;
                            j = -1;
                            // CONTAR QUANTIDADE
                            Dados.valores[num, 0] += 1;
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


            int numero_sorteio;

            numero_sorteio = Convert.ToInt32(lbl_nSorteio.Text) + 1;
            lbl_nSorteio.Text = numero_sorteio.ToString();

            String linha_sorteio = "";
            linha_sorteio += "Sorteio (";
            linha_sorteio += numero_sorteio.ToString("00") + "):  ";
            for (i = 0; i < 5; i++)
            {
                linha_sorteio += sorteio[i].ToString("00");
                if (i < 4)
                    linha_sorteio += " - ";
            }
            lis_Numeros.Items.Add(linha_sorteio);

            string num_1;

            for (i = 1; i <= 60; i++)
            {
                num_1 = i.ToString("00");
                num_1 += ": ";
                num_1 += Dados.valores[i, 0].ToString();

                if( i <= 30 )
                    list_TotalNumeros_1.Items.Add(num_1);
                else
                    list_TotalNumeros_2.Items.Add(num_1);

            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i;

            for (i = 1; i <= 60; i++)
            {
                Dados.valores[i, 0] = 0;
            }
        }
    }
}