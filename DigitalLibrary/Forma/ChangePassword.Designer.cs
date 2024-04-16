namespace Forms
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            label1 = new Label();
            newpass = new TextBox();
            confirmpass = new TextBox();
            label2 = new Label();
            label3 = new Label();
            savebtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(307, 36);
            label1.Name = "label1";
            label1.Size = new Size(400, 51);
            label1.TabIndex = 2;
            label1.Text = "Change password";
            // 
            // newpass
            // 
            newpass.Anchor = AnchorStyles.None;
            newpass.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            newpass.Location = new Point(307, 230);
            newpass.Name = "newpass";
            newpass.Size = new Size(400, 34);
            newpass.TabIndex = 3;
            newpass.UseSystemPasswordChar = true;
            // 
            // confirmpass
            // 
            confirmpass.Anchor = AnchorStyles.None;
            confirmpass.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            confirmpass.Location = new Point(307, 337);
            confirmpass.Name = "confirmpass";
            confirmpass.Size = new Size(400, 34);
            confirmpass.TabIndex = 4;
            confirmpass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(307, 204);
            label2.Name = "label2";
            label2.Size = new Size(141, 23);
            label2.TabIndex = 5;
            label2.Text = "New password";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(307, 311);
            label3.Name = "label3";
            label3.Size = new Size(170, 23);
            label3.TabIndex = 6;
            label3.Text = "Confirm password";
            // 
            // savebtn
            // 
            savebtn.Anchor = AnchorStyles.None;
            savebtn.BackColor = Color.Transparent;
            savebtn.FlatAppearance.BorderColor = Color.White;
            savebtn.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            savebtn.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            savebtn.FlatStyle = FlatStyle.Flat;
            savebtn.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            savebtn.ForeColor = Color.White;
            savebtn.Location = new Point(307, 417);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(400, 41);
            savebtn.TabIndex = 7;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = false;
            savebtn.Click += savebtn_Click;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1048, 574);
            Controls.Add(savebtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(confirmpass);
            Controls.Add(newpass);
            Controls.Add(label1);
            Name = "ChangePassword";
            Text = "ChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox newpass;
        private TextBox confirmpass;
        private Label label2;
        private Label label3;
        private Button savebtn;
    }
}