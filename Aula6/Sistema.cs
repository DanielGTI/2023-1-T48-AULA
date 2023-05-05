using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula6
{
    public partial class frm_Sistema : Form
    {
        public frm_Sistema(object usuario)
        {
            InitializeComponent();
            lbl_Usuario.Text = usuario.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frm_Tela2 produto = new frm_Tela2();
            produto.nomeProduto(lbl_Usuario.Text);
            produto.Show();

        }

        private void frm_Sistema_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
