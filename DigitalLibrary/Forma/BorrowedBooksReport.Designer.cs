namespace Forms
{
    partial class BorrowedBooksReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowedBooksReport));
            dateFrom = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            searchButton = new Button();
            displayBooks = new DataGridView();
            label3 = new Label();
            byEmployee = new CheckBox();
            byDate = new CheckBox();
            EmployeeBox = new ComboBox();
            label4 = new Label();
            byBranch = new CheckBox();
            label5 = new Label();
            branchBox = new ComboBox();
            byBook = new CheckBox();
            label6 = new Label();
            booksBox = new ComboBox();
            dateTo = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)displayBooks).BeginInit();
            SuspendLayout();
            // 
            // dateFrom
            // 
            dateFrom.Anchor = AnchorStyles.None;
            dateFrom.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateFrom.Format = DateTimePickerFormat.Custom;
            dateFrom.Location = new Point(833, 216);
            dateFrom.Name = "dateFrom";
            dateFrom.Size = new Size(250, 28);
            dateFrom.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(833, 190);
            label1.Name = "label1";
            label1.Size = new Size(110, 23);
            label1.TabIndex = 2;
            label1.Text = "Date From:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(833, 265);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 3;
            label2.Text = "Date To:";
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.None;
            searchButton.BackColor = Color.Transparent;
            searchButton.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            searchButton.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(37, 575);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(110, 33);
            searchButton.TabIndex = 4;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // displayBooks
            // 
            displayBooks.Anchor = AnchorStyles.None;
            displayBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            displayBooks.BackgroundColor = Color.White;
            displayBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            displayBooks.Location = new Point(274, 330);
            displayBooks.Name = "displayBooks";
            displayBooks.ReadOnly = true;
            displayBooks.RowHeadersWidth = 51;
            displayBooks.RowTemplate.Height = 29;
            displayBooks.Size = new Size(905, 429);
            displayBooks.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(589, 9);
            label3.Name = "label3";
            label3.Size = new Size(313, 51);
            label3.TabIndex = 6;
            label3.Text = "Search Books";
            // 
            // byEmployee
            // 
            byEmployee.Anchor = AnchorStyles.None;
            byEmployee.AutoSize = true;
            byEmployee.BackColor = Color.Transparent;
            byEmployee.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            byEmployee.ForeColor = Color.White;
            byEmployee.Location = new Point(38, 331);
            byEmployee.Name = "byEmployee";
            byEmployee.Size = new Size(199, 25);
            byEmployee.TabIndex = 8;
            byEmployee.Text = "Search By Employee";
            byEmployee.UseVisualStyleBackColor = false;
            byEmployee.CheckedChanged += poEmployee_CheckedChanged;
            // 
            // byDate
            // 
            byDate.Anchor = AnchorStyles.None;
            byDate.AutoSize = true;
            byDate.BackColor = Color.Transparent;
            byDate.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            byDate.ForeColor = Color.White;
            byDate.Location = new Point(37, 514);
            byDate.Name = "byDate";
            byDate.Size = new Size(158, 25);
            byDate.TabIndex = 9;
            byDate.Text = "Search By Date";
            byDate.UseVisualStyleBackColor = false;
            byDate.CheckedChanged += byDate_CheckedChanged;
            // 
            // EmployeeBox
            // 
            EmployeeBox.Anchor = AnchorStyles.None;
            EmployeeBox.BackColor = Color.White;
            EmployeeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            EmployeeBox.FlatStyle = FlatStyle.Popup;
            EmployeeBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeBox.FormattingEnabled = true;
            EmployeeBox.Location = new Point(367, 136);
            EmployeeBox.Name = "EmployeeBox";
            EmployeeBox.Size = new Size(250, 27);
            EmployeeBox.TabIndex = 10;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(367, 110);
            label4.Name = "label4";
            label4.Size = new Size(103, 23);
            label4.TabIndex = 11;
            label4.Text = "Employee:";
            // 
            // byBranch
            // 
            byBranch.Anchor = AnchorStyles.None;
            byBranch.AutoSize = true;
            byBranch.BackColor = Color.Transparent;
            byBranch.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            byBranch.ForeColor = Color.White;
            byBranch.Location = new Point(38, 388);
            byBranch.Name = "byBranch";
            byBranch.Size = new Size(177, 25);
            byBranch.TabIndex = 12;
            byBranch.Text = "Search By Branch";
            byBranch.UseVisualStyleBackColor = false;
            byBranch.CheckedChanged += byBranch_CheckedChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(367, 190);
            label5.Name = "label5";
            label5.Size = new Size(77, 23);
            label5.TabIndex = 14;
            label5.Text = "Branch:";
            // 
            // branchBox
            // 
            branchBox.Anchor = AnchorStyles.None;
            branchBox.BackColor = Color.White;
            branchBox.DropDownStyle = ComboBoxStyle.DropDownList;
            branchBox.FlatStyle = FlatStyle.Popup;
            branchBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            branchBox.FormattingEnabled = true;
            branchBox.Location = new Point(367, 216);
            branchBox.Name = "branchBox";
            branchBox.Size = new Size(250, 27);
            branchBox.TabIndex = 13;
            // 
            // byBook
            // 
            byBook.Anchor = AnchorStyles.None;
            byBook.AutoSize = true;
            byBook.BackColor = Color.Transparent;
            byBook.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            byBook.ForeColor = Color.White;
            byBook.Location = new Point(37, 452);
            byBook.Name = "byBook";
            byBook.Size = new Size(161, 25);
            byBook.TabIndex = 15;
            byBook.Text = "Search By Book";
            byBook.UseVisualStyleBackColor = false;
            byBook.CheckedChanged += byBook_CheckedChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(367, 265);
            label6.Name = "label6";
            label6.Size = new Size(61, 23);
            label6.TabIndex = 18;
            label6.Text = "Book:";
            // 
            // booksBox
            // 
            booksBox.Anchor = AnchorStyles.None;
            booksBox.BackColor = Color.White;
            booksBox.DropDownStyle = ComboBoxStyle.DropDownList;
            booksBox.FlatStyle = FlatStyle.Popup;
            booksBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            booksBox.FormattingEnabled = true;
            booksBox.Location = new Point(367, 291);
            booksBox.Name = "booksBox";
            booksBox.Size = new Size(250, 27);
            booksBox.TabIndex = 17;
            // 
            // dateTo
            // 
            dateTo.Anchor = AnchorStyles.None;
            dateTo.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTo.Format = DateTimePickerFormat.Custom;
            dateTo.Location = new Point(833, 291);
            dateTo.Name = "dateTo";
            dateTo.Size = new Size(250, 28);
            dateTo.TabIndex = 1;
            // 
            // BorrowedBooksReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1191, 771);
            Controls.Add(label6);
            Controls.Add(booksBox);
            Controls.Add(byBook);
            Controls.Add(label5);
            Controls.Add(branchBox);
            Controls.Add(byBranch);
            Controls.Add(label4);
            Controls.Add(EmployeeBox);
            Controls.Add(byDate);
            Controls.Add(byEmployee);
            Controls.Add(label3);
            Controls.Add(displayBooks);
            Controls.Add(searchButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTo);
            Controls.Add(dateFrom);
            Name = "BorrowedBooksReport";
            Text = "BorrowedBooksReport";
            Load += BorrowedBooksReport_Load;
            ((System.ComponentModel.ISupportInitialize)displayBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateFrom;
        private Label label1;
        private Label label2;
        private Button searchButton;
        private DataGridView displayBooks;
        private Label label3;
        private CheckBox byEmployee;
        private CheckBox byDate;
        private ComboBox EmployeeBox;
        private Label label4;
        private CheckBox byBranch;
        private Label label5;
        private ComboBox branchBox;
        private CheckBox byBook;
        private Label label6;
        private ComboBox booksBox;
        private DateTimePicker dateTo;
    }
}