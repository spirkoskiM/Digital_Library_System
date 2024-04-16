namespace Forms
{
    partial class ViewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBook));
            label1 = new Label();
            selectbranch = new ComboBox();
            label2 = new Label();
            displaybookstable = new DataGridView();
            viewbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)displaybookstable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(405, 25);
            label1.Name = "label1";
            label1.Size = new Size(243, 51);
            label1.TabIndex = 0;
            label1.Text = "View Book";
            // 
            // selectbranch
            // 
            selectbranch.Anchor = AnchorStyles.None;
            selectbranch.DropDownStyle = ComboBoxStyle.DropDownList;
            selectbranch.FlatStyle = FlatStyle.Flat;
            selectbranch.FormattingEnabled = true;
            selectbranch.Location = new Point(12, 207);
            selectbranch.Name = "selectbranch";
            selectbranch.Size = new Size(220, 28);
            selectbranch.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 185);
            label2.Name = "label2";
            label2.Size = new Size(119, 19);
            label2.TabIndex = 2;
            label2.Text = "Select Branch";
            // 
            // displaybookstable
            // 
            displaybookstable.Anchor = AnchorStyles.None;
            displaybookstable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            displaybookstable.BackgroundColor = Color.White;
            displaybookstable.BorderStyle = BorderStyle.None;
            displaybookstable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            displaybookstable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            displaybookstable.GridColor = SystemColors.ActiveCaptionText;
            displaybookstable.Location = new Point(12, 257);
            displaybookstable.Name = "displaybookstable";
            displaybookstable.ReadOnly = true;
            displaybookstable.RowHeadersWidth = 51;
            displaybookstable.RowTemplate.Height = 29;
            displaybookstable.Size = new Size(1056, 349);
            displaybookstable.TabIndex = 3;
            // 
            // viewbutton
            // 
            viewbutton.Anchor = AnchorStyles.None;
            viewbutton.BackColor = Color.Transparent;
            viewbutton.FlatAppearance.BorderColor = Color.White;
            viewbutton.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            viewbutton.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            viewbutton.FlatStyle = FlatStyle.Flat;
            viewbutton.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            viewbutton.ForeColor = Color.White;
            viewbutton.Location = new Point(264, 203);
            viewbutton.Name = "viewbutton";
            viewbutton.Size = new Size(88, 34);
            viewbutton.TabIndex = 4;
            viewbutton.Text = "View";
            viewbutton.UseVisualStyleBackColor = false;
            viewbutton.Click += viewbutton_Click;
            // 
            // ViewBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1082, 633);
            Controls.Add(viewbutton);
            Controls.Add(displaybookstable);
            Controls.Add(label2);
            Controls.Add(selectbranch);
            Controls.Add(label1);
            Name = "ViewBook";
            Text = "ViewBook";
            Load += ViewBook_Load;
            ((System.ComponentModel.ISupportInitialize)displaybookstable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox selectbranch;
        private Label label2;
        private DataGridView displaybookstable;
        private Button viewbutton;
    }
}