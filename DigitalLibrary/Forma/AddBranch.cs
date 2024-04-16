using DigitalLibrary;
using Forma;


namespace Forms
{
    public partial class AddBranch : Form
    {
        public AddBranch()
        {
            InitializeComponent();
        }
        private void branchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = branchName.Text;
                Branch branch = new Branch();
                branch.BranchName = name;

                if (branchName.Text.Length > 0)
                {
                    if (!Program.DbWriterReader.CheckIfBranchExist(name))
                    {
                        Program.DbWriterReader.AddNewBranch(branch);
                        MessageBox.Show("Succesfully Added");

                        branchName.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Branch Already Exist !");
                    }
                }
                else
                {
                    MessageBox.Show("Fill Branch Name");
                }
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }
        }
    }
}
