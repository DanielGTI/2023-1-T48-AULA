namespace Aula5
{
    public partial class Form1 : Form
    {
        public class Dados
        {
            //  Matriz de valores
            public static int[,] valores = new int[61, 2];
            public static int max_sorteio = 0, rodada = 0;
            public static int[] escolha_sorteio = new int[5];

        }

        public Form1()
        {
            InitializeComponent();

        }

        private void btn_Sorteio_Click(object sender, EventArgs e)
        {
            int i, j, num, limite = 60;
            int[] sorteio = new int[5];
            int max_sorteio_rodada = 0;

            txt_escolha1.ReadOnly = true;
            txt_escolha2.ReadOnly = true;
            txt_escolha3.ReadOnly = true;
            txt_escolha4.ReadOnly = true;
            txt_escolha5.ReadOnly = true;

            if (Dados.escolha_sorteio[4] == 0)
            {
                Dados.escolha_sorteio[0] = Convert.ToInt32(txt_escolha1.Text);
                Dados.escolha_sorteio[1] = Convert.ToInt32(txt_escolha2.Text);
                Dados.escolha_sorteio[2] = Convert.ToInt32(txt_escolha3.Text);
                Dados.escolha_sorteio[3] = Convert.ToInt32(txt_escolha4.Text);
                Dados.escolha_sorteio[4] = Convert.ToInt32(txt_escolha5.Text);
            }

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

            //  COMPARAR COM O VALORES DO USUARIO

            // Sistema:   4 - 12 - 14 - 21 - 42 
            // usuario:   1 - 2 - 3 - 4 - 12 
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (Dados.escolha_sorteio[i] == sorteio[j])
                    {
                        max_sorteio_rodada++;
                    }
                }
            }

            //  EXIBIR DOS VALORES SORTEADOS.
            txt_Sorteado_1.Text = sorteio[0].ToString();
            txt_Sorteado_2.Text = sorteio[1].ToString();
            txt_Sorteado_3.Text = sorteio[2].ToString();
            txt_Sorteado_4.Text = sorteio[3].ToString();
            txt_Sorteado_5.Text = sorteio[4].ToString();


            int numero_sorteio;

            numero_sorteio = Convert.ToInt32(lbl_nSorteio.Text) + 1;
            lbl_nSorteio.Text = numero_sorteio.ToString();

            //  EXIBIR O RECORD DE ACERTOS.
            if (max_sorteio_rodada >= Dados.max_sorteio)
            {
                Dados.max_sorteio = max_sorteio_rodada;
                Dados.rodada = numero_sorteio;
                lbl_record.Text = "Sorteio (" + numero_sorteio.ToString() + "), acertou "
                + Dados.max_sorteio.ToString() + " números.";

            }

            //  EXIBIR NA LISTA DE SORTEIO
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

            //  QUANTIDADE POR NUMEROS
            for (i = 1; i <= 60; i++)
            {
                num_1 = i.ToString("00");
                num_1 += ": ";
                num_1 += Dados.valores[i, 0].ToString();

                if (i <= 30)
                    list_TotalNumeros_1.Items.Add(num_1);
                else
                    list_TotalNumeros_2.Items.Add(num_1);

            }




            //  ZERAR VALORES
            max_sorteio_rodada = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i;

            for (i = 1; i <= 60; i++)
            {
                Dados.valores[i, 0] = 0;
            }


        }

        public void exibirBotao()
        {
            if (txt_escolha1.Text != "" &&
                txt_escolha2.Text != "" &&
                txt_escolha3.Text != "" &&
                txt_escolha4.Text != "" &&
                txt_escolha5.Text != "")
            {
                btn_Sorteio.Enabled = true;
            }
        }

        private void txt_escolha1_TextChanged(object sender, EventArgs e)
        {
            exibirBotao();
        }

        private void txt_escolha2_TextChanged(object sender, EventArgs e)
        {
            exibirBotao();
        }

        private void txt_escolha3_TextChanged(object sender, EventArgs e)
        {
            exibirBotao();
        }

        private void txt_escolha4_TextChanged(object sender, EventArgs e)
        {
            exibirBotao();
        }

        private void txt_escolha5_TextChanged(object sender, EventArgs e)
        {
            exibirBotao();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            txt_escolha1.Focus();
        }
    }
}