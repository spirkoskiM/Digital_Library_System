namespace Forms
{
    partial class Add_Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Book));
            label1 = new Label();
            tittle = new TextBox();
            getdescription = new TextBox();
            BOOKNAME = new Label();
            DESCRIPTION = new Label();
            AUTHOR = new Label();
            QUANTITY = new Label();
            getbranch = new ComboBox();
            BRANCH = new Label();
            button1 = new Button();
            browseimage = new Button();
            imgName = new Label();
            BookQuantity = new NumericUpDown();
            authorBox = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)BookQuantity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(341, 9);
            label1.Name = "label1";
            label1.Size = new Size(332, 51);
            label1.TabIndex = 0;
            label1.Text = "Add New Book";
            // 
            // tittle
            // 
            tittle.Anchor = AnchorStyles.None;
            tittle.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tittle.Location = new Point(329, 175);
            tittle.Name = "tittle";
            tittle.Size = new Size(367, 30);
            tittle.TabIndex = 1;
            // 
            // getdescription
            // 
            getdescription.Anchor = AnchorStyles.None;
            getdescription.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            getdescription.Location = new Point(329, 260);
            getdescription.Multiline = true;
            getdescription.Name = "getdescription";
            getdescription.Size = new Size(367, 83);
            getdescription.TabIndex = 2;
            // 
            // BOOKNAME
            // 
            BOOKNAME.Anchor = AnchorStyles.None;
            BOOKNAME.AutoSize = true;
            BOOKNAME.BackColor = Color.Transparent;
            BOOKNAME.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BOOKNAME.ForeColor = Color.White;
            BOOKNAME.Location = new Point(327, 153);
            BOOKNAME.Name = "BOOKNAME";
            BOOKNAME.Size = new Size(111, 19);
            BOOKNAME.TabIndex = 4;
            BOOKNAME.Text = "BOOK NAME";
            // 
            // DESCRIPTION
            // 
            DESCRIPTION.Anchor = AnchorStyles.None;
            DESCRIPTION.AutoSize = true;
            DESCRIPTION.BackColor = Color.Transparent;
            DESCRIPTION.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            DESCRIPTION.ForeColor = Color.White;
            DESCRIPTION.Location = new Point(327, 238);
            DESCRIPTION.Name = "DESCRIPTION";
            DESCRIPTION.Size = new Size(121, 19);
            DESCRIPTION.TabIndex = 5;
            DESCRIPTION.Text = "DESCRIPTION";
            // 
            // AUTHOR
            // 
            AUTHOR.Anchor = AnchorStyles.None;
            AUTHOR.AutoSize = true;
            AUTHOR.BackColor = Color.Transparent;
            AUTHOR.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AUTHOR.ForeColor = Color.White;
            AUTHOR.Location = new Point(328, 369);
            AUTHOR.Name = "AUTHOR";
            AUTHOR.Size = new Size(79, 19);
            AUTHOR.TabIndex = 6;
            AUTHOR.Text = "AUTHOR";
            // 
            // QUANTITY
            // 
            QUANTITY.Anchor = AnchorStyles.None;
            QUANTITY.AutoSize = true;
            QUANTITY.BackColor = Color.Transparent;
            QUANTITY.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            QUANTITY.ForeColor = Color.White;
            QUANTITY.Location = new Point(327, 447);
            QUANTITY.Name = "QUANTITY";
            QUANTITY.Size = new Size(91, 19);
            QUANTITY.TabIndex = 8;
            QUANTITY.Text = "QUANTITY";
            // 
            // getbranch
            // 
            getbranch.Anchor = AnchorStyles.None;
            getbranch.DropDownStyle = ComboBoxStyle.DropDownList;
            getbranch.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            getbranch.FormattingEnabled = true;
            getbranch.Location = new Point(329, 543);
            getbranch.Name = "getbranch";
            getbranch.Size = new Size(367, 31);
            getbranch.TabIndex = 9;
            // 
            // BRANCH
            // 
            BRANCH.Anchor = AnchorStyles.None;
            BRANCH.AutoSize = true;
            BRANCH.BackColor = Color.Transparent;
            BRANCH.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BRANCH.ForeColor = Color.White;
            BRANCH.Location = new Point(327, 523);
            BRANCH.Name = "BRANCH";
            BRANCH.Size = new Size(80, 19);
            BRANCH.TabIndex = 10;
            BRANCH.Text = "BRANCH";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            button1.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(844, 654);
            button1.Name = "button1";
            button1.Size = new Size(148, 44);
            button1.TabIndex = 11;
            button1.Text = "ADD BOOK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button_AddBook_Click;
            // 
            // browseimage
            // 
            browseimage.Anchor = AnchorStyles.None;
            browseimage.BackColor = Color.Transparent;
            browseimage.FlatAppearance.BorderColor = Color.White;
            browseimage.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            browseimage.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            browseimage.FlatStyle = FlatStyle.Flat;
            browseimage.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            browseimage.ForeColor = Color.White;
            browseimage.Location = new Point(327, 654);
            browseimage.Name = "browseimage";
            browseimage.Size = new Size(121, 38);
            browseimage.TabIndex = 13;
            browseimage.Text = "Browse image";
            browseimage.UseVisualStyleBackColor = false;
            browseimage.Click += browseimage_Click_1;
            // 
            // imgName
            // 
            imgName.Anchor = AnchorStyles.None;
            imgName.AutoSize = true;
            imgName.BackColor = Color.Transparent;
            imgName.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            imgName.ForeColor = Color.White;
            imgName.Location = new Point(474, 663);
            imgName.Name = "imgName";
            imgName.Size = new Size(0, 19);
            imgName.TabIndex = 16;
            // 
            // BookQuantity
            // 
            BookQuantity.Anchor = AnchorStyles.None;
            BookQuantity.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BookQuantity.Location = new Point(328, 469);
            BookQuantity.Name = "BookQuantity";
            BookQuantity.Size = new Size(106, 30);
            BookQuantity.TabIndex = 17;
            // 
            // authorBox
            // 
            authorBox.Anchor = AnchorStyles.None;
            authorBox.DropDownStyle = ComboBoxStyle.DropDownList;
            authorBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            authorBox.FormattingEnabled = true;
            authorBox.Location = new Point(327, 391);
            authorBox.Name = "authorBox";
            authorBox.Size = new Size(369, 31);
            authorBox.TabIndex = 18;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            button2.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(577, 428);
            button2.Name = "button2";
            button2.Size = new Size(119, 31);
            button2.TabIndex = 19;
            button2.Text = "New Author";
            button2.UseVisualStyleBackColor = false;
            button2.Click += AddAuthor_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            button3.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(577, 580);
            button3.Name = "button3";
            button3.Size = new Size(119, 31);
            button3.TabIndex = 20;
            button3.Text = "New Branch";
            button3.UseVisualStyleBackColor = false;
            button3.Click += AddBranch_Click;
            // 
            // Add_Book
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1028, 719);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(authorBox);
            Controls.Add(BookQuantity);
            Controls.Add(imgName);
            Controls.Add(browseimage);
            Controls.Add(button1);
            Controls.Add(BRANCH);
            Controls.Add(getbranch);
            Controls.Add(QUANTITY);
            Controls.Add(AUTHOR);
            Controls.Add(DESCRIPTION);
            Controls.Add(BOOKNAME);
            Controls.Add(getdescription);
            Controls.Add(tittle);
            Controls.Add(label1);
            Name = "Add_Book";
            Text = "Add_Book";
            Load += Add_Book_Load;
            ((System.ComponentModel.ISupportInitialize)BookQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tittle;
        private TextBox getdescription;
        private Label BOOKNAME;
        private Label DESCRIPTION;
        private Label AUTHOR;
        private Label QUANTITY;
        private ComboBox getbranch;
        private Label BRANCH;
        private Button button1;
        private Button browseimage;
        private Label imgName;
        private NumericUpDown BookQuantity;
        private ComboBox authorBox;
        private Button button2;
        private Button button3;
    }
}