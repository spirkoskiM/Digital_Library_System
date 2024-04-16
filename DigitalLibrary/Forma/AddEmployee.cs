using DigitalLibrary;
using DigitalLibrary.Services;
using Forma;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Forms
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }
        public void addEmployeeToDatabase()
        {
            string name = emplName.Text;
            string city1 = city.Text;
            string adres = address.Text;
            string birthd = birthdayPicker.Text;
            string number = mobile.Text;
            string mail = email.Text;
            string pass = password.Text;

            if (name.Length > 0 && city1.Length > 0 && adres.Length > 0 && birthd.Length > 0 &&
                number.Length > 0 && mail.Length > 0 && pass.Length > 0 && Regex.IsMatch(number, "^[0-9]+$") == true)
            {
                Employee emp = new Employee();

                emp.Name = name;
                emp.City = city1;
                emp.Address = adres;
                emp.Birthday = birthd;
                emp.Mobile = number;
                emp.Email = mail;
                emp.Password = pass;
                emp.genderID = ((Gender)genderbox.SelectedItem).Id;
                emp.branchID = ((DigitalLibrary.Branch)branchesbox.SelectedItem).Id;
                emp.BooksToReturn = 0;

                if (!Program.DbWriterReader.CheckIfEmplyeeExist(name))
                {
                    Program.DbWriterReader.AddNewEmployee(emp);
                    MessageBox.Show("Successfully added Employee");
                }
                else
                {
                    MessageBox.Show("Employee already exist !");
                }
            }
            else
            {
                MessageBox.Show("Fill correctly all fields");
            }
        }
        private void button1_Click(object sender, EventArgs emp)
        {
            try
            {
                addEmployeeToDatabase();
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }

        }
        private void AddEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                var branches = Program.DbWriterReader.ReadAllBranches();

                foreach (var Branch in branches)
                {
                    branchesbox.Items.Add(Branch);
                }

                branchesbox.DisplayMember = nameof(DigitalLibrary.Branch.BranchName);
                branchesbox.ValueMember = nameof(DigitalLibrary.Branch.Id);

                if (branchesbox.Items.Count > 0)
                {
                    branchesbox.SelectedIndex = 0;
                }


                var genders = Program.DbWriterReader.ReadAllGenders();

                foreach (var gender in genders)
                {
                    genderbox.Items.Add(gender);
                }

                genderbox.DisplayMember = nameof(DigitalLibrary.Gender.GenderName);
                genderbox.ValueMember = nameof(DigitalLibrary.Gender.Id);

                if (genderbox.Items.Count > 0)
                {
                    genderbox.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }
        }
    }
}
