namespace StarkAirlines
{
    partial class LoginPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Username = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.ResetLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UidTb = new System.Windows.Forms.RichTextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.CreatAcc = new System.Windows.Forms.Button();
            this.PassTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 144);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 478);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 75);
            this.panel2.TabIndex = 1;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.Font = new System.Drawing.Font("Lucida Fax", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.CadetBlue;
            this.Username.Location = new System.Drawing.Point(172, 201);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(132, 26);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username";
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.NavajoWhite;
            this.Login.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(346, 320);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(121, 34);
            this.Login.TabIndex = 6;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // ResetLogin
            // 
            this.ResetLogin.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ResetLogin.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetLogin.Location = new System.Drawing.Point(172, 320);
            this.ResetLogin.Name = "ResetLogin";
            this.ResetLogin.Size = new System.Drawing.Size(143, 34);
            this.ResetLogin.TabIndex = 7;
            this.ResetLogin.Text = "Reset";
            this.ResetLogin.UseVisualStyleBackColor = false;
            this.ResetLogin.Click += new System.EventHandler(this.ResetLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(176, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(0, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 337);
            this.panel3.TabIndex = 0;
            // 
            // UidTb
            // 
            this.UidTb.Location = new System.Drawing.Point(308, 198);
            this.UidTb.Name = "UidTb";
            this.UidTb.Size = new System.Drawing.Size(159, 29);
            this.UidTb.TabIndex = 12;
            this.UidTb.Text = "";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Exit.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(254, 429);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(143, 34);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            // 
            // CreatAcc
            // 
            this.CreatAcc.BackColor = System.Drawing.Color.NavajoWhite;
            this.CreatAcc.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatAcc.Location = new System.Drawing.Point(254, 369);
            this.CreatAcc.Name = "CreatAcc";
            this.CreatAcc.Size = new System.Drawing.Size(160, 44);
            this.CreatAcc.TabIndex = 20;
            this.CreatAcc.Text = "Create an Account";
            this.CreatAcc.UseVisualStyleBackColor = false;
            this.CreatAcc.Click += new System.EventHandler(this.CreatAcc_Click);
            // 
            // PassTb
            // 
            this.PassTb.Location = new System.Drawing.Point(308, 264);
            this.PassTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PassTb.Multiline = true;
            this.PassTb.Name = "PassTb";
            this.PassTb.Size = new System.Drawing.Size(159, 29);
            this.PassTb.TabIndex = 21;
            this.PassTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 553);
            this.Controls.Add(this.PassTb);
            this.Controls.Add(this.CreatAcc);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.UidTb);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResetLogin);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginPage";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button ResetLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox UidTb;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button CreatAcc;
        private System.Windows.Forms.TextBox PassTb;
    }
}