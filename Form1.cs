using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MCommerce
{
    public partial class Form_Login : Form
    {
        //Função para movimentar a form pelo panel
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
       
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        // Fim da função
        public static extern bool ReleaseCapture();

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
            //If para limpar o campo quando focado e preencher quando desfocado
            if (txtbox_Pass.text == "Senha")
            {
                txtbox_Pass.text = String.Empty;
                txtbox_Pass.ForeColor = Color.White;
            }
        }

        private void Txtbox_Pass_Leave(object sender, EventArgs e)
        {
            //If para limpar o campo quando focado e preencher quando desfocado
            if (txtbox_Pass.text == String.Empty)
            {
                txtbox_Pass.text = "Senha";
                txtbox_Pass.ForeColor = Color.White;
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //Função para mover a form pelo panel
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
    
}
