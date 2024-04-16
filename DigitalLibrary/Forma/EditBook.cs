using DigitalLibrary;
using Forma;


namespace Forms
{
    public partial class EditBook : Form
    {
        private string selectedImagePath;
        private string fileName;

        public EditBook()
        {
            InitializeComponent();
        }

        private void EditBook_Load(object sender, EventArgs e)
        {
            try
            {
                var books = Program.DbWriterReader.ReadAllBooks();
                foreach (var bok in books)
                {
                    book.Items.Add(bok);
                }

                book.DisplayMember = nameof(Book.Title);
                book.ValueMember = nameof(Book.Id);

                if (book.Items.Count > 0)
                {
                    book.SelectedIndex = 0;
                }

                populateBranches();
                populateAuthorBox();
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }
        }

        private void book_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if ((Book)book.SelectedItem != null)
                {
                    tittleBox.Text = ((Book)book.SelectedItem).Title;
                    descBox.Text = ((Book)book.SelectedItem).Description;
                    quantity.Value = ((Book)book.SelectedItem).Quantity;
                    branchBox.SelectedItem = ((Book)book.SelectedItem).Branch;
                    authorBox.SelectedItem = ((Book)book.SelectedItem).Author;
                    img.Text = ((Book)book.SelectedItem).PictureName;
                }
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }
        }

        private void populateBranches()
        {
            branchBox.Items.Clear();

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
        }

        private void populateAuthorBox()
        {
            authorBox.Items.Clear();

            var authors = Program.DbWriterReader.ReadAllAuthors();
            foreach (var auth in authors)
            {
                authorBox.Items.Add(auth);
            }

            authorBox.DisplayMember = nameof(Author.Name);
            authorBox.ValueMember = nameof(Author.Id);

            if (authorBox.Items.Count > 0)
            {
                authorBox.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AddBranch addBranch = new AddBranch();
                if (addBranch.ShowDialog() == DialogResult.Cancel)
                {
                    populateBranches();
                }
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                AddAuthor addAuthor = new AddAuthor();
                if (addAuthor.ShowDialog() == DialogResult.Cancel)
                {
                    populateAuthorBox();
                }
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }
        }

        private void browseImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;
                }
                if (!string.IsNullOrEmpty(selectedImagePath))
                {
                    fileName = Path.GetFileName(selectedImagePath);

                    string destinationPath = AppDomain.CurrentDomain.BaseDirectory + @"/Images";
                    string destinationFile = Path.Combine(destinationPath, fileName);

                    File.Copy(selectedImagePath, destinationFile, true);

                    img.Text = fileName;
                }
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (tittleBox.Text.Length > 0 && descBox.Text.Length > 0 && img.Text.Length > 0)
                {
                    ((Book)book.SelectedItem).Title = tittleBox.Text;
                    ((Book)book.SelectedItem).Description = descBox.Text;
                    ((Book)book.SelectedItem).Quantity = (int)quantity.Value;
                    ((Book)book.SelectedItem).BranchID = ((Branch)branchBox.SelectedItem).Id;
                    ((Book)book.SelectedItem).AuthorId = ((Author)authorBox.SelectedItem).Id;
                    ((Book)book.SelectedItem).PictureName = img.Text;

                    Program.DbWriterReader.UpdateBook((Book)book.SelectedItem);

                    MessageBox.Show("Book Updated !");
                }
                else
                {
                    MessageBox.Show("Fill the fields !");
                }
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }
        }

        private void branchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if ((Branch)branchBox.SelectedItem != null)
                {
                    ((Book)book.SelectedItem).BranchID = ((Branch)branchBox.SelectedItem).Id;
                }
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }
        }

        private void authorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if ((Author)authorBox.SelectedItem != null)
                {
                    ((Book)book.SelectedItem).AuthorId = ((Author)authorBox.SelectedItem).Id;
                }
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }

        }
    }
}
