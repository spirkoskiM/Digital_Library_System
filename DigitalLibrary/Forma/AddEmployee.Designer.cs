namespace Forms
{
    partial class AddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            label1 = new Label();
            emplName = new TextBox();
            city = new TextBox();
            address = new TextBox();
            mobile = new TextBox();
            email = new TextBox();
            password = new TextBox();
            name = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            genderbox = new ComboBox();
            label8 = new Label();
            branchesbox = new ComboBox();
            label9 = new Label();
            button1 = new Button();
            birthdayPicker = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(296, 36);
            label1.Name = "label1";
            label1.Size = new Size(429, 51);
            label1.TabIndex = 0;
            label1.Text = "Add New Employee";
            // 
            // emplName
            // 
            emplName.Anchor = AnchorStyles.None;
            emplName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emplName.Location = new Point(56, 268);
            emplName.Name = "emplName";
            emplName.Size = new Size(267, 30);
            emplName.TabIndex = 1;
            // 
            // city
            // 
            city.Anchor = AnchorStyles.None;
            city.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            city.Location = new Point(56, 353);
            city.Name = "city";
            city.Size = new Size(267, 30);
            city.TabIndex = 2;
            // 
            // address
            // 
            address.Anchor = AnchorStyles.None;
            address.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            address.Location = new Point(56, 441);
            address.Name = "address";
            address.Size = new Size(267, 30);
            address.TabIndex = 3;
            // 
            // mobile
            // 
            mobile.Anchor = AnchorStyles.None;
            mobile.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mobile.Location = new Point(56, 614);
            mobile.Name = "mobile";
            mobile.Size = new Size(267, 30);
            mobile.TabIndex = 5;
            // 
            // email
            // 
            email.Anchor = AnchorStyles.None;
            email.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(713, 268);
            email.Name = "email";
            email.Size = new Size(267, 30);
            email.TabIndex = 6;
            // 
            // password
            // 
            password.Anchor = AnchorStyles.None;
            password.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(713, 353);
            password.Name = "password";
            password.Size = new Size(267, 30);
            password.TabIndex = 7;
            password.UseSystemPasswordChar = true;
            // 
            // name
            // 
            name.Anchor = AnchorStyles.None;
            name.AutoSize = true;
            name.BackColor = Color.Transparent;
            name.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            name.ForeColor = Color.White;
            name.Location = new Point(56, 242);
            name.Name = "name";
            name.Size = new Size(97, 23);
            name.TabIndex = 8;
            name.Text = "Full Name";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(57, 501);
            label2.Name = "label2";
            label2.Size = new Size(82, 23);
            label2.TabIndex = 9;
            label2.Text = "Birthday";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(57, 588);
            label3.Name = "label3";
            label3.Size = new Size(68, 23);
            label3.TabIndex = 10;
            label3.Text = "Mobile";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(56, 327);
            label4.Name = "label4";
            label4.Size = new Size(44, 23);
            label4.TabIndex = 11;
            label4.Text = "City";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(56, 415);
            label5.Name = "label5";
            label5.Size = new Size(83, 23);
            label5.TabIndex = 12;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(713, 242);
            label6.Name = "label6";
            label6.Size = new Size(58, 23);
            label6.TabIndex = 13;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(713, 327);
            label7.Name = "label7";
            label7.Size = new Size(98, 23);
            label7.TabIndex = 14;
            label7.Text = "Password";
            // 
            // genderbox
            // 
            genderbox.Anchor = AnchorStyles.None;
            genderbox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderbox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            genderbox.FormattingEnabled = true;
            genderbox.Location = new Point(864, 441);
            genderbox.Name = "genderbox";
            genderbox.Size = new Size(116, 31);
            genderbox.TabIndex = 15;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(859, 415);
            label8.Name = "label8";
            label8.Size = new Size(76, 23);
            label8.TabIndex = 16;
            label8.Text = "Gender";
            // 
            // branchesbox
            // 
            branchesbox.Anchor = AnchorStyles.None;
            branchesbox.DropDownStyle = ComboBoxStyle.DropDownList;
            branchesbox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            branchesbox.FormattingEnabled = true;
            branchesbox.Location = new Point(864, 526);
            branchesbox.Name = "branchesbox";
            branchesbox.Size = new Size(116, 31);
            branchesbox.TabIndex = 17;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(859, 500);
            label9.Name = "label9";
            label9.Size = new Size(71, 23);
            label9.TabIndex = 18;
            label9.Text = "Branch";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            button1.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(432, 660);
            button1.Name = "button1";
            button1.Size = new Size(177, 49);
            button1.TabIndex = 19;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // birthdayPicker
            // 
            birthdayPicker.Anchor = AnchorStyles.None;
            birthdayPicker.CalendarFont = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            birthdayPicker.CustomFormat = "MM/dd/yyyy";
            birthdayPicker.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            birthdayPicker.Format = DateTimePickerFormat.Custom;
            birthdayPicker.Location = new Point(57, 527);
            birthdayPicker.Name = "birthdayPicker";
            birthdayPicker.Size = new Size(267, 27);
            birthdayPicker.TabIndex = 21;
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1038, 721);
            Controls.Add(birthdayPicker);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(branchesbox);
            Controls.Add(label8);
            Controls.Add(genderbox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(name);
            Controls.Add(password);
            Controls.Add(email);
            Controls.Add(mobile);
            Controls.Add(address);
            Controls.Add(city);
            Controls.Add(emplName);
            Controls.Add(label1);
            Name = "AddEmployee";
            Text = "AddEmployee";
            Load += AddEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox emplName;
        private TextBox city;
        private TextBox address;
        private TextBox birthday;
        private TextBox mobile;
        private TextBox email;
        private TextBox password;
        private Label name;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox genderbox;
        private Label label8;
        private ComboBox branchesbox;
        private Label label9;
        private Button button1;
        private DateTimePicker birthdayPicker;
    }
}