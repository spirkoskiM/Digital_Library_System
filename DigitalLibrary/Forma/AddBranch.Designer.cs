namespace Forms
{
    partial class AddBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBranch));
            title = new Label();
            branchName = new TextBox();
            subtitle = new Label();
            branchButton = new Button();
            SuspendLayout();
            // 
            // title
            // 
            title.Anchor = AnchorStyles.None;
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            title.ForeColor = Color.White;
            title.Location = new Point(226, 31);
            title.Name = "title";
            title.Size = new Size(373, 51);
            title.TabIndex = 0;
            title.Text = "Add New Branch";
            // 
            // branchName
            // 
            branchName.Anchor = AnchorStyles.None;
            branchName.BorderStyle = BorderStyle.None;
            branchName.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            branchName.Location = new Point(283, 243);
            branchName.Name = "branchName";
            branchName.Size = new Size(244, 27);
            branchName.TabIndex = 1;
            // 
            // subtitle
            // 
            subtitle.Anchor = AnchorStyles.None;
            subtitle.AutoSize = true;
            subtitle.BackColor = Color.Transparent;
            subtitle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            subtitle.ForeColor = Color.White;
            subtitle.Location = new Point(283, 216);
            subtitle.Name = "subtitle";
            subtitle.Size = new Size(137, 24);
            subtitle.TabIndex = 2;
            subtitle.Text = "Branch Name";
            // 
            // branchButton
            // 
            branchButton.Anchor = AnchorStyles.None;
            branchButton.BackColor = Color.Transparent;
            branchButton.FlatAppearance.BorderColor = Color.White;
            branchButton.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            branchButton.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            branchButton.FlatStyle = FlatStyle.Flat;
            branchButton.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            branchButton.ForeColor = Color.White;
            branchButton.Location = new Point(283, 308);
            branchButton.Name = "branchButton";
            branchButton.Size = new Size(244, 33);
            branchButton.TabIndex = 3;
            branchButton.Text = "Submit";
            branchButton.UseVisualStyleBackColor = false;
            branchButton.Click += branchButton_Click;
            // 
            // AddBranch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(832, 435);
            Controls.Add(branchButton);
            Controls.Add(subtitle);
            Controls.Add(branchName);
            Controls.Add(title);
            Name = "AddBranch";
            Text = "AddBranch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private TextBox branchName;
        private Label subtitle;
        private Button branchButton;
    }
}