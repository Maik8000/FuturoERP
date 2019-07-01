namespace MCommerce
{
    partial class Form_Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_login = new ns1.BunifuThinButton2();
            this.button_exit = new ns1.BunifuThinButton2();
            this.txtbox_Pass = new ns1.BunifuTextbox();
            this.txtbox_user = new ns1.BunifuTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.X);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 37);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            // 
            // button_login
            // 
            this.button_login.ActiveBorderThickness = 1;
            this.button_login.ActiveCornerRadius = 20;
            this.button_login.ActiveFillColor = System.Drawing.Color.Maroon;
            this.button_login.ActiveForecolor = System.Drawing.Color.White;
            this.button_login.ActiveLineColor = System.Drawing.Color.Maroon;
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.button_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_login.BackgroundImage")));
            this.button_login.ButtonText = "Login";
            this.button_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.SeaGreen;
            this.button_login.IdleBorderThickness = 1;
            this.button_login.IdleCornerRadius = 20;
            this.button_login.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.button_login.IdleForecolor = System.Drawing.Color.White;
            this.button_login.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.button_login.Location = new System.Drawing.Point(66, 379);
            this.button_login.Margin = new System.Windows.Forms.Padding(5);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(220, 48);
            this.button_login.TabIndex = 0;
            this.button_login.TabStop = false;
            this.button_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_login.Click += new System.EventHandler(this.Button_login_Click);
            // 
            // button_exit
            // 
            this.button_exit.ActiveBorderThickness = 1;
            this.button_exit.ActiveCornerRadius = 20;
            this.button_exit.ActiveFillColor = System.Drawing.Color.Maroon;
            this.button_exit.ActiveForecolor = System.Drawing.Color.White;
            this.button_exit.ActiveLineColor = System.Drawing.Color.Maroon;
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.button_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_exit.BackgroundImage")));
            this.button_exit.ButtonText = "Sair";
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.Color.SeaGreen;
            this.button_exit.IdleBorderThickness = 1;
            this.button_exit.IdleCornerRadius = 20;
            this.button_exit.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.button_exit.IdleForecolor = System.Drawing.Color.SeaShell;
            this.button_exit.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.button_exit.Location = new System.Drawing.Point(114, 455);
            this.button_exit.Margin = new System.Windows.Forms.Padding(5);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(125, 39);
            this.button_exit.TabIndex = 4;
            this.button_exit.TabStop = false;
            this.button_exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_exit.Click += new System.EventHandler(this.BunifuThinButton22_Click);
            // 
            // txtbox_Pass
            // 
            this.txtbox_Pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.txtbox_Pass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtbox_Pass.BackgroundImage")));
            this.txtbox_Pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtbox_Pass.ForeColor = System.Drawing.Color.White;
            this.txtbox_Pass.Icon = ((System.Drawing.Image)(resources.GetObject("txtbox_Pass.Icon")));
            this.txtbox_Pass.Location = new System.Drawing.Point(32, 291);
            this.txtbox_Pass.Name = "txtbox_Pass";
            this.txtbox_Pass.Size = new System.Drawing.Size(285, 30);
            this.txtbox_Pass.TabIndex = 2;
            this.txtbox_Pass.text = "Senha";
            this.txtbox_Pass.OnTextChange += new System.EventHandler(this.Txtbox_Pass_OnTextChange);
            this.txtbox_Pass.Enter += new System.EventHandler(this.Txtbox_Pass_Enter);
            this.txtbox_Pass.Leave += new System.EventHandler(this.Txtbox_Pass_Leave);
            // 
            // txtbox_user
            // 
            this.txtbox_user.AccessibleName = "";
            this.txtbox_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.txtbox_user.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtbox_user.BackgroundImage")));
            this.txtbox_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtbox_user.ForeColor = System.Drawing.Color.White;
            this.txtbox_user.Icon = ((System.Drawing.Image)(resources.GetObject("txtbox_user.Icon")));
            this.txtbox_user.Location = new System.Drawing.Point(32, 231);
            this.txtbox_user.Name = "txtbox_user";
            this.txtbox_user.Size = new System.Drawing.Size(285, 30);
            this.txtbox_user.TabIndex = 1;
            this.txtbox_user.Tag = "";
            this.txtbox_user.text = "Login";
            this.txtbox_user.OnTextChange += new System.EventHandler(this.Txtbox_user_OnTextChange);
            this.txtbox_user.KeyDown += new System.EventHandler(this.Txtbox_user_KeyDown);
            this.txtbox_user.Enter += new System.EventHandler(this.BunifuTextbox1_Enter);
            this.txtbox_user.Leave += new System.EventHandler(this.Txtbox_user_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Insira Login e senha!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.X.Location = new System.Drawing.Point(313, 9);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(21, 20);
            this.X.TabIndex = 7;
            this.X.Text = "X";
            this.X.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.label2.Location = new System.Drawing.Point(287, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "-";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(351, 508);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtbox_user);
            this.Controls.Add(this.txtbox_Pass);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuThinButton2 button_login;
        private ns1.BunifuThinButton2 button_exit;
        private ns1.BunifuTextbox txtbox_user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuDragControl bunifuDragControl1;
        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuTextbox txtbox_Pass;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label label2;
    }
}

