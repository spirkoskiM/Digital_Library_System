using DigitalLibrary;
using Forma;
using System.Data;
using System.Windows.Forms;

namespace Forms
{
    public partial class BorrowedBooksReport : Form
    {

        private List<BookEmployee> BookEmployees = new List<BookEmployee>();

        public BorrowedBooksReport()
        {
            InitializeComponent();

            dateFrom.Format = DateTimePickerFormat.Custom;
            dateTo.Format = DateTimePickerFormat.Custom;

            dateFrom.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTo.CustomFormat = "yyyy-MM-dd HH:mm:ss";

            dateFrom.Value = DateTime.Now;
            dateTo.Value = DateTime.Now;

            BookEmployees = Program.DbWriterReader.ReadAllBookEmployee();
        }

        private void BorrowedBooksReport_Load(object sender, EventArgs e)
        {
            var employees = Program.DbWriterReader.ReadAllEmployes();
            foreach (var emp in employees)
            {
                EmployeeBox.Items.Add(emp);
            }

            EmployeeBox.DisplayMember = nameof(Employee.Name);
            EmployeeBox.ValueMember = nameof(Employee.Id);

            if (EmployeeBox.Items.Count > 0)
            {
                EmployeeBox.SelectedIndex = 0;
            }

            var branches = Program.DbWriterReader.ReadAllBranches();
            foreach (var branch in branches)
            {
                branchBox.Items.Add(branch);
            }

            branchBox.DisplayMember = nameof(Branch.BranchName);
            branchBox.ValueMember = nameof(Branch.Id);

            if (branchBox.Items.Count > 0)
            {
                branchBox.SelectedIndex = 0;
            }

            var books = Program.DbWriterReader.ReadAllBooks();
            foreach (var book in books)
            {
                booksBox.Items.Add(book);
            }

            booksBox.DisplayMember = nameof(Book.Title);
            booksBox.ValueMember = nameof(Book.Id);

            if (booksBox.Items.Count > 0)
            {
                booksBox.SelectedIndex = 0;
            }

            EmployeeBox.Enabled = false;
            branchBox.Enabled = false;
            booksBox.Enabled = false;
            dateFrom.Enabled = false;
            dateTo.Enabled = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchBy();
        }

        private void poEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if (byEmployee.Checked)
            {
                EmployeeBox.Enabled = true;
            }
            else
            {
                EmployeeBox.Enabled = false;
            }
        }

        private void byBranch_CheckedChanged(object sender, EventArgs e)
        {
            if (byBranch.Checked)
            {
                branchBox.Enabled = true;
            }
            else
            {
                branchBox.Enabled = false;
            }
        }

        private void byDate_CheckedChanged(object sender, EventArgs e)
        {
            if (byDate.Checked)
            {
                dateFrom.Enabled = true;
                dateTo.Enabled = true;
            }
            else
            {
                dateFrom.Enabled = false;
                dateTo.Enabled = false;
            }
        }

        private void byBook_CheckedChanged(object sender, EventArgs e)
        {
            if (byBook.Checked)
            {
                booksBox.Enabled = true;
            }
            else
            {
                booksBox.Enabled = false;
            }
        }

        private BookAndTimeInfo MapBookToBookAndTimeInfo(BookEmployee bookEmployee)
        {
            BookAndTimeInfo bookAndTimeInfo = new BookAndTimeInfo();

            bookAndTimeInfo.Title = bookEmployee.Book.Title;
            bookAndTimeInfo.Description = bookEmployee.Book.Description;
            bookAndTimeInfo.BranchName = bookEmployee.Book.BranchName;
            bookAndTimeInfo.AuthorName = bookEmployee.Book.AuthorName;
            bookAndTimeInfo.BorrowedTime = bookEmployee.BorrowedTime;

            return bookAndTimeInfo;
        }

