namespace Forms
{
    partial class ViewBookEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBookEmp));
            label1 = new Label();
            displayBooks = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)displayBooks).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(378, 22);
            label1.Name = "label1";
            label1.Size = new Size(286, 51);
            label1.TabIndex = 1;
            label1.Text = "Book Report";
            // 
            // displayBooks
            // 
            displayBooks.Anchor = AnchorStyles.None;
            displayBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            displayBooks.BackgroundColor = Color.White;
            displayBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            displayBooks.Location = new Point(174, 154);
            displayBooks.Name = "displayBooks";
            displayBooks.ReadOnly = true;
            displayBooks.RowHeadersWidth = 51;
            displayBooks.RowTemplate.Height = 29;
            displayBooks.Size = new Size(699, 429);
            displayBooks.TabIndex = 2;
            // 
            // ViewBookEmp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1047, 631);
            Controls.Add(displayBooks);
            Controls.Add(label1);
            Name = "ViewBookEmp";
            Text = "ViewBookEmp";
            Load += ViewBookEmp_Load;
            ((System.ComponentModel.ISupportInitialize)displayBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView displayBooks;
    }
}