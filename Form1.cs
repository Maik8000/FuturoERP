using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCommerce
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BunifuTextbox1_Enter(object sender, EventArgs e)
        {
            //If para limpar o campo quando focado e preencher quando desfocado
            if (txtbox_user.text == "Login")
            {
                txtbox_user.text = String.Empty;
                txtbox_user.ForeColor = Color.White;
            }
        }

        private void Txtbox_user_OnTextChange(object sender, EventArgs e)
        {

        }

        private void Txtbox_user_Leave(object sender, EventArgs e)
        {
            //If para limpar o campo quando focado e preencher quando desfocado
            if (txtbox_user.text == String.Empty)
            {
                txtbox_user.text = "Login";
                txtbox_user.ForeColor = Color.White;
            }

        }

        private void Txtbox_Pass_Enter(object sender, EventArgs e)
        {
           if(txtbox_Pass.text == "Senha")
            {
                txtbox_Pass.text = String.Empty;
                txtbox_Pass.ForeColor = Color.White;
            }
        }

        private void Txtbox_Pass_Leave(object sender, EventArgs e)
        {
            if (txtbox_Pass.text == String.Empty)
            {
                txtbox_Pass.text = "Senha";
                txtbox_Pass.ForeColor = Color.White;
            }
        }
    }
}
