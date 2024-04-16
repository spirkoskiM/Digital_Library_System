using Forma;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void addbook_Click(object sender, EventArgs e)
        {
            Add_Book book = new Add_Book();
            book.ShowDialog();
        }
        private void bookreport_Click(object sender, EventArgs e)
        {
            ViewBook vb = new ViewBook();
            vb.ShowDialog();
        }
        private void addbranch_Click(object sender, EventArgs e)
        {
            AddBranch addBranch = new AddBranch();
            addBranch.ShowDialog();
        }
        private void addemployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.ShowDialog();
        }
        private void employeereport_Click(object sender, EventArgs e)
        {
            EmployeeReport employeeReport = new EmployeeReport();
            employeeReport.ShowDialog();
        }
        private void returnbook_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook();
            returnBook.ShowDialog();
        }
        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void issuebook_Click(object sender, EventArgs e)
        {
            IssueBook issueBook = new IssueBook();
            issueBook.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            BorrowedBooksReport borrowedBooksReport = new BorrowedBooksReport();
            borrowedBooksReport.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            EditBook editBook = new EditBook();
            editBook.ShowDialog();
        }
    }
}
