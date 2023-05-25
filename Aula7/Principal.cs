using System.Diagnostics.Eventing.Reader;

namespace Aula7
{
    public partial class frm_Principal : Form
    {


        public frm_Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Login frm_Login = new frm_Login();

            frm_Login.ShowDialog();
        }

        private void tela1ToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (Application.OpenForms.Count <= 1)
            {

                frm_IMC frm_IMC = new frm_IMC();

                frm_IMC.MdiParent = this;
                frm_IMC.Show();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja encerrar o programa?",
                "Sistema IMC", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Sobre frm_Sobre = new frm_Sobre();
            frm_Sobre.ShowDialog();
        }

        private void frm_Principal_Load(object sender, EventArgs e)
        {
            this.Hide();

            frm_Login frm_Login = new frm_Login();
            frm_Login.ShowDialog();


        }
    }
}