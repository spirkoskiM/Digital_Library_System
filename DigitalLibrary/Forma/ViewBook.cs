using DigitalLibrary;
using Forma;
using System.Windows.Forms;

namespace Forms
{
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }
        private void ViewBook_Load(object sender, EventArgs e)
        {
            try
            {
                var Branches = Program.DbWriterReader.ReadAllBranches();

                foreach (var Branch in Branches)
                {
                    selectbranch.Items.Add(Branch);
                }

                selectbranch.DisplayMember = nameof(Branch.BranchName);
                selectbranch.ValueMember = nameof(Branch.Id);

                if (selectbranch.Items.Count > 0)
                {
                    selectbranch.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }
        }
        private void DisplayBookTable()
        {
            try
            {
                var books = Program.DbWriterReader.ReadBooksInfo(selectbranch.SelectedIndex + 1);
                displaybookstable.DataSource = books;
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }
        }
        private void viewbutton_Click(object sender, EventArgs e)
        {
            DisplayBookTable();
        }
    }
}
