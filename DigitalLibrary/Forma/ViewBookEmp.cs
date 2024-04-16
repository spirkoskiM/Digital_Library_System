using Forma;

namespace Forms
{
    public partial class ViewBookEmp : Form
    {
        public ViewBookEmp()
        {
            InitializeComponent();
        }
        private void ViewBookEmp_Load(object sender, EventArgs e)
        {
            try
            {
                var AllBooksForemployee = Program.LogedEmployee.BooksEmployee;
                displayBooks.DataSource = AllBooksForemployee;
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }
        }
    }
}
