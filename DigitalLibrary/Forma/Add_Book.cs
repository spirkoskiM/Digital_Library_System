using DigitalLibrary;
using Forma;
using System.Text.RegularExpressions;


namespace Forms
{
    public partial class Add_Book : Form
    {
        private string selectedImagePath;
        private string fileName;

        public Add_Book()
        {
            InitializeComponent();
        }

        public void addBookToDatabase()
        {
            try
            {
                string Tittle = tittle.Text;
                string desc = getdescription.Text;
                string quan = BookQuantity.Text;

                if (Program.DbWriterReader.CheckIfBookExist(Tittle))
                {
                    MessageBox.Show("Book already exist");
                }
                else
                {
                    if (Tittle.Length > 0 && desc.Length > 0 && quan.Length > 0)
                    {
                        if (Regex.IsMatch(quan, "^[0-9]+$") == true)
                        {
                            Book book = new Book();
                            book.Title = Tittle;
                            book.Description = desc;
                            book.Quantity = int.Parse(quan);
                            book.BranchID = ((Branch)getbranch.SelectedItem).Id;
                            book.AuthorId = ((Author)authorBox.SelectedItem).Id;
                            book.PictureName = fileName;
                            book.Created = DateTimeOffset.Now;

                            Program.DbWriterReader.AddNewBook(book);
                            MessageBox.Show("Successfully added Book");
                            tittle.Text = string.Empty;
                            getdescription.Text = string.Empty;
                            BookQuantity.Text = 0.ToString();
                            imgName.Text = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("Fill Quantity with number");
                            BookQuantity.Text = string.Empty;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fill all fields");
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }
        }

        private void Add_Book_Load(object sender, EventArgs e)
        {
            try
            {
                populateAuthorBox();
                populateBranchBox();
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }
        }

        private void Button_AddBook_Click(object sender, EventArgs e)
        {
            addBookToDatabase();
        }

        private void browseimage_Click_1(object sender, EventArgs e)
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

                    imgName.Text = fileName;
                }
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }
        }

        private void AddAuthor_Click(object sender, EventArgs e)
        {
            AddAuthor addAuthor = new AddAuthor();
            if (addAuthor.ShowDialog() == DialogResult.Cancel)
            {
                populateAuthorBox();
            }
        }

        private void AddBranch_Click(object sender, EventArgs e)
        {
            AddBranch addBranch = new AddBranch();
            if (addBranch.ShowDialog() == DialogResult.Cancel)
            {
                populateBranchBox();
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

        private void populateBranchBox()
        {
            getbranch.Items.Clear();

            var branches = Program.DbWriterReader.ReadAllBranches();
            foreach (var branch in branches)
            {
                getbranch.Items.Add(branch);
            }

            getbranch.DisplayMember = nameof(Branch.BranchName);
            getbranch.ValueMember = nameof(Branch.Id);

            if (getbranch.Items.Count > 0)
            {
                getbranch.SelectedIndex = 0;
            }
        }
    }
}
