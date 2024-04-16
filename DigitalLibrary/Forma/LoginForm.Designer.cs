namespace Forma
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            username = new TextBox();
            password = new TextBox();
            usnm = new Label();
            pass = new Label();
            adminradio = new RadioButton();
            employeeradio = new RadioButton();
            loginbtn = new Button();
            userimg = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)userimg).BeginInit();
            SuspendLayout();
            // 
            // username
            // 
            username.Anchor = AnchorStyles.None;
            username.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(304, 290);
            username.Name = "username";
            username.Size = new Size(391, 34);
            username.TabIndex = 1;
            // 
            // password
            // 
            password.Anchor = AnchorStyles.None;
            password.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(304, 405);
            password.Name = "password";
            password.Size = new Size(391, 34);
            password.TabIndex = 2;
            password.UseSystemPasswordChar = true;
            // 
            // usnm
            // 
            usnm.Anchor = AnchorStyles.None;
            usnm.AutoSize = true;
            usnm.BackColor = Color.Transparent;
            usnm.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            usnm.ForeColor = Color.White;
            usnm.ImageAlign = ContentAlignment.BottomLeft;
            usnm.Location = new Point(304, 268);
            usnm.Name = "usnm";
            usnm.Size = new Size(88, 19);
            usnm.TabIndex = 3;
            usnm.Text = "Username";
            usnm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pass
            // 
            pass.Anchor = AnchorStyles.None;
            pass.AutoSize = true;
            pass.BackColor = Color.Transparent;
            pass.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            pass.ForeColor = Color.White;
            pass.Location = new Point(304, 383);
            pass.Name = "pass";
            pass.Size = new Size(87, 19);
            pass.TabIndex = 4;
            pass.Text = "Password";
            pass.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // adminradio
            // 
            adminradio.Anchor = AnchorStyles.None;
            adminradio.AutoSize = true;
            adminradio.BackColor = Color.Transparent;
            adminradio.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            adminradio.ForeColor = Color.White;
            adminradio.Location = new Point(304, 465);
            adminradio.Name = "adminradio";
            adminradio.Size = new Size(79, 23);
            adminradio.TabIndex = 5;
            adminradio.TabStop = true;
            adminradio.Text = "Admin";
            adminradio.UseVisualStyleBackColor = false;
            // 
            // employeeradio
            // 
            employeeradio.Anchor = AnchorStyles.None;
            employeeradio.AutoSize = true;
            employeeradio.BackColor = Color.Transparent;
            employeeradio.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            employeeradio.ForeColor = Color.White;
            employeeradio.Location = new Point(389, 465);
            employeeradio.Name = "employeeradio";
            employeeradio.Size = new Size(106, 23);
            employeeradio.TabIndex = 6;
            employeeradio.TabStop = true;
            employeeradio.Text = "Employee";
            employeeradio.UseVisualStyleBackColor = false;
            // 
            // loginbtn
            // 
            loginbtn.Anchor = AnchorStyles.None;
            loginbtn.BackColor = Color.Transparent;
            loginbtn.FlatAppearance.BorderColor = Color.White;
            loginbtn.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            loginbtn.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            loginbtn.FlatStyle = FlatStyle.Flat;
            loginbtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            loginbtn.ForeColor = Color.White;
            loginbtn.Location = new Point(304, 507);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(391, 43);
            loginbtn.TabIndex = 7;
            loginbtn.Text = "Log in";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click;
            loginbtn.KeyPress += loginbtn_KeyPress;
            // 
            // userimg
            // 
            userimg.Anchor = AnchorStyles.None;
            userimg.BackColor = Color.Transparent;
            userimg.Image = (Image)resources.GetObject("userimg.Image");
            userimg.Location = new Point(389, 30);
            userimg.Name = "userimg";
            userimg.Size = new Size(220, 210);
            userimg.SizeMode = PictureBoxSizeMode.StretchImage;
            userimg.TabIndex = 22;
            userimg.TabStop = false;
            // 
            // LoginForm
            // 
            AcceptButton = loginbtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1002, 608);
            Controls.Add(userimg);
            Controls.Add(loginbtn);
            Controls.Add(employeeradio);
            Controls.Add(adminradio);
            Controls.Add(pass);
            Controls.Add(usnm);
            Controls.Add(password);
            Controls.Add(username);
            Name = "LoginForm";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)userimg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox username;
        private TextBox password;
        private Label usnm;
        private Label pass;
        private RadioButton adminradio;
        private RadioButton employeeradio;
        private Button loginbtn;
        private PictureBox userimg;
    }
}