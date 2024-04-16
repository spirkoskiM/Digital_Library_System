namespace Forms
{
    partial class Employe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employe));
            panel1 = new Panel();
            nameEmployee = new Label();
            picbox = new PictureBox();
            logout = new Label();
            bookreport = new Label();
            acc = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(nameEmployee);
            panel1.Controls.Add(picbox);
            panel1.Controls.Add(logout);
            panel1.Controls.Add(bookreport);
            panel1.Controls.Add(acc);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(259, 625);
            panel1.TabIndex = 0;
            // 
            // nameEmployee
            // 
            nameEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            nameEmployee.AutoSize = true;
            nameEmployee.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            nameEmployee.ForeColor = Color.Black;
            nameEmployee.Location = new Point(79, 128);
            nameEmployee.Name = "nameEmployee";
            nameEmployee.Size = new Size(89, 21);
            nameEmployee.TabIndex = 5;
            nameEmployee.Text = "Employee";
            nameEmployee.TextAlign = ContentAlignment.MiddleRight;
            // 
            // picbox
            // 
            picbox.BackgroundImageLayout = ImageLayout.Stretch;
            picbox.Image = (Image)resources.GetObject("picbox.Image");
            picbox.Location = new Point(68, 15);
            picbox.Name = "picbox";
            picbox.Size = new Size(115, 110);
            picbox.SizeMode = PictureBoxSizeMode.StretchImage;
            picbox.TabIndex = 4;
            picbox.TabStop = false;
            // 
            // logout
            // 
            logout.Anchor = AnchorStyles.Bottom;
            logout.AutoSize = true;
            logout.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            logout.Location = new Point(67, 551);
            logout.Name = "logout";
            logout.Size = new Size(116, 26);
            logout.TabIndex = 3;
            logout.Text = "LOG OUT";
            logout.Click += logout_Click;
            // 
            // bookreport
            // 
            bookreport.Anchor = AnchorStyles.None;
            bookreport.AutoSize = true;
            bookreport.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            bookreport.ForeColor = Color.SteelBlue;
            bookreport.Location = new Point(39, 328);
            bookreport.Name = "bookreport";
            bookreport.Size = new Size(182, 33);
            bookreport.TabIndex = 1;
            bookreport.Text = "Book Report";
            bookreport.Click += bookreport_Click;
            // 
            // acc
            // 
            acc.Anchor = AnchorStyles.None;
            acc.AutoSize = true;
            acc.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            acc.ForeColor = Color.SteelBlue;
            acc.Location = new Point(53, 264);
            acc.Name = "acc";
            acc.Size = new Size(151, 33);
            acc.TabIndex = 0;
            acc.Text = "My Profile";
            acc.Click += acc_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(312, 249);
            label1.Name = "label1";
            label1.Size = new Size(713, 51);
            label1.TabIndex = 1;
            label1.Text = "WELCOME TO DIGITAL LIBRARY";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(562, 310);
            label2.Name = "label2";
            label2.Size = new Size(202, 51);
            label2.TabIndex = 2;
            label2.Text = "SYSTEM";
            // 
            // Employe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1067, 619);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Employe";
            Text = "Employee";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label acc;
        private Label logout;
        private Label bookreport;
        private Label label1;
        private PictureBox picbox;
        private Label nameEmployee;
        private Label label2;
    }
}