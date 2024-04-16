using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DigitalLibrary.Services
{
    public class DbWriteRead
    {
        private LibraryContext _libraryContext;
        private AppSettings _AppSettings;

        public DbWriteRead()
        {
            _AppSettings = new AppSettings(AppDomain.CurrentDomain.BaseDirectory + "AppSettings.xml");
            var AppSettingsXml = _AppSettings.LoadFromFile();

            _libraryContext = new LibraryContext(_AppSettings.CreateConnectionStringFromLoadedFile(AppSettingsXml));
            _libraryContext.Database.Migrate();
        }
        public void AddNewBook(Book book)
        {
            _libraryContext.Add(book);
            _libraryContext.SaveChanges();
        }
        public void UpdateBook(Book book)
        {
            _libraryContext.Update(book);
            _libraryContext.SaveChanges();
        }
        public void UpdateEmployeeInfo(Employee emp)
        {
            _libraryContext.Update(emp);
            _libraryContext.SaveChanges();
        }
        public void UpdateBookEmployee(BookEmployee emp)
        {
            _libraryContext.Update(emp);
            _libraryContext.SaveChanges();
        }
        public void UpdateReturnEmployee(Employee employee)
        {
            _libraryContext.Update(employee);
            _libraryContext.SaveChanges();
        }
        public Employee ReadEmployeeByName(string name)
        {
            return _libraryContext.Employee.Include(x=>x.BooksEmployee).Where(e => e.Name == name).FirstOrDefault();
        }
        public bool CheckIfBookExist(string tittle)
        {
            return  _libraryContext.Books.Any(b=>b.Title == tittle);
        }
        public Book ReadBookByTitle(string title)
        {
            return _libraryContext.Books.Include(x=>x.Author).Include(x=>x.Branch).Where(x => x.Title == title).FirstOrDefault();
        }
        public Employee CheckIfEmployeeExist(string username, string password)
        {
            return _libraryContext.Employee
                .Include(x => x.branch)
                .Include(x=>x.BooksEmployee).ThenInclude(x=>x.Book.Author)
                .Include(x=>x.BooksEmployee).ThenInclude(x=>x.Book.Branch)
                .FirstOrDefault(u => u.Email == username && u.Password == password);

        }
        public bool CheckIfUserExist(string username, string password)
        {
            var user = _libraryContext.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            return user != null;
        }
        public int CheckIsAdmin(string username)
        {
            var user = _libraryContext.Users.FirstOrDefault(u => u.Username == username);

            if (user != null)
            {
                return user.isAdmin;
            }
            return -1;
        }
        public bool CheckIfBranchExist(string name)
        {
            var branch = _libraryContext.Branch.FirstOrDefault(b => b.BranchName == name);
            if (branch != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckIfEmplyeeExist(string name)
        {
            var employee = _libraryContext.Employee.FirstOrDefault(e => e.Name == name);
            if (employee != null)
            {
                return true;
            }
            else { return false; }
        }
        public bool CheckIfAuthorExist(string name)
        {
            var auth = _libraryContext.Author.FirstOrDefault(a => a.Name == name);
            if(auth != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Branch> ReadAllBranches()
        {
            return _libraryContext.Branch.ToList();
        }
        public List<Gender> ReadAllGenders()
        {
            return _libraryContext.Gender.ToList();
        }
        public List<Author> ReadAllAuthors()
        {
            return _libraryContext.Author.ToList();
        }
        public List<Book> ReadAllBooks()
        {
            return _libraryContext.Books.Include(x=>x.Author).Include(y=>y.Branch).ToList();
        }
        public List<BookEmployee> ReadAllBookEmployee()
        {
            return _libraryContext.BookEmployee.Include(x => x.Book).ThenInclude(x=>x.Author).Include(x=>x.Book).ThenInclude(x=>x.Branch).ToList();
        }
        public List<Book> ReadBooksForEmployee(int id)
        {
            return _libraryContext.Employee.Include(x => x.branch).Where(x=>x.Id == id).SelectMany(x=>x.BooksEmployee.Select(x=>x.Book)).Include(x=>x.Author).Include(x=>x.Branch).ToList();
        }
        public List<Book> ReadBooksInfo(int branchid)
        {
            return _libraryContext.Books
                .Where(b => b.BranchID == branchid)
                .ToList();
        }
        public List<Employee> ReadAllEmployes()
        {
            return _libraryContext.Employee
                .Include(x=>x.branch)
                .Include(x=>x.BooksEmployee).ThenInclude(x=>x.Book).ThenInclude(x=>x.Author)
                .Include(x=>x.BooksEmployee).ThenInclude(x=>x.Book).ThenInclude(x=>x.Branch)
                .ToList();
        }
        public List<Employee> ReadAllEmployees(Branch branch)
        {
            return _libraryContext.Employee
                .Where(i => i.branch == branch)
                .ToList();
        }
        public void AddNewBranch(Branch branch)
        {
            _libraryContext.Add(branch);
            _libraryContext.SaveChanges();
        }
        public void AddNewAuthor(Author author)
        {
            _libraryContext.Add(author);
            _libraryContext.SaveChanges();
        }
        public void AddNewEmployee(Employee employee)
        {
            _libraryContext.Add(employee);
            _libraryContext.SaveChanges();
        }
        public void DeleteBook(Book book)
        {
            _libraryContext.Remove(book);
            _libraryContext.SaveChanges();
        }
    }
}

