namespace Forms
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            PANEL1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            name = new Label();
            picbox = new PictureBox();
            issuebook = new Label();
            logout = new Label();
            returnbook = new Label();
            employeereport = new Label();
            addemployee = new Label();
            addbranch = new Label();
            bookreport = new Label();
            addbook = new Label();
            label8 = new Label();
            label1 = new Label();
            PANEL1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbox).BeginInit();
            SuspendLayout();
            // 
            // PANEL1
            // 
            PANEL1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            PANEL1.BackColor = Color.White;
            PANEL1.Controls.Add(label3);
            PANEL1.Controls.Add(label2);
            PANEL1.Controls.Add(name);
            PANEL1.Controls.Add(picbox);
            PANEL1.Controls.Add(issuebook);
            PANEL1.Controls.Add(logout);
            PANEL1.Controls.Add(returnbook);
            PANEL1.Controls.Add(employeereport);
            PANEL1.Controls.Add(addemployee);
            PANEL1.Controls.Add(addbranch);
            PANEL1.Controls.Add(bookreport);
            PANEL1.Controls.Add(addbook);
            PANEL1.Location = new Point(0, 0);
            PANEL1.Name = "PANEL1";
            PANEL1.Size = new Size(269, 692);
            PANEL1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(10, 332);
            label3.Name = "label3";
            label3.Size = new Size(120, 27);
            label3.TabIndex = 9;
            label3.Text = "Edit Book";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(12, 476);
            label2.Name = "label2";
            label2.Size = new Size(235, 27);
            label2.TabIndex = 8;
            label2.Text = "Search Book Report";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // name
            // 
            name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            name.AutoSize = true;
            name.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            name.ForeColor = Color.Black;
            name.Location = new Point(95, 123);
            name.Name = "name";
            name.Size = new Size(64, 23);
            name.TabIndex = 7;
            name.Text = "Admin";
            name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picbox
            // 
            picbox.BackgroundImageLayout = ImageLayout.Stretch;
            picbox.Image = (Image)resources.GetObject("picbox.Image");
            picbox.Location = new Point(72, 10);
            picbox.Name = "picbox";
            picbox.Size = new Size(115, 110);
            picbox.SizeMode = PictureBoxSizeMode.StretchImage;
            picbox.TabIndex = 6;
            picbox.TabStop = false;
            // 
            // issuebook
            // 
            issuebook.Anchor = AnchorStyles.None;
            issuebook.AutoSize = true;
            issuebook.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            issuebook.ForeColor = Color.SteelBlue;
            issuebook.Location = new Point(10, 549);
            issuebook.Name = "issuebook";
            issuebook.Size = new Size(158, 27);
            issuebook.TabIndex = 5;
            issuebook.Text = "Borrow Book";
            issuebook.TextAlign = ContentAlignment.MiddleCenter;
            issuebook.Click += issuebook_Click;
            // 
            // logout
            // 
            logout.Anchor = AnchorStyles.Bottom;
            logout.AutoSize = true;
            logout.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            logout.Location = new Point(72, 650);
            logout.Name = "logout";
            logout.Size = new Size(116, 26);
            logout.TabIndex = 1;
            logout.Text = "LOG OUT";
            logout.TextAlign = ContentAlignment.MiddleCenter;
            logout.Click += logout_Click;
            // 
            // returnbook
            // 
            returnbook.Anchor = AnchorStyles.None;
            returnbook.AutoSize = true;
            returnbook.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            returnbook.ForeColor = Color.SteelBlue;
            returnbook.Location = new Point(10, 585);
            returnbook.Name = "returnbook";
            returnbook.Size = new Size(153, 27);
            returnbook.TabIndex = 4;
            returnbook.Text = "Return Book";
            returnbook.TextAlign = ContentAlignment.MiddleCenter;
            returnbook.Click += returnbook_Click;
            // 
            // employeereport
            // 
            employeereport.Anchor = AnchorStyles.None;
            employeereport.AutoSize = true;
            employeereport.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            employeereport.ForeColor = Color.SteelBlue;
            employeereport.Location = new Point(12, 436);
            employeereport.Name = "employeereport";
            employeereport.Size = new Size(199, 27);
            employeereport.TabIndex = 3;
            employeereport.Text = "Employee Report";
            employeereport.TextAlign = ContentAlignment.MiddleCenter;
            employeereport.Click += employeereport_Click;
            // 
            // addemployee
            // 
            addemployee.Anchor = AnchorStyles.None;
            addemployee.AutoSize = true;
            addemployee.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addemployee.ForeColor = Color.SteelBlue;
            addemployee.Location = new Point(10, 267);
            addemployee.Name = "addemployee";
            addemployee.Size = new Size(224, 27);
            addemployee.TabIndex = 2;
            addemployee.Text = "Add New Employee";
            addemployee.TextAlign = ContentAlignment.MiddleCenter;
            addemployee.Click += addemployee_Click;
            // 
            // addbranch
            // 
            addbranch.Anchor = AnchorStyles.None;
            addbranch.AutoSize = true;
            addbranch.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addbranch.ForeColor = Color.SteelBlue;
            addbranch.Location = new Point(10, 224);
            addbranch.Name = "addbranch";
            addbranch.Size = new Size(198, 27);
            addbranch.TabIndex = 1;
            addbranch.Text = "Add new Branch";
            addbranch.TextAlign = ContentAlignment.MiddleCenter;
            addbranch.Click += addbranch_Click;
            // 
            // bookreport
            // 
            bookreport.Anchor = AnchorStyles.None;
            bookreport.AutoSize = true;
            bookreport.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            bookreport.ForeColor = Color.SteelBlue;
            bookreport.Location = new Point(12, 397);
            bookreport.Name = "bookreport";
            bookreport.Size = new Size(151, 27);
            bookreport.TabIndex = 1;
            bookreport.Text = "Book Report";
            bookreport.TextAlign = ContentAlignment.MiddleCenter;
            bookreport.Click += bookreport_Click;
            // 
            // addbook
            // 
            addbook.Anchor = AnchorStyles.None;
            addbook.AutoSize = true;
            addbook.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addbook.ForeColor = Color.SteelBlue;
            addbook.Location = new Point(9, 187);
            addbook.Name = "addbook";
            addbook.Size = new Size(176, 27);
            addbook.TabIndex = 0;
            addbook.Text = "Add New Book";
            addbook.TextAlign = ContentAlignment.MiddleCenter;
            addbook.Click += addbook_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(348, 297);
            label8.Name = "label8";
            label8.Size = new Size(713, 51);
            label8.TabIndex = 1;
            label8.Text = "WELCOME TO DIGITAL LIBRARY";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(602, 349);
            label1.Name = "label1";
            label1.Size = new Size(202, 51);
            label1.TabIndex = 2;
            label1.Text = "SYSTEM";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1126, 685);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(PANEL1);
            Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 3, 5, 3);
            Name = "Admin";
            Text = "Admin";
            PANEL1.ResumeLayout(false);
            PANEL1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PANEL1;
        private Label addbranch;
        private Label bookreport;
        private Label addbook;
        private Label returnbook;
        private Label employeereport;
        private Label addemployee;
        private Label logout;
        private Label label8;
        private Label issuebook;
        private PictureBox picbox;
        private Label name;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}