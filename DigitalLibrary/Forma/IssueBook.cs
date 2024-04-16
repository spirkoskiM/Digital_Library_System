using DigitalLibrary;
using Forma;

namespace Forms
{
    public partial class IssueBook : Form
    {
        //TODO: Delete
        Employee emp;
        Book book;
        Book SelectedBook;
        Employee selectedemp;

        public IssueBook()
        {
            InitializeComponent();
        }
        private void IssueBook_Load(object sender, EventArgs e)
        {
            try
            {
                var employes = Program.DbWriterReader.ReadAllEmployes();

                foreach (var emp in employes)
                {
                    employeebox.Items.Add(emp);
                }

                employeebox.DisplayMember = nameof(Employee.Name);
                employeebox.ValueMember = nameof(Employee.Id);

                if (employeebox.Items.Count > 0)
                {
                    selectedemp = (Employee)employeebox.Items[0];
                    employeebox.SelectedIndex = 0;

                    employeename.Text = selectedemp.Name;
                }

                var books = Program.DbWriterReader.ReadAllBooks();

                foreach (var bok in books)
                {
                    bookbox.Items.Add(bok);
                }

                bookbox.DisplayMember = nameof(Book.Title);
                bookbox.ValueMember = nameof(Book.Id);

                if (bookbox.Items.Count > 0)
                {
                    SelectedBook = (Book)bookbox.Items[0];
                    bookbox.SelectedIndex = 0;

                    bookname.Text = SelectedBook.Title;
                    authorname.Text = SelectedBook.AuthorName;
                    branchname.Text = SelectedBook.BranchName;
                    bookQuan.Text = SelectedBook.Quantity.ToString();
                    string selectedImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"/Images", SelectedBook.PictureName);

                    if (!string.IsNullOrEmpty(selectedImagePath) && !string.IsNullOrEmpty(SelectedBook.PictureName))
                    {
                        Image image = Image.FromFile(selectedImagePath);
                        picture1.Image = image;
                    }
                    else
                    {
                        MessageBox.Show("Error loading image");
                    }
                }

                bookbox.SelectedIndexChanged += BookBox_SelectedIndexChanged;
                employeebox.SelectedIndexChanged += employeebox_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }
        }
        //TODO: Subscribe in Designer classs
        private void BookBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            SelectedBook = bookbox.SelectedItem as Book;
            selectedemp = employeebox.SelectedItem as Employee;
            employeename.Text = employeebox.Text;
            bookname.Text = bookbox.Text;
            authorname.Text = SelectedBook.Author.Name;
            branchname.Text = SelectedBook.Branch.BranchName;
            bookQuan.Text = SelectedBook.Quantity.ToString();

            try
            {
                string pictureNameFromDB = SelectedBook.PictureName;
                string selectedImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"/Images", pictureNameFromDB);

                if (!string.IsNullOrEmpty(selectedImagePath) && !string.IsNullOrEmpty(pictureNameFromDB))
                {
                    Image image = Image.FromFile(selectedImagePath);
                    picture1.Image = image;
                }
                else
                {
                    MessageBox.Show("Error loading image");
                }
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }

        }
        private void selectbtn_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO: Veke gi imas ovie vo memorija
                emp = Program.DbWriterReader.ReadEmployeeByName(selectedemp.Name);
                book = Program.DbWriterReader.ReadBookByTitle(SelectedBook.Title);

                if (SelectedBook.Quantity > 0)
                {
                    emp.BooksToReturn = emp.BooksToReturn + 1;
                    SelectedBook.Quantity = SelectedBook.Quantity - 1;

                    if (!emp.BooksEmployee.Select(x => x.Book).Contains(SelectedBook))
                    {
                        emp.BooksEmployee.Add(new BookEmployee { BookId = SelectedBook.Id, Quantity = 1, BorrowedTime = DateTimeOffset.Now });
                    }
                    else
                    {
                        var existingBookEmployee = emp.BooksEmployee.First(x => x.BookId == SelectedBook.Id);
                        existingBookEmployee.Quantity++;
                        existingBookEmployee.BorrowedTime = DateTimeOffset.Now;
                    }

                    Program.DbWriterReader.UpdateReturnEmployee(emp);

                    MessageBox.Show("Successfully issued Book !");

                    bookQuan.Text = SelectedBook.Quantity.ToString();

                    if (SelectedBook.Quantity == 0)
                    {
                        bookbox.Items.Remove(SelectedBook);
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }
        }
        //TODO: Subscribe in Designer classs
        private void employeebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedemp = employeebox.SelectedItem as Employee;
            employeename.Text = selectedemp.Name;
        }
    }
}
