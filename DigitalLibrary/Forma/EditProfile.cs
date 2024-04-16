using DigitalLibrary;
using Forma;

namespace Forms
{
    public partial class EditProfile : Form
    {
        public EditProfile()
        {
            InitializeComponent();
        }
        private void EditProfile_Load(object sender, EventArgs e)
        {
            try
            {
                editname.Text = Program.LogedEmployee.Name;
                birthPicker.Text = Program.LogedEmployee.Birthday;
                editcity.Text = Program.LogedEmployee.City;
                editaddress.Text = Program.LogedEmployee.Address;
                editmobile.Text = Program.LogedEmployee.Mobile;
                editemail.Text = Program.LogedEmployee.Email;

                var branches = Program.DbWriterReader.ReadAllBranches();

                foreach (var branch in branches)
                {
                    editbranch.Items.Add(branch);
                }

                editbranch.DisplayMember = nameof(Branch.BranchName);
                editbranch.ValueMember = nameof(Branch.Id);

                if (editbranch.Items.Count > 0)
                {
                    editbranch.SelectedItem = Program.LogedEmployee.branch; //ovde e problemo
                }
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }
        }
        private void savechanges_Click(object sender, EventArgs e)
        {
            try
            {
                var UpdateEmployee = Program.LogedEmployee;

                UpdateEmployee.Name = editname.Text;
                UpdateEmployee.Email = editemail.Text;
                UpdateEmployee.City = editcity.Text;
                UpdateEmployee.Birthday = birthPicker.Text;
                UpdateEmployee.Address = editaddress.Text;
                UpdateEmployee.Mobile = editmobile.Text;

                var selectedbranch = editbranch.SelectedItem as Branch;
                UpdateEmployee.branchID = selectedbranch.Id;
                UpdateEmployee.branch = selectedbranch;

                Program.DbWriterReader.UpdateEmployeeInfo(UpdateEmployee);

                MessageBox.Show("Successfully updated !");
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }
        }
    }
}
