using DigitalLibrary;
using Forma;
using Microsoft.EntityFrameworkCore;


namespace Forms
{
    public partial class ReturnBook : Form
    {
        Book SelectedBook;
        Employee selectedemp;

        public ReturnBook()
        {
            InitializeComponent();
        }
        private void ReturnBook_Load(object sender, EventArgs e)
        {
            try
            {
                var employees = Program.DbWriterReader.ReadAllEmployes();

                foreach (var emp in employees)
                {
                    empbox.Items.Add(emp);
                }

                empbox.DisplayMember = nameof(Employee.Name);
                empbox.ValueMember = nameof(Employee.Id);

                if (empbox.Items.Count > 0)
                {
                    selectedemp = (Employee)empbox.Items[0];
                    empbox.SelectedIndex = 0;
                    empbox.SelectedItem = empbox.Items[0];
                    employeename.Text = empbox.Text;

                    PopulateBookBox();
                }
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }
        }
        private void PopulateBookBox()
        {
            try
            {
                var selectedEmp = (Employee)empbox.SelectedItem;

                if (selectedEmp != null)
                {
                    var books = Program.DbWriterReader.ReadBooksForEmployee(selectedEmp.Id);

                    bookbox.Items.Clear();

                    foreach (var book in books)
                    {
                        bookbox.Items.Add(book);
                    }

                    bookbox.DisplayMember = nameof(Book.Title);
                    bookbox.ValueMember = nameof(Book.Id);

                    if (bookbox.Items.Count > 0)
                    {
                        SelectedBook = (Book?)bookbox.Items[0];
                        bookbox.SelectedIndex = 0;
                        bookbox.SelectedItem = bookbox.Items[bookbox.SelectedIndex];
                    }
                }
                else
                {
                    bookbox.Items.Clear();
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
                SelectedBook = bookbox.SelectedItem as Book;

                if (SelectedBook != null)
                {
                    //TODO: nema potreba da se cita, veke go imame.
                    Employee emp = Program.DbWriterReader.ReadEmployeeByName(empbox.Text);
                    if (emp.BooksToReturn > 0)
                    {
                        int QuantitySelectedBook = emp.BooksEmployee.Where(e => e.BookId == SelectedBook.Id)
                                                                   .Select(q => q.Quantity)
                                                                   .FirstOrDefault();
                        if (QuantitySelectedBook > 0)
                        {
                            //TODO: Moze da se namali ova citanje od baza
                            var selectedBookEmployee = emp.BooksEmployee.FirstOrDefault(q => q.EmployeeId == emp.Id && q.BookId == SelectedBook.Id);

                            if (selectedBookEmployee != null)
                            {
                                selectedBookEmployee.Quantity = selectedBookEmployee.Quantity - 1;
                                Program.DbWriterReader.UpdateBookEmployee(selectedBookEmployee);
                                BooksToReturnNumber.Text = selectedBookEmployee.Quantity.ToString();
                            }
                            MessageBox.Show("Successfully returned book");

                            emp.BooksToReturn -= 1;
                            SelectedBook.Quantity += 1;
                            //TODO: da se vidi dali mozi samo update na emp
                            Program.DbWriterReader.UpdateReturnEmployee(emp);
                            Program.DbWriterReader.UpdateBook(SelectedBook);

                            if (selectedBookEmployee.Quantity == 0)
                            {
                                bookbox.Items.Remove(SelectedBook);
 
                                employeename.Text = string.Empty;
                                authorname.Text = string.Empty;
                                bookname.Text = string.Empty;
                                branchname.Text = string.Empty;
                                picbox.Image = null;

                                if (selectedBookEmployee != null)
                                {
                                    emp.BooksEmployee.Remove(selectedBookEmployee);
                                    Program.DbWriterReader.UpdateBookEmployee(selectedBookEmployee);
                                }
                            }
                        }
                    }
                    else if (emp.BooksToReturn == 0)
                    {
                        MessageBox.Show("No books to return !");
                    }
                }
                else
                {
                    MessageBox.Show("No Books to return !");
                }
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }
        }
        private void empbox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                selectedemp = (Employee)empbox.SelectedItem;
                PopulateBookBox();
                SelectedBook = (Book)bookbox.SelectedItem;
                employeename.Text = empbox.Text;
                BooksToReturnNumber.Text = selectedemp.BooksToReturn.ToString();

                if (SelectedBook != null)
                {
                    bookname.Text = SelectedBook.Title;
                    authorname.Text = SelectedBook.AuthorName;
                    branchname.Text = SelectedBook.BranchName;
                }
                else
                {
                    bookname.Text = "";
                    authorname.Text = "";
                    branchname.Text = "";
                    picbox.Image = null;
                }
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }
        }
        private void bookbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SelectedBook = (Book?)bookbox.Items[bookbox.SelectedIndex];

                bookname.Text = SelectedBook.Title;
                authorname.Text = SelectedBook.AuthorName;
                branchname.Text = SelectedBook.BranchName;

                BooksToReturnNumber.Text = selectedemp.BooksEmployee
                    .Where(b => b.Book == SelectedBook)
                    .Select(x => x.Quantity)
                    .FirstOrDefault()
                    .ToString();

                try
                {
                    string pictureNameFromDB = SelectedBook.PictureName;
                    string selectedImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"/Images", pictureNameFromDB);

                    if (!string.IsNullOrEmpty(selectedImagePath) && !string.IsNullOrEmpty(pictureNameFromDB))
                    {
                        Image image = Image.FromFile(selectedImagePath);
                        picbox.Image = image;
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
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }
        }
    }
}
