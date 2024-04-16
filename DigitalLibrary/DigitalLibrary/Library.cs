using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Infrastructure.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigitalLibrary
{
    #region Model

    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int isAdmin { get; set; }
    }

    public class Book
    {
        [Browsable(false)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        [Browsable(false)]
        public int Quantity { get; set; }

        [Browsable(false)]
        public Branch Branch { get; set; }

        [Browsable(false)]
        public int BranchID { get; set; }

        [Browsable(false)]
        public Author Author { get; set; }

        [Browsable(false)]
        public int AuthorId { get; set; }

        [Browsable(false)]
        public string? PictureName { get; set; }

        [NotMapped]
        public string BranchName
        {
            get
            {
                return Branch?.BranchName;
            }
        }

        [NotMapped]
        public string AuthorName
        {
            get
            {
                return Author?.Name;
            }
        }

        public DateTimeOffset? Created { get; set; }

        public List<BookEmployee> Employees { get; set; }
    }

    public class Branch
    {
        public int Id { get; set; }
        public string BranchName { get; set; }
        public List<Book> Books { get; set; }
        public List<Employee> Employees { get; set; }

    }

    public class Author
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Book> books { get; set; }
    }

    public class Employee
    {
        [Browsable(false)]
        public int Id { get; set; }
        public string Name { get; set; }
        [Browsable(false)]
        public Gender Gender { get; set; }
        [Browsable(false)]
        public int genderID { get; set; }
        public string Birthday { get; set; }
        public string Mobile { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [Browsable(false)]
        public Branch branch { get; set; }
        [Browsable(false)]
        public int branchID { get; set; }
        [NotMapped]
        public string BranchName
        {
            get
            {
                return branch?.BranchName;
            }
        }
        public int? BooksToReturn { get; set; }
        public List<BookEmployee> BooksEmployee { get; set; }
    }

    public class Gender
    {
        public int Id { get; set; }
        public string GenderName { get; set; }
        public List<Employee> employees { get; set; }
    }

    public class BookEmployee
    {
        [Browsable(false)]
        public int BookId { get; set; }
        [Browsable(false)]
        public int EmployeeId { get; set; }
        [Browsable(false)]
        public Book Book { get; set; }

        [NotMapped]
        public string Bookname
        {
            get
            {
                return Book.Title;
            }
        }

        [NotMapped]
        public string Authorname
        {
            get
            {
                return Book.AuthorName;
            }
        }

        [Browsable(false)]
        public Employee Employee { get; set; }
        public int Quantity { get; set; }

        public DateTimeOffset BorrowedTime { get; set; }
    }
    #endregion


    #region Context
    public class LibraryContext : DbContext
    {
        public LibraryContext()
        {

        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Author { get; set; }

        public DbSet<Branch> Branch { get; set; }

        public DbSet<Employee> Employee { get; set; }

        public DbSet<Gender> Gender { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<BookEmployee> BookEmployee { get; set; }

        public LibraryContext(string ConnectionString) : base(GetOptions(ConnectionString))
        {

        }
        private static DbContextOptions GetOptions(string ConnectionString)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), ConnectionString).Options;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //CHANGE YOUR DATA_SOURCE
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-QAQGGK3;Initial Catalog=DigitalLibrary;Integrated Security=True;TrustServerCertificate=True");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookEmployee>()
                   .HasKey(be => new { be.BookId, be.EmployeeId });

            modelBuilder.Entity<BookEmployee>()
                .HasOne(be => be.Book)
                .WithMany(b => b.Employees)
                .HasForeignKey(be => be.BookId)
                .OnDelete(DeleteBehavior.Restrict); // Set delete behavior to "NO ACTION" (Restrict)

            modelBuilder.Entity<BookEmployee>()
                .HasOne(be => be.Employee)
                .WithMany(e => e.BooksEmployee)
                .HasForeignKey(be => be.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict); // Set delete behavior to "NO ACTION" (Restrict)

            modelBuilder.Entity<Gender>().HasData(
                new Gender { Id = 1, GenderName = "Male" },
                new Gender { Id = 2, GenderName = "Female" }
            );

            modelBuilder.Entity<User>().HasData(
            new User { Id = 1, Username = "admin", Password = "admin", isAdmin = 1 });

            modelBuilder.Entity<Branch>().HasData(
            new Branch { Id = 1, BranchName = "IT" },
            new Branch { Id = 2, BranchName = "HR" });
        }
    }
    #endregion
}