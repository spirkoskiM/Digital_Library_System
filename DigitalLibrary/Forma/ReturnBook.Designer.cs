namespace Forms
{
    partial class ReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            label1 = new Label();
            empbox = new ComboBox();
            label2 = new Label();
            bookbox = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            selectbtn = new Button();
            panel1 = new Panel();
            BooksToReturnNumber = new Label();
            picbox = new PictureBox();
            branchname = new Label();
            authorname = new Label();
            penaltystatus = new Label();
            returnBooks = new Label();
            employeename = new Label();
            label8 = new Label();
            bookbranch = new Label();
            label7 = new Label();
            bookauthor = new Label();
            label6 = new Label();
            bookname = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(377, 21);
            label1.Name = "label1";
            label1.Size = new Size(286, 51);
            label1.TabIndex = 0;
            label1.Text = "Return Book";
            // 
            // empbox
            // 
            empbox.Anchor = AnchorStyles.None;
            empbox.DropDownStyle = ComboBoxStyle.DropDownList;
            empbox.FlatStyle = FlatStyle.Flat;
            empbox.FormattingEnabled = true;
            empbox.Location = new Point(27, 185);
            empbox.Name = "empbox";
            empbox.Size = new Size(167, 28);
            empbox.TabIndex = 1;
            empbox.SelectedIndexChanged += empbox_SelectedIndexChanged_1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 163);
            label2.Name = "label2";
            label2.Size = new Size(138, 19);
            label2.TabIndex = 2;
            label2.Text = "Select Employee";
            // 
            // bookbox
            // 
            bookbox.Anchor = AnchorStyles.None;
            bookbox.DropDownStyle = ComboBoxStyle.DropDownList;
            bookbox.FlatStyle = FlatStyle.Flat;
            bookbox.FormattingEnabled = true;
            bookbox.Location = new Point(263, 185);
            bookbox.Name = "bookbox";
            bookbox.Size = new Size(167, 28);
            bookbox.TabIndex = 3;
            bookbox.SelectedIndexChanged += bookbox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(263, 163);
            label3.Name = "label3";
            label3.Size = new Size(103, 19);
            label3.TabIndex = 4;
            label3.Text = "Select Book";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(391, 278);
            label4.Name = "label4";
            label4.Size = new Size(272, 44);
            label4.TabIndex = 5;
            label4.Text = "BOOK DETAIL";
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
            selectbtn.Location = new Point(463, 181);
            selectbtn.Name = "selectbtn";
            selectbtn.Size = new Size(82, 34);
            selectbtn.TabIndex = 16;
            selectbtn.Text = "Select";
            selectbtn.UseVisualStyleBackColor = false;
            selectbtn.Click += selectbtn_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(BooksToReturnNumber);
            panel1.Controls.Add(picbox);
            panel1.Controls.Add(branchname);
            panel1.Controls.Add(authorname);
            panel1.Controls.Add(penaltystatus);
            panel1.Controls.Add(returnBooks);
            panel1.Controls.Add(employeename);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(bookbranch);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(bookauthor);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(bookname);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(26, 344);
            panel1.Name = "panel1";
            panel1.Size = new Size(995, 383);
            panel1.TabIndex = 17;
            // 
            // BooksToReturnNumber
            // 
            BooksToReturnNumber.AutoSize = true;
            BooksToReturnNumber.BackColor = Color.Transparent;
            BooksToReturnNumber.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BooksToReturnNumber.ForeColor = Color.Black;
            BooksToReturnNumber.Location = new Point(557, 299);
            BooksToReturnNumber.Name = "BooksToReturnNumber";
            BooksToReturnNumber.Size = new Size(0, 24);
            BooksToReturnNumber.TabIndex = 33;
            // 
            // picbox
            // 
            picbox.BackColor = Color.Transparent;
            picbox.BorderStyle = BorderStyle.Fixed3D;
            picbox.Location = new Point(33, 90);
            picbox.Name = "picbox";
            picbox.Size = new Size(307, 276);
            picbox.SizeMode = PictureBoxSizeMode.StretchImage;
            picbox.TabIndex = 32;
            picbox.TabStop = false;
            // 
            // branchname
            // 
            branchname.AutoSize = true;
            branchname.BackColor = Color.Transparent;
            branchname.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            branchname.ForeColor = Color.Black;
            branchname.Location = new Point(470, 127);
            branchname.Name = "branchname";
            branchname.Size = new Size(0, 24);
            branchname.TabIndex = 31;
            // 
            // authorname
            // 
            authorname.AutoSize = true;
            authorname.BackColor = Color.Transparent;
            authorname.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            authorname.ForeColor = Color.Black;
            authorname.Location = new Point(452, 90);
            authorname.Name = "authorname";
            authorname.Size = new Size(0, 24);
            authorname.TabIndex = 30;
            // 
            // penaltystatus
            // 
            penaltystatus.AutoSize = true;
            penaltystatus.BackColor = Color.Transparent;
            penaltystatus.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            penaltystatus.ForeColor = Color.Black;
            penaltystatus.Location = new Point(539, 299);
            penaltystatus.Name = "penaltystatus";
            penaltystatus.Size = new Size(0, 24);
            penaltystatus.TabIndex = 29;
            // 
            // returnBooks
            // 
            returnBooks.AutoSize = true;
            returnBooks.BackColor = Color.Transparent;
            returnBooks.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            returnBooks.ForeColor = Color.Black;
            returnBooks.Location = new Point(365, 299);
            returnBooks.Name = "returnBooks";
            returnBooks.Size = new Size(177, 24);
            returnBooks.TabIndex = 28;
            returnBooks.Text = "Books To Return:";
            // 
            // employeename
            // 
            employeename.AutoSize = true;
            employeename.BackColor = Color.Transparent;
            employeename.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            employeename.ForeColor = Color.Black;
            employeename.Location = new Point(539, 263);
            employeename.Name = "employeename";
            employeename.Size = new Size(0, 24);
            employeename.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(365, 263);
            label8.Name = "label8";
            label8.Size = new Size(168, 24);
            label8.TabIndex = 26;
            label8.Text = "Employee Name:";
            // 
            // bookbranch
            // 
            bookbranch.AutoSize = true;
            bookbranch.BackColor = Color.Transparent;
            bookbranch.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bookbranch.ForeColor = Color.Black;
            bookbranch.Location = new Point(470, 138);
            bookbranch.Name = "bookbranch";
            bookbranch.Size = new Size(0, 24);
            bookbranch.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(365, 127);
            label7.Name = "label7";
            label7.Size = new Size(85, 24);
            label7.TabIndex = 24;
            label7.Text = "Branch:";
            // 
            // bookauthor
            // 
            bookauthor.AutoSize = true;
            bookauthor.BackColor = Color.Transparent;
            bookauthor.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bookauthor.ForeColor = Color.Black;
            bookauthor.Location = new Point(470, 90);
            bookauthor.Name = "bookauthor";
            bookauthor.Size = new Size(0, 24);
            bookauthor.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(365, 90);
            label6.Name = "label6";
            label6.Size = new Size(81, 24);
            label6.TabIndex = 22;
            label6.Text = "Author:";
            // 
            // bookname
            // 
            bookname.AutoSize = true;
            bookname.BackColor = Color.Transparent;
            bookname.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bookname.ForeColor = Color.Black;
            bookname.Location = new Point(170, 43);
            bookname.Name = "bookname";
            bookname.Size = new Size(0, 24);
            bookname.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(39, 43);
            label5.Name = "label5";
            label5.Size = new Size(125, 24);
            label5.TabIndex = 20;
            label5.Text = "Book Name:";
            // 
            // ReturnBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1049, 750);
            Controls.Add(panel1);
            Controls.Add(selectbtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(bookbox);
            Controls.Add(label2);
            Controls.Add(empbox);
            Controls.Add(label1);
            Name = "ReturnBook";
            Text = "ReturnBook";
            Load += ReturnBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox empbox;
        private Label label2;
        private ComboBox bookbox;
        private Label label3;
        private Label label4;
        private Button selectbtn;
        private Panel panel1;
        private PictureBox picbox;
        private Label branchname;
        private Label authorname;
        private Label penaltystatus;
        private Label returnBooks;
        private Label employeename;
        private Label label8;
        private Label bookbranch;
        private Label label7;
        private Label bookauthor;
        private Label label6;
        private Label bookname;
        private Label label5;
        private Label BooksToReturnNumber;
    }
}