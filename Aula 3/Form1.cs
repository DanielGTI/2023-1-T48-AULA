namespace Aula_3
{
    public partial class frmSomar : Form
    {
        public frmSomar()
        {
            InitializeComponent();
        }

        private void btnInteiros_Click(object sender, EventArgs e)
        {
            double a, b;
            int av1, av2, soma;

            //  CAPTURAR OS VALORES
            a = Convert.ToDouble(txtAV1.Text);
            b = Convert.ToDouble(txtAV2.Text);

            av1 = (int)a;
            av2 = (int)b;


            //  CALCULAR A SOMA
            soma = av1 + av2;

            //  EXIBIR O RESULTADO
            txtResultado.Text = soma.ToString();
        }

        private void btnReais_Click(object sender, EventArgs e)
        {
            double av1, av2, soma;

            //  CAPTURAR VALORES
            av1 = Convert.ToDouble(txtAV1.Text);
            av2 = Convert.ToDouble(txtAV2.Text);

            //  CALCULAR A SOMA
            soma = av1 + av2;

            //  EXIBIR O RESULTADO
            txtResultado.Text = soma.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double av1, av2, media;

            //  CAPTURAR OS VALORES
            av1 = Convert.ToDouble(txtAV1.Text);
            av2 = Convert.ToDouble(txtAV2.Text);

            //  CALCULAR
            media = (av1 + av2) / 2.0;

            //  EXIBIR
            txtResultado.Text = media.ToString();
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double media;

            media = Convert.ToDouble(txtResultado.Text);

            if (media >= 6)
            {
                lbl_Status.Text = "APROVADO!";
            }
            else
            {
                lbl_Status.Text = "REPROVADO!";
            }
        }
    }
}