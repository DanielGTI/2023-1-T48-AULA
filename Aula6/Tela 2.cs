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
    public partial class frm_Tela2 : Form
    {
        public frm_Tela2()
        {
            InitializeComponent();
        }

        public void nomeProduto(object valor)
        {
            txt_Valor.Text = valor.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
