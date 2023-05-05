using Microsoft.VisualBasic;
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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            String valor;
            if (txt_usuario.Text == "aluno" && txt_Senha.Text == "123")
            {
                valor = txt_usuario.Text;
                frm_Sistema sistema = new frm_Sistema(valor);
                
                this.Hide();
                sistema.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha Incorreta!");
            }

        }
    }
}
