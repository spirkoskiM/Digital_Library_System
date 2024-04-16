namespace Forms
{
    partial class MyAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyAccount));
            label1 = new Label();
            displayUserInfo = new Panel();
            changebutton = new Button();
            bookstoreturn = new Label();
            editbutton = new Button();
            branch = new Label();
            email = new Label();
            address = new Label();
            city = new Label();
            mobile = new Label();
            birth = new Label();
            name = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            displayUserInfo.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(464, 9);
            label1.Name = "label1";
            label1.Size = new Size(158, 51);
            label1.TabIndex = 0;
            label1.Text = "Profile";
            // 
            // displayUserInfo
            // 
            displayUserInfo.Anchor = AnchorStyles.None;
            displayUserInfo.BackColor = Color.White;
            displayUserInfo.Controls.Add(changebutton);
            displayUserInfo.Controls.Add(bookstoreturn);
            displayUserInfo.Controls.Add(editbutton);
            displayUserInfo.Controls.Add(branch);
            displayUserInfo.Controls.Add(email);
            displayUserInfo.Controls.Add(address);
            displayUserInfo.Controls.Add(city);
            displayUserInfo.Controls.Add(mobile);
            displayUserInfo.Controls.Add(birth);
            displayUserInfo.Controls.Add(name);
            displayUserInfo.Controls.Add(label6);
            displayUserInfo.Controls.Add(label7);
            displayUserInfo.Controls.Add(label8);
            displayUserInfo.Controls.Add(label9);
            displayUserInfo.Controls.Add(label4);
            displayUserInfo.Controls.Add(label5);
            displayUserInfo.Controls.Add(label3);
            displayUserInfo.Controls.Add(label2);
            displayUserInfo.Location = new Point(128, 124);
            displayUserInfo.Name = "displayUserInfo";
            displayUserInfo.Size = new Size(842, 403);
            displayUserInfo.TabIndex = 2;
            // 
            // changebutton
            // 
            changebutton.BackColor = Color.SteelBlue;
            changebutton.FlatAppearance.BorderColor = Color.SteelBlue;
            changebutton.FlatAppearance.BorderSize = 0;
            changebutton.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            changebutton.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            changebutton.FlatStyle = FlatStyle.Flat;
            changebutton.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            changebutton.ForeColor = Color.White;
            changebutton.Location = new Point(447, 37);
            changebutton.Name = "changebutton";
            changebutton.Size = new Size(177, 45);
            changebutton.TabIndex = 4;
            changebutton.Text = "Change Password";
            changebutton.UseVisualStyleBackColor = false;
            changebutton.Click += changebutton_Click;
            // 
            // bookstoreturn
            // 
            bookstoreturn.AutoSize = true;
            bookstoreturn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bookstoreturn.Location = new Point(641, 292);
            bookstoreturn.Name = "bookstoreturn";
            bookstoreturn.Size = new Size(0, 23);
            bookstoreturn.TabIndex = 15;
            // 
            // editbutton
            // 
            editbutton.BackColor = Color.SteelBlue;
            editbutton.FlatAppearance.BorderColor = Color.SteelBlue;
            editbutton.FlatAppearance.BorderSize = 0;
            editbutton.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            editbutton.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            editbutton.FlatStyle = FlatStyle.Flat;
            editbutton.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            editbutton.ForeColor = Color.White;
            editbutton.Location = new Point(226, 37);
            editbutton.Name = "editbutton";
            editbutton.Size = new Size(177, 45);
            editbutton.TabIndex = 3;
            editbutton.Text = "Edit Account";
            editbutton.UseVisualStyleBackColor = false;
            editbutton.Click += editbutton_Click;
            // 
            // branch
            // 
            branch.AutoSize = true;
            branch.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            branch.Location = new Point(567, 239);
            branch.Name = "branch";
            branch.Size = new Size(0, 23);
            branch.TabIndex = 14;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(554, 186);
            email.Name = "email";
            email.Size = new Size(0, 23);
            email.TabIndex = 13;
            // 
            // address
            // 
            address.AutoSize = true;
            address.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            address.Location = new Point(579, 133);
            address.Name = "address";
            address.Size = new Size(0, 23);
            address.TabIndex = 12;
            // 
            // city
            // 
            city.AutoSize = true;
            city.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            city.Location = new Point(145, 293);
            city.Name = "city";
            city.Size = new Size(0, 23);
            city.TabIndex = 11;
            // 
            // mobile
            // 
            mobile.AutoSize = true;
            mobile.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mobile.Location = new Point(169, 240);
            mobile.Name = "mobile";
            mobile.Size = new Size(0, 23);
            mobile.TabIndex = 10;
            // 
            // birth
            // 
            birth.AutoSize = true;
            birth.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            birth.Location = new Point(183, 187);
            birth.Name = "birth";
            birth.Size = new Size(0, 23);
            birth.TabIndex = 9;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(162, 134);
            name.Name = "name";
            name.Size = new Size(0, 23);
            name.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(484, 292);
            label6.Name = "label6";
            label6.Size = new Size(166, 24);
            label6.TabIndex = 7;
            label6.Text = "Books to return:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(484, 239);
            label7.Name = "label7";
            label7.Size = new Size(85, 24);
            label7.TabIndex = 6;
            label7.Text = "Branch:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(484, 186);
            label8.Name = "label8";
            label8.Size = new Size(68, 24);
            label8.TabIndex = 5;
            label8.Text = "Email:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(484, 133);
            label9.Name = "label9";
            label9.Size = new Size(95, 24);
            label9.TabIndex = 4;
            label9.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(89, 293);
            label4.Name = "label4";
            label4.Size = new Size(54, 24);
            label4.TabIndex = 3;
            label4.Text = "City:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(89, 240);
            label5.Name = "label5";
            label5.Size = new Size(79, 24);
            label5.TabIndex = 2;
            label5.Text = "Mobile:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(89, 187);
            label3.Name = "label3";
            label3.Size = new Size(97, 24);
            label3.TabIndex = 1;
            label3.Text = "Birthday:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(89, 134);
            label2.Name = "label2";
            label2.Size = new Size(70, 24);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            // 
            // MyAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1097, 625);
            Controls.Add(displayUserInfo);
            Controls.Add(label1);
            Name = "MyAccount";
            Text = "MyAccount";
            Load += MyAccount_Load;
            displayUserInfo.ResumeLayout(false);
            displayUserInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel displayUserInfo;
        private Button editbutton;
        private Button changebutton;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label bookstoreturn;
        private Label branch;
        private Label email;
        private Label address;
        private Label city;
        private Label mobile;
        private Label birth;
        private Label name;
    }
}