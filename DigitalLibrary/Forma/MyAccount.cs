using DigitalLibrary.Services;
using Forma;


namespace Forms
{
    public partial class MyAccount : Form
    {
        public MyAccount()
        {
            InitializeComponent();
        }
        private void MyAccount_Load(object sender, EventArgs e)
        {
            try
            {
                var loggedUser = Program.LogedEmployee;

                name.Text = loggedUser.Name;
                birth.Text = loggedUser.Birthday;
                mobile.Text = loggedUser.Mobile;
                city.Text = loggedUser.City;
                address.Text = loggedUser.Address;
                email.Text = loggedUser.Email;
                branch.Text = loggedUser.BranchName;
                bookstoreturn.Text = loggedUser.BooksToReturn.ToString();
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }
        }
        private void editbutton_Click(object sender, EventArgs e)
        {
            try
            {
                EditProfile editProfile = new EditProfile();

                if (editProfile.ShowDialog() == DialogResult.Cancel)
                {
                    var loggedUser = Program.LogedEmployee;

                    name.Text = loggedUser.Name;
                    birth.Text = loggedUser.Birthday;
                    mobile.Text = loggedUser.Mobile;
                    city.Text = loggedUser.City;
                    address.Text = loggedUser.Address;
                    email.Text = loggedUser.Email;
                    branch.Text = loggedUser.BranchName;
                    bookstoreturn.Text = loggedUser.BooksToReturn.ToString();
                }
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }
        }
        private void changebutton_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.ShowDialog();
        }
    }
}
