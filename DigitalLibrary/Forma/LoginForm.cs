using DigitalLibrary;
using DigitalLibrary.Services;
using Forms;

namespace Forma
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login()
        {
            try
            {
                string userName = username.Text;
                string pass = password.Text;

                if (userName.Length > 0 && pass.Length > 0)
                {

                    if (adminradio.Checked)
                    {
                        if (Program.DbWriterReader.CheckIfUserExist(userName, pass))
                        {
                            if (Program.DbWriterReader.CheckIsAdmin(userName) == 1)
                            {
                                Admin admin = new Admin();
                                admin.ShowDialog();

                                username.Text = string.Empty;
                                password.Text = string.Empty;
                            }
                            else
                            {
                                MessageBox.Show("There is no Admin with this Username");
                            }
                        }
                        else
                        {
                            MessageBox.Show("User does not exist");
                        }
                    }
                    else if (employeeradio.Checked)
                    {
                        if (Program.DbWriterReader.CheckIfEmployeeExist(userName, pass) != null)
                        {
                            Program.LogedEmployee = Program.DbWriterReader.CheckIfEmployeeExist(userName, pass);

                            Employe employee = new Employe();
                            employee.ShowDialog();

                            username.Text = string.Empty;
                            password.Text = string.Empty;

                        }
                        else
                        {
                            MessageBox.Show("Employee does not exist");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Choose Role");
                    }
                }
                else
                {
                    MessageBox.Show("Fill the fields");
                }
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void loginbtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
        }
    }
}