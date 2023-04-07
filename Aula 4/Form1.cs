namespace Aula_4
{
    public class var_Global
    {
        public static String txt_Menu = "";

    }

    public partial class frm_Caixa : Form
    {
        public frm_Caixa()
        {
            InitializeComponent();
        }

        public void centralizarCaixa(frm_Caixa frm)
        {
            int tam_Menu = 0, ponto_Central = 375;
            tam_Menu = (int) var_Global.txt_Menu.Length / 2;
            lbl_Menu_Texto.Location = new Point(ponto_Central - (tam_Menu * 9), 95);

        }
        public void iniciarCaixa(frm_Caixa form, String menu)
        {
            var_Global.txt_Menu = menu;
            lbl_Menu_Texto.Text = var_Global.txt_Menu;
            centralizarCaixa(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_01_Click(object sender, EventArgs e)
        {
            //  lbl_Menu_Texto.Text = "A";
            iniciarCaixa(this, "Saldo");
        }

        private void btn_02_Click(object sender, EventArgs e)
        {
            //  lbl_Menu_Texto.Text = "B";
            iniciarCaixa(this, "Dep�sito");
        }

        private void btn_05_Click(object sender, EventArgs e)
        {
            //  lbl_Menu_Texto.Text = "E";
            iniciarCaixa(this, "PIX");
        }

        private void btn_06_Click(object sender, EventArgs e)
        {
            //  lbl_Menu_Texto.Text = "F";
            iniciarCaixa(this, "Dados");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_num_1_Click(object sender, EventArgs e)
        {
            lbl_Menu_Texto.Text += "1";
        }

        private void btn_num_2_Click(object sender, EventArgs e)
        {
            lbl_Menu_Texto.Text += "2";
        }

        private void btn_num_3_Click(object sender, EventArgs e)
        {
            lbl_Menu_Texto.Text += "3";
        }

        private void btn_num_4_Click(object sender, EventArgs e)
        {
            lbl_Menu_Texto.Text += "4";
        }

        private void btn_num_5_Click(object sender, EventArgs e)
        {
            lbl_Menu_Texto.Text += "5";
        }

        private void btn_num_6_Click(object sender, EventArgs e)
        {
            lbl_Menu_Texto.Text += "6";
        }

        private void btn_num_7_Click(object sender, EventArgs e)
        {
            lbl_Menu_Texto.Text += "7";
        }

        private void btn_num_8_Click(object sender, EventArgs e)
        {
            lbl_Menu_Texto.Text += "8";
        }

        private void btn_num_9_Click(object sender, EventArgs e)
        {
            lbl_Menu_Texto.Text += "9";
        }

        private void btn_num_0_Click(object sender, EventArgs e)
        {
            lbl_Menu_Texto.Text += "0";
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            lbl_Menu_Texto.Text = "";
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            lbl_Menu_Texto.Text = "ENTER";
        }

        private void btn__03_Click(object sender, EventArgs e)
        {
            //  lbl_Menu_Texto.Text = "C";
            iniciarCaixa(this, "Extrato");
        }

        private void btn_04_Click(object sender, EventArgs e)
        {
            //  lbl_Menu_Texto.Text = "D";
            iniciarCaixa(this, "Transferencia");
        }

        private void btn_07_Click(object sender, EventArgs e)
        {
            //  lbl_Menu_Texto.Text = "G";
            iniciarCaixa(this, "Recargas");
        }

        private void btn_08_Click(object sender, EventArgs e)
        {
            //  lbl_Menu_Texto.Text = "H";
            iniciarCaixa(this, "Sair");
        }

        private void frm_Caixa_Load(object sender, EventArgs e)
        {
            iniciarCaixa(this, "Menu do Banco Memorial");


        }

        private void lbl_menu_01_Click(object sender, EventArgs e)
        {

        }
    }
}