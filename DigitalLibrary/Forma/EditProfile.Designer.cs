namespace Forms
{
    partial class EditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfile));
            label1 = new Label();
            displayUserInfo = new Panel();
            birthPicker = new DateTimePicker();
            savechanges = new Button();
            editbranch = new ComboBox();
            editemail = new TextBox();
            editaddress = new TextBox();
            editcity = new TextBox();
            editmobile = new TextBox();
            editname = new TextBox();
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
            label1.Location = new Point(338, 25);
            label1.Name = "label1";
            label1.Size = new Size(358, 51);
            label1.TabIndex = 1;
            label1.Text = "Edit your profile";
            // 
            // displayUserInfo
            // 
            displayUserInfo.Anchor = AnchorStyles.None;
            displayUserInfo.BackColor = Color.White;
            displayUserInfo.Controls.Add(birthPicker);
            displayUserInfo.Controls.Add(savechanges);
            displayUserInfo.Controls.Add(editbranch);
            displayUserInfo.Controls.Add(editemail);
            displayUserInfo.Controls.Add(editaddress);
            displayUserInfo.Controls.Add(editcity);
            displayUserInfo.Controls.Add(editmobile);
            displayUserInfo.Controls.Add(editname);
            displayUserInfo.Controls.Add(label7);
            displayUserInfo.Controls.Add(label8);
            displayUserInfo.Controls.Add(label9);
            displayUserInfo.Controls.Add(label4);
            displayUserInfo.Controls.Add(label5);
            displayUserInfo.Controls.Add(label3);
            displayUserInfo.Controls.Add(label2);
            displayUserInfo.Location = new Point(100, 145);
            displayUserInfo.Name = "displayUserInfo";
            displayUserInfo.Size = new Size(842, 403);
            displayUserInfo.TabIndex = 3;
            // 
            // birthPicker
            // 
            birthPicker.CustomFormat = "MM/dd/yyyy";
            birthPicker.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            birthPicker.Format = DateTimePickerFormat.Custom;
            birthPicker.Location = new Point(235, 145);
            birthPicker.Name = "birthPicker";
            birthPicker.Size = new Size(143, 27);
            birthPicker.TabIndex = 26;
            // 
            // savechanges
            // 
            savechanges.BackColor = Color.SteelBlue;
            savechanges.FlatAppearance.BorderColor = Color.SteelBlue;
            savechanges.FlatAppearance.BorderSize = 0;
            savechanges.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            savechanges.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            savechanges.FlatStyle = FlatStyle.Flat;
            savechanges.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            savechanges.ForeColor = Color.White;
            savechanges.Location = new Point(666, 337);
            savechanges.Name = "savechanges";
            savechanges.Size = new Size(141, 41);
            savechanges.TabIndex = 25;
            savechanges.Text = "Save ";
            savechanges.UseVisualStyleBackColor = false;
            savechanges.Click += savechanges_Click;
            // 
            // editbranch
            // 
            editbranch.DropDownStyle = ComboBoxStyle.DropDownList;
            editbranch.FormattingEnabled = true;
            editbranch.Location = new Point(567, 206);
            editbranch.Name = "editbranch";
            editbranch.Size = new Size(137, 28);
            editbranch.TabIndex = 24;
            // 
            // editemail
            // 
            editemail.Location = new Point(554, 145);
            editemail.Name = "editemail";
            editemail.Size = new Size(128, 27);
            editemail.TabIndex = 21;
            // 
            // editaddress
            // 
            editaddress.Location = new Point(579, 88);
            editaddress.Name = "editaddress";
            editaddress.Size = new Size(128, 27);
            editaddress.TabIndex = 20;
            // 
            // editcity
            // 
            editcity.Location = new Point(188, 272);
            editcity.Name = "editcity";
            editcity.Size = new Size(128, 27);
            editcity.TabIndex = 19;
            // 
            // editmobile
            // 
            editmobile.Location = new Point(212, 207);
            editmobile.Name = "editmobile";
            editmobile.Size = new Size(128, 27);
            editmobile.TabIndex = 18;
            // 
            // editname
            // 
            editname.Location = new Point(205, 88);
            editname.Name = "editname";
            editname.Size = new Size(128, 27);
            editname.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(484, 207);
            label7.Name = "label7";
            label7.Size = new Size(85, 24);
            label7.TabIndex = 6;
            label7.Text = "Branch:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(484, 145);
            label8.Name = "label8";
            label8.Size = new Size(68, 24);
            label8.TabIndex = 5;
            label8.Text = "Email:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(484, 88);
            label9.Name = "label9";
            label9.Size = new Size(95, 24);
            label9.TabIndex = 4;
            label9.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(132, 272);
            label4.Name = "label4";
            label4.Size = new Size(54, 24);
            label4.TabIndex = 3;
            label4.Text = "City:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(132, 207);
            label5.Name = "label5";
            label5.Size = new Size(79, 24);
            label5.TabIndex = 2;
            label5.Text = "Mobile:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(132, 145);
            label3.Name = "label3";
            label3.Size = new Size(97, 24);
            label3.TabIndex = 1;
            label3.Text = "Birthday:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(132, 88);
            label2.Name = "label2";
            label2.Size = new Size(70, 24);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1051, 646);
            Controls.Add(displayUserInfo);
            Controls.Add(label1);
            Name = "EditProfile";
            Text = "EditProfile";
            Load += EditProfile_Load;
            displayUserInfo.ResumeLayout(false);
            displayUserInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel displayUserInfo;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox editcity;
        private TextBox editmobile;
        private TextBox editname;
        private TextBox editemail;
        private TextBox editaddress;
        private ComboBox editbranch;
        private Button savechanges;
        private DateTimePicker birthPicker;
    }
}