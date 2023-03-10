namespace Aula_2
{
    public partial class frmContato : Form
    {
        public frmContato()
        {
            InitializeComponent();
        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo " + txtNome.Text + "!");
            //  Bem vindo Daniel!
        }
    }
}