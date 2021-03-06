﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

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
            this.ActiveControl = txtbox_user;
            txtbox_user._TextBox.Focus();
            KeyPreview = true;
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
            }

        }

        private void Txtbox_Pass_Enter(object sender, EventArgs e)
        {
            //If para limpar o campo quando focado e preencher quando desfocado
            if (txtbox_Pass.text == "Senha")
            {
                txtbox_Pass.text = String.Empty;
            }
        }

        private void Txtbox_Pass_Leave(object sender, EventArgs e)
        {
            //If para limpar o campo quando focado e preencher quando desfocado
            if (txtbox_Pass.text == String.Empty || txtbox_Pass._TextBox.Focus())
            {
                txtbox_Pass.text = "Senha";
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

        //Método para validar o usuário e a senha com o banco de dados
        private void ValidarUsuarioSenha()
        {
            VerificaLogin VL = new VerificaLogin();
            string login = txtbox_user.text;
            string senha = VL.CriptografiaSenha(txtbox_Pass.text);

            //variáveis para as informações do banco
            string loginBANCO = string.Empty;
            string senhaBANCO = string.Empty;

            //String com a conexão do banco de dados
            string ConnectionString = "server=localhost;Uid=root;Pwd=vssql;database=comercio;Allow User Variables=True";

            //String com a consulta a ser feita no banco de dados
            string Consulta = @"SELECT login,senha FROM usuarios WHERE login = @login and senha = @senha" ;

            //Instanciar objetos do MySQL
            MySqlConnection Connection = new MySqlConnection(ConnectionString);
            MySqlCommand SQLcommand = new MySqlCommand(Consulta, Connection);

            //Adiciona o parametro a consulta
            SQLcommand.Parameters.AddWithValue("@login", login);
            SQLcommand.Parameters.AddWithValue("@senha", senha);

            //Abrindo a conexão
            Connection.Open();

            //Executando um 'leitor'//Executando o comando SQL no banco de dados
            MySqlDataReader Ler = SQLcommand.ExecuteReader();




            //int retorno = Convert.ToInt32(SQLcommand.ExecuteScalar());

            //SQLcommand.Parameters.Clear();
            //SQLcommand.CommandType = CommandType.Text;




            //Ler.Read();
            //loginBANCO = Ler.GetString(1);
            //senhaBANCO = Ler.GetString(2);



            //Lendo as informações no banco
            //if (Ler.HasRows)
            //{
            while (Ler.Read())
                {
                    loginBANCO = Ler["login"].ToString();
                    senhaBANCO = Ler["senha"].ToString();
                }
            //}

            Connection.Close();


            //Comparação dos campos de login e senha
            //if((login != "Login") && (senha != "Senha"))
            {
                if((login == loginBANCO) && (senha == senhaBANCO))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Hide();
                    FormPrincipal frm = new FormPrincipal();
                    frm.ShowDialog();
                }
                else
                {
                    label1.Visible = true;
                    label1.Text = "Usuário ou senha inválidos!";
                    txtbox_user.Focus();
                }
            }
            //else
            //{
            //    label1.Visible = true;
            //    label1.Text = "Insira Login e senha!";
            //    txtbox_user.Focus();
            //}



        }

        private void Label_status_Click(object sender, EventArgs e)
        {

        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            ValidarUsuarioSenha();
        }

        private void Txtbox_Pass_OnTextChange(object sender, EventArgs e)
        {
            txtbox_Pass._TextBox.PasswordChar = '●';
        }

        //Iniciado implementação da função de passar entre as textbox com a tecla enter
        private void Txtbox_user_KeyDown(object sender, EventArgs e)
        {
            //KeyEventArgs ke = e as KeyEventArgs;
            //if (ke != null)
            //{
            //    if (ke.KeyCode == Keys.Enter)
            //    {
            //        txtbox_Pass._TextBox.Focus();
            //    }
            //}
        }

        private void Txtbox_user_KeyUp(object sender, EventArgs e)
        {
           
        }

        private void Txtbox_Pass_KeyDown(object sender, EventArgs e)
        {
            //KeyEventArgs ke = e as KeyEventArgs;
            //if (ke != null)
            //{
            //    if (ke.KeyCode == Keys.Enter)
            //    {
            //        ValidarUsuarioSenha();
            //    }
            //}
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            //Botão de fechar tela
            if (MessageBox.Show("Deseja encerrar a aplicação ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Label2_Click_1(object sender, EventArgs e)
        {
            //Botão minimizar tela
            this.WindowState = FormWindowState.Minimized;
        }
    }
    
}