        private void SearchBy()
        {

            //TODO: Try method with delegate parameter where only where clause is different.

            //Search by:    Employee
            if (byEmployee.Checked && !byDate.Checked && !byBranch.Checked && !byBook.Checked)
            {
                var bookByEmployee = ((Employee)EmployeeBox.SelectedItem).BooksEmployee
                .Select(x => MapBookToBookAndTimeInfo(x))
                .ToList();

                displayBooks.DataSource = bookByEmployee;
            }

            //Search by:    Date
            else if (byDate.Checked && !byEmployee.Checked && !byBranch.Checked && !byBook.Checked)
            {
                DateTimeOffset dateTimeOffsetFrom = dateFrom.Value;
                DateTimeOffset dateTimeOffsetTo = dateTo.Value;

                var AllBooksInDate = BookEmployees
                    .Where(x => x.BorrowedTime >= dateTimeOffsetFrom && x.BorrowedTime <= dateTimeOffsetTo)
                    .Select(x => MapBookToBookAndTimeInfo(x))
                    .ToList();

                displayBooks.DataSource = AllBooksInDate;
            }

            //Search by:    Branch
            else if (byBranch.Checked && !byDate.Checked && !byEmployee.Checked && !byBook.Checked)
            {
                var branches = BookEmployees
                    .Where(x => x.Book.BranchName == ((Branch)branchBox.SelectedItem).BranchName)
                    .Select(x => MapBookToBookAndTimeInfo(x))
                    .ToList();

                displayBooks.DataSource = branches;
            }

            //Search by:    Book
            else if (byBook.Checked && !byBranch.Checked && !byDate.Checked && !byEmployee.Checked)
            {
                displayBooks.DataSource = BookEmployees
                    .Where(x => x.Book.Title == ((Book)booksBox.SelectedItem).Title)
                    .Select(x => MapBookToBookAndTimeInfo(x))
                    .ToList();
            }



            //Search by:    Employee & Date
            else if (byEmployee.Checked && byDate.Checked && !byBranch.Checked && !byBook.Checked)
            {
                DateTimeOffset dateTimeOffsetFrom = dateFrom.Value;
                DateTimeOffset dateTimeOffsetTo = dateTo.Value;

                displayBooks.DataSource = ((Employee)EmployeeBox.SelectedItem).BooksEmployee
                    .Where(x => x.BorrowedTime >= dateTimeOffsetFrom && x.BorrowedTime <= dateTimeOffsetTo)
                    .Select(x => MapBookToBookAndTimeInfo(x))
                    .ToList();
            }

            //Search by:    Employee & Branch
            else if (byEmployee.Checked && byBranch.Checked && !byDate.Checked && !byBook.Checked)
            {
                displayBooks.DataSource = ((Employee)EmployeeBox.SelectedItem).BooksEmployee
                    .Where(x => x.Book.BranchName == ((Branch)branchBox.SelectedItem).BranchName)
                    .Select(x => MapBookToBookAndTimeInfo(x))
                    .ToList();
            }

            //Search by:    Employee & Book
            else if (byEmployee.Checked && byBook.Checked && !byBranch.Checked && !byDate.Checked)
            {
                displayBooks.DataSource = BookEmployees
                    .Where(x => x.Employee.Name == ((Employe)EmployeeBox.SelectedItem).Name && x.Book.Title == ((Book)booksBox.SelectedItem).Title)
                    .Select(x => MapBookToBookAndTimeInfo(x))
                    .ToList();
            }

            //Search by:    Date & Branch
            else if (byDate.Checked && byBranch.Checked && !byEmployee.Checked && !byBook.Checked)
            {
                DateTimeOffset dateTimeOffsetFrom = dateFrom.Value;
                DateTimeOffset dateTimeOffsetTo = dateTo.Value;

                displayBooks.DataSource = BookEmployees
                    .Where(x => x.BorrowedTime >= dateTimeOffsetFrom && x.BorrowedTime <= dateTimeOffsetTo && x.Book.BranchName == ((Branch)branchBox.SelectedItem).BranchName)
                    .Select(x => MapBookToBookAndTimeInfo(x))
                    .ToList();
            }

            //Search by:    Date & Book
            else if (byDate.Checked && byBook.Checked && !byBranch.Checked && !byEmployee.Checked)
            {
                DateTimeOffset dateTimeOffsetFrom = dateFrom.Value;
                DateTimeOffset dateTimeOffsetTo = dateTo.Value;

                displayBooks.DataSource = BookEmployees
                    .Where(x => x.Book.Title == ((Book)booksBox.SelectedItem).Title && x.BorrowedTime >= dateTimeOffsetFrom && x.BorrowedTime <= dateTimeOffsetTo)
                    .Select(x => MapBookToBookAndTimeInfo(x))
                    .ToList();
            }

            //Search by:    Branch & Book
            else if (byBranch.Checked && byBook.Checked && !byDate.Checked && !byEmployee.Checked)
            {
                displayBooks.DataSource = BookEmployees
                    .Where(x => x.Book.Title == ((Book)booksBox.SelectedItem).Title && x.Book.Branch.BranchName == ((Book)booksBox.SelectedItem).BranchName)
                    .Select(x => MapBookToBookAndTimeInfo(x))
                    .ToList();
            }



            //Search by:    Employee & Date & Branch
            else if (byEmployee.Checked && byDate.Checked && byBranch.Checked && !byBook.Checked)
            {
                DateTimeOffset dateTimeOffsetFrom = dateFrom.Value;
                DateTimeOffset dateTimeOffsetTo = dateTo.Value;

                displayBooks.DataSource = BookEmployees
                    .Where(x => x.Employee.Id == ((Employee)EmployeeBox.SelectedItem).Id &&
                    x.Book.BranchName == ((Branch)branchBox.SelectedItem).BranchName &&
                    x.BorrowedTime >= dateTimeOffsetFrom && x.BorrowedTime <= dateTimeOffsetTo)
                    .Select(x => MapBookToBookAndTimeInfo(x))
                    .ToList();
            }

            //Search by:    Employee & Date & Book
            else if (byEmployee.Checked && byDate.Checked && !byBranch.Checked && byBook.Checked)
            {
                DateTimeOffset dateTimeOffsetFrom = dateFrom.Value;
                DateTimeOffset dateTimeOffsetTo = dateTo.Value;

                displayBooks.DataSource = BookEmployees
                    .Where(x => x.Employee.Name == ((Employee)EmployeeBox.SelectedItem).Name &&
                    x.BorrowedTime >= dateTimeOffsetFrom && x.BorrowedTime <= dateTimeOffsetTo &&
                    x.Book.Title == ((Book)booksBox.SelectedItem).Title)
                    .Select(x => MapBookToBookAndTimeInfo(x))
                    .ToList();
            }

            //Search by:    Employee & Branch & Book
            else if (byEmployee.Checked && !byDate.Checked && byBranch.Checked && byBook.Checked)
            {
                displayBooks.DataSource = BookEmployees
                    .Where(x => x.Employee.Name == ((Employee)EmployeeBox.SelectedItem).Name &&
                    x.Book.Branch.BranchName == ((Book)booksBox.SelectedItem).BranchName &&
                    x.Book.Title == ((Book)booksBox.SelectedItem).Title)
                    .Select(x => MapBookToBookAndTimeInfo(x))
                    .ToList();
            }

            //Search by:    Date & Branch & Book
            else if (!byEmployee.Checked && byDate.Checked && byBranch.Checked && byBook.Checked)
            {
                DateTimeOffset dateTimeOffsetFrom = dateFrom.Value;
                DateTimeOffset dateTimeOffsetTo = dateTo.Value;

                displayBooks.DataSource = BookEmployees
                    .Where(x => x.BorrowedTime >= dateTimeOffsetFrom && x.BorrowedTime <= dateTimeOffsetTo &&
                    x.Book.Branch.BranchName == ((Book)booksBox.SelectedItem).BranchName &&
                    x.Book.Title == ((Book)booksBox.SelectedItem).Title)
                    .Select(x => MapBookToBookAndTimeInfo(x))
                    .ToList();
            }



            //Search by:    Employee & Date & Branch & Book
            else if (byEmployee.Checked && byDate.Checked && byBranch.Checked && byBook.Checked)
            {
                DateTimeOffset dateTimeOffsetFrom = dateFrom.Value;
                DateTimeOffset dateTimeOffsetTo = dateTo.Value;

                displayBooks.DataSource = BookEmployees
                    .Where(x => x.Employee.Name == ((Employee)EmployeeBox.SelectedItem).Name &&
                    x.Book.Branch.BranchName == ((Book)booksBox.SelectedItem).BranchName &&
                    x.Book.Title == ((Book)booksBox.SelectedItem).Title &&
                    x.BorrowedTime >= dateTimeOffsetFrom && x.BorrowedTime <= dateTimeOffsetTo)
                    .Select(x => MapBookToBookAndTimeInfo(x))
                    .ToList();
            }
        }
    }
}

public class BookAndTimeInfo
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string BranchName { get; set; }
    public string AuthorName { get; set; }
    public DateTimeOffset BorrowedTime { get; set; }
}
