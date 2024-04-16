namespace Forms
{
    partial class EmployeeReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeReport));
            label1 = new Label();
            branchbox = new ComboBox();
            label2 = new Label();
            viewbutton = new Button();
            tableEmployee = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tableEmployee).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(344, 27);
            label1.Name = "label1";
            label1.Size = new Size(383, 51);
            label1.TabIndex = 0;
            label1.Text = "Employee Report";
            // 
            // branchbox
            // 
            branchbox.Anchor = AnchorStyles.None;
            branchbox.DropDownStyle = ComboBoxStyle.DropDownList;
            branchbox.FlatStyle = FlatStyle.Flat;
            branchbox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            branchbox.FormattingEnabled = true;
            branchbox.Location = new Point(14, 135);
            branchbox.Name = "branchbox";
            branchbox.Size = new Size(254, 31);
            branchbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 114);
            label2.Name = "label2";
            label2.Size = new Size(119, 19);
            label2.TabIndex = 2;
            label2.Text = "Select Branch";
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
            viewbutton.Location = new Point(297, 133);
            viewbutton.Name = "viewbutton";
            viewbutton.Size = new Size(89, 36);
            viewbutton.TabIndex = 3;
            viewbutton.Text = "View";
            viewbutton.UseVisualStyleBackColor = false;
            viewbutton.Click += viewbutton_Click;
            // 
            // tableEmployee
            // 
            tableEmployee.Anchor = AnchorStyles.None;
            tableEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableEmployee.BackgroundColor = Color.White;
            tableEmployee.BorderStyle = BorderStyle.None;
            tableEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableEmployee.Location = new Point(16, 187);
            tableEmployee.Name = "tableEmployee";
            tableEmployee.ReadOnly = true;
            tableEmployee.RowHeadersWidth = 51;
            tableEmployee.RowTemplate.Height = 29;
            tableEmployee.Size = new Size(1037, 365);
            tableEmployee.TabIndex = 4;
            // 
            // EmployeeReport
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1071, 564);
            Controls.Add(tableEmployee);
            Controls.Add(viewbutton);
            Controls.Add(label2);
            Controls.Add(branchbox);
            Controls.Add(label1);
            Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "EmployeeReport";
            Text = "EmployeeReport";
            Load += EmployeeReport_Load;
            ((System.ComponentModel.ISupportInitialize)tableEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox branchbox;
        private Label label2;
        private Button viewbutton;
        private DataGridView tableEmployee;
    }
}