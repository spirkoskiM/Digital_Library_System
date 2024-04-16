namespace Forms
{
    partial class EditBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBook));
            label1 = new Label();
            book = new ComboBox();
            label2 = new Label();
            Save = new Button();
            tittleBox = new TextBox();
            descBox = new TextBox();
            quantity = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            branchBox = new ComboBox();
            label6 = new Label();
            authorBox = new ComboBox();
            label7 = new Label();
            browseImage = new Button();
            addNewBranch = new Button();
            addNewAuthor = new Button();
            img = new Label();
            ((System.ComponentModel.ISupportInitialize)quantity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(449, 33);
            label1.Name = "label1";
            label1.Size = new Size(227, 51);
            label1.TabIndex = 9;
            label1.Text = "Edit Book";
            // 
            // book
            // 
            book.Anchor = AnchorStyles.None;
            book.DropDownStyle = ComboBoxStyle.DropDownList;
            book.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            book.FormattingEnabled = true;
            book.Location = new Point(48, 176);
            book.Name = "book";
            book.Size = new Size(200, 29);
            book.TabIndex = 10;
            book.SelectedIndexChanged += book_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(48, 153);
            label2.Name = "label2";
            label2.Size = new Size(109, 19);
            label2.TabIndex = 11;
            label2.Text = "Select Book:";
            // 
            // Save
            // 
            Save.Anchor = AnchorStyles.None;
            Save.BackColor = Color.Transparent;
            Save.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            Save.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            Save.FlatStyle = FlatStyle.Flat;
            Save.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Save.ForeColor = Color.White;
            Save.Location = new Point(983, 602);
            Save.Name = "Save";
            Save.Size = new Size(109, 37);
            Save.TabIndex = 13;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // tittleBox
            // 
            tittleBox.Anchor = AnchorStyles.None;
            tittleBox.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tittleBox.Location = new Point(170, 317);
            tittleBox.Name = "tittleBox";
            tittleBox.Size = new Size(200, 28);
            tittleBox.TabIndex = 14;
            // 
            // descBox
            // 
            descBox.Anchor = AnchorStyles.None;
            descBox.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            descBox.Location = new Point(170, 414);
            descBox.Name = "descBox";
            descBox.Size = new Size(200, 28);
            descBox.TabIndex = 15;
            // 
            // quantity
            // 
            quantity.Anchor = AnchorStyles.None;
            quantity.Location = new Point(170, 506);
            quantity.Name = "quantity";
            quantity.Size = new Size(200, 27);
            quantity.TabIndex = 16;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(170, 295);
            label3.Name = "label3";
            label3.Size = new Size(54, 19);
            label3.TabIndex = 17;
            label3.Text = "Tittle:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(170, 392);
            label4.Name = "label4";
            label4.Size = new Size(105, 19);
            label4.TabIndex = 18;
            label4.Text = "Description:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(170, 484);
            label5.Name = "label5";
            label5.Size = new Size(82, 19);
            label5.TabIndex = 19;
            label5.Text = "Quantity:";
            // 
            // branchBox
            // 
            branchBox.Anchor = AnchorStyles.None;
            branchBox.DropDownStyle = ComboBoxStyle.DropDownList;
            branchBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            branchBox.FormattingEnabled = true;
            branchBox.Location = new Point(462, 318);
            branchBox.Name = "branchBox";
            branchBox.Size = new Size(200, 27);
            branchBox.TabIndex = 20;
            branchBox.SelectedIndexChanged += branchBox_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(462, 295);
            label6.Name = "label6";
            label6.Size = new Size(72, 19);
            label6.TabIndex = 21;
            label6.Text = "Branch:";
            // 
            // authorBox
            // 
            authorBox.Anchor = AnchorStyles.None;
            authorBox.DropDownStyle = ComboBoxStyle.DropDownList;
            authorBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            authorBox.FormattingEnabled = true;
            authorBox.Location = new Point(462, 415);
            authorBox.Name = "authorBox";
            authorBox.Size = new Size(200, 27);
            authorBox.TabIndex = 22;
            authorBox.SelectedIndexChanged += authorBox_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(462, 392);
            label7.Name = "label7";
            label7.Size = new Size(69, 19);
            label7.TabIndex = 23;
            label7.Text = "Author:";
            // 
            // browseImage
            // 
            browseImage.Anchor = AnchorStyles.None;
            browseImage.BackColor = Color.Transparent;
            browseImage.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            browseImage.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            browseImage.FlatStyle = FlatStyle.Flat;
            browseImage.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            browseImage.ForeColor = Color.White;
            browseImage.Location = new Point(489, 500);
            browseImage.Name = "browseImage";
            browseImage.Size = new Size(142, 36);
            browseImage.TabIndex = 26;
            browseImage.Text = "Browse Image";
            browseImage.UseVisualStyleBackColor = false;
            browseImage.Click += browseImage_Click;
            // 
            // addNewBranch
            // 
            addNewBranch.Anchor = AnchorStyles.None;
            addNewBranch.BackColor = Color.Transparent;
            addNewBranch.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            addNewBranch.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            addNewBranch.FlatStyle = FlatStyle.Flat;
            addNewBranch.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            addNewBranch.ForeColor = Color.White;
            addNewBranch.Location = new Point(702, 318);
            addNewBranch.Name = "addNewBranch";
            addNewBranch.Size = new Size(121, 31);
            addNewBranch.TabIndex = 27;
            addNewBranch.Text = "Add Branch";
            addNewBranch.UseVisualStyleBackColor = false;
            addNewBranch.Click += button1_Click;
            // 
            // addNewAuthor
            // 
            addNewAuthor.Anchor = AnchorStyles.None;
            addNewAuthor.BackColor = Color.Transparent;
            addNewAuthor.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            addNewAuthor.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            addNewAuthor.FlatStyle = FlatStyle.Flat;
            addNewAuthor.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            addNewAuthor.ForeColor = Color.White;
            addNewAuthor.Location = new Point(702, 414);
            addNewAuthor.Name = "addNewAuthor";
            addNewAuthor.Size = new Size(121, 32);
            addNewAuthor.TabIndex = 28;
            addNewAuthor.Text = "Add Author";
            addNewAuthor.UseVisualStyleBackColor = false;
            addNewAuthor.Click += button2_Click;
            // 
            // img
            // 
            img.Anchor = AnchorStyles.None;
            img.AutoSize = true;
            img.BackColor = Color.Transparent;
            img.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            img.ForeColor = Color.White;
            img.Location = new Point(721, 511);
            img.Name = "img";
            img.Size = new Size(0, 19);
            img.TabIndex = 29;
            // 
            // EditBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1154, 680);
            Controls.Add(img);
            Controls.Add(addNewAuthor);
            Controls.Add(addNewBranch);
            Controls.Add(browseImage);
            Controls.Add(label7);
            Controls.Add(authorBox);
            Controls.Add(label6);
            Controls.Add(branchBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(quantity);
            Controls.Add(descBox);
            Controls.Add(tittleBox);
            Controls.Add(Save);
            Controls.Add(label2);
            Controls.Add(book);
            Controls.Add(label1);
            Name = "EditBook";
            Text = "EditBook";
            Load += EditBook_Load;
            ((System.ComponentModel.ISupportInitialize)quantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox book;
        private Label label2;
        private Button Save;
        private TextBox tittleBox;
        private TextBox descBox;
        private NumericUpDown quantity;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox branchBox;
        private Label label6;
        private ComboBox authorBox;
        private Label label7;
        private Button browseImage;
        private Button addNewBranch;
        private Button addNewAuthor;
        private Label img;
    }
}