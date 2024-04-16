namespace Forms
{
    partial class AddAuthor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAuthor));
            title = new Label();
            submit = new Button();
            subtitle = new Label();
            authname = new TextBox();
            SuspendLayout();
            // 
            // title
            // 
            title.Anchor = AnchorStyles.None;
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            title.ForeColor = Color.White;
            title.Location = new Point(266, 37);
            title.Name = "title";
            title.Size = new Size(364, 51);
            title.TabIndex = 24;
            title.Text = "Add New Author";
            // 
            // submit
            // 
            submit.Anchor = AnchorStyles.None;
            submit.BackColor = Color.Transparent;
            submit.FlatAppearance.BorderColor = Color.White;
            submit.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            submit.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            submit.FlatStyle = FlatStyle.Flat;
            submit.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            submit.ForeColor = Color.White;
            submit.Location = new Point(324, 335);
            submit.Name = "submit";
            submit.Size = new Size(244, 33);
            submit.TabIndex = 27;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = false;
            submit.Click += submit_Click;
            // 
            // subtitle
            // 
            subtitle.Anchor = AnchorStyles.None;
            subtitle.AutoSize = true;
            subtitle.BackColor = Color.Transparent;
            subtitle.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            subtitle.ForeColor = Color.White;
            subtitle.Location = new Point(324, 243);
            subtitle.Name = "subtitle";
            subtitle.Size = new Size(132, 21);
            subtitle.TabIndex = 26;
            subtitle.Text = "Author Name:";
            // 
            // authname
            // 
            authname.Anchor = AnchorStyles.None;
            authname.BorderStyle = BorderStyle.None;
            authname.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            authname.Location = new Point(324, 270);
            authname.Name = "authname";
            authname.Size = new Size(244, 27);
            authname.TabIndex = 25;
            // 
            // AddAuthor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(898, 488);
            Controls.Add(submit);
            Controls.Add(subtitle);
            Controls.Add(authname);
            Controls.Add(title);
            Name = "AddAuthor";
            Text = "AddAuthor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label title;
        private Button submit;
        private Label subtitle;
        private TextBox authname;
    }
}