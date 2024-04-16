namespace Forms
{
    partial class IssueBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBook));
            label1 = new Label();
            employeebox = new ComboBox();
            bookbox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            selectbtn = new Button();
            panel1 = new Panel();
            bookQuan = new Label();
            quantity = new Label();
            picture1 = new PictureBox();
            employeename = new Label();
            branchname = new Label();
            authorname = new Label();
            bookname = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(314, 22);
            label1.Name = "label1";
            label1.Size = new Size(299, 51);
            label1.TabIndex = 0;
            label1.Text = "Borrow Book";
            // 
            // employeebox
            // 
            employeebox.Anchor = AnchorStyles.None;
            employeebox.DropDownStyle = ComboBoxStyle.DropDownList;
            employeebox.FlatStyle = FlatStyle.Flat;
            employeebox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            employeebox.FormattingEnabled = true;
            employeebox.Location = new Point(228, 159);
            employeebox.Name = "employeebox";
            employeebox.Size = new Size(201, 31);
            employeebox.TabIndex = 1;
            employeebox.SelectedIndexChanged += employeebox_SelectedIndexChanged;
            // 
            // bookbox
            // 
            bookbox.Anchor = AnchorStyles.None;
            bookbox.DropDownStyle = ComboBoxStyle.DropDownList;
            bookbox.FlatStyle = FlatStyle.Flat;
            bookbox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bookbox.FormattingEnabled = true;
            bookbox.Location = new Point(520, 159);
            bookbox.Name = "bookbox";
            bookbox.Size = new Size(186, 31);
            bookbox.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(228, 137);
            label2.Name = "label2";
            label2.Size = new Size(138, 19);
            label2.TabIndex = 3;
            label2.Text = "Select Employee";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(520, 137);
            label3.Name = "label3";
            label3.Size = new Size(103, 19);
            label3.TabIndex = 4;
            label3.Text = "Select Book";
            // 
            // selectbtn
            // 
            selectbtn.Anchor = AnchorStyles.None;
            selectbtn.BackColor = Color.Transparent;
            selectbtn.FlatAppearance.BorderColor = Color.White;
            selectbtn.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            selectbtn.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            selectbtn.FlatStyle = FlatStyle.Flat;
            selectbtn.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            selectbtn.ForeColor = Color.White;
            selectbtn.Location = new Point(802, 202);
            selectbtn.Name = "selectbtn";
            selectbtn.Size = new Size(103, 40);
            selectbtn.TabIndex = 5;
            selectbtn.Text = "Select";
            selectbtn.UseVisualStyleBackColor = false;
            selectbtn.Click += selectbtn_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(bookQuan);
            panel1.Controls.Add(quantity);
            panel1.Controls.Add(picture1);
            panel1.Controls.Add(employeename);
            panel1.Controls.Add(branchname);
            panel1.Controls.Add(authorname);
            panel1.Controls.Add(bookname);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(34, 260);
            panel1.Name = "panel1";
            panel1.Size = new Size(871, 366);
            panel1.TabIndex = 6;
            // 
            // bookQuan
            // 
            bookQuan.AutoSize = true;
            bookQuan.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bookQuan.Location = new Point(455, 315);
            bookQuan.Name = "bookQuan";
            bookQuan.Size = new Size(0, 24);
            bookQuan.TabIndex = 17;
            // 
            // quantity
            // 
            quantity.AutoSize = true;
            quantity.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            quantity.Location = new Point(351, 315);
            quantity.Name = "quantity";
            quantity.Size = new Size(98, 24);
            quantity.TabIndex = 16;
            quantity.Text = "Quantity:";
            // 
            // picture1
            // 
            picture1.BorderStyle = BorderStyle.Fixed3D;
            picture1.Location = new Point(16, 72);
            picture1.Name = "picture1";
            picture1.Size = new Size(307, 276);
            picture1.SizeMode = PictureBoxSizeMode.StretchImage;
            picture1.TabIndex = 15;
            picture1.TabStop = false;
            // 
            // employeename
            // 
            employeename.AutoSize = true;
            employeename.BackColor = Color.Transparent;
            employeename.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            employeename.ForeColor = Color.Black;
            employeename.Location = new Point(536, 251);
            employeename.Name = "employeename";
            employeename.Size = new Size(0, 24);
            employeename.TabIndex = 14;
            // 
            // branchname
            // 
            branchname.AutoSize = true;
            branchname.BackColor = Color.Transparent;
            branchname.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            branchname.ForeColor = Color.Black;
            branchname.Location = new Point(455, 182);
            branchname.Name = "branchname";
            branchname.Size = new Size(0, 24);
            branchname.TabIndex = 13;
            // 
            // authorname
            // 
            authorname.AutoSize = true;
            authorname.BackColor = Color.Transparent;
            authorname.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            authorname.ForeColor = Color.Black;
            authorname.Location = new Point(452, 107);
            authorname.Name = "authorname";
            authorname.Size = new Size(0, 24);
            authorname.TabIndex = 12;
            // 
            // bookname
            // 
            bookname.AutoSize = true;
            bookname.BackColor = Color.Transparent;
            bookname.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bookname.ForeColor = Color.Black;
            bookname.Location = new Point(147, 29);
            bookname.Name = "bookname";
            bookname.Size = new Size(0, 24);
            bookname.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(351, 251);
            label7.Name = "label7";
            label7.Size = new Size(168, 24);
            label7.TabIndex = 10;
            label7.Text = "Employee Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(351, 182);
            label6.Name = "label6";
            label6.Size = new Size(85, 24);
            label6.TabIndex = 9;
            label6.Text = "Branch:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(351, 107);
            label5.Name = "label5";
            label5.Size = new Size(81, 24);
            label5.TabIndex = 8;
            label5.Text = "Author:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(16, 29);
            label4.Name = "label4";
            label4.Size = new Size(125, 24);
            label4.TabIndex = 7;
            label4.Text = "Book Name:";
            // 
            // IssueBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(939, 642);
            Controls.Add(panel1);
            Controls.Add(selectbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(bookbox);
            Controls.Add(employeebox);
            Controls.Add(label1);
            Name = "IssueBook";
            Text = "IssueBook";
            Load += IssueBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox employeebox;
        private ComboBox bookbox;
        private Label label2;
        private Label label3;
        private Button selectbtn;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label employeename;
        private Label branchname;
        private Label authorname;
        private Label bookname;
        private PictureBox picture1;
        private Label quantity;
        private Label bookQuan;
    }
}