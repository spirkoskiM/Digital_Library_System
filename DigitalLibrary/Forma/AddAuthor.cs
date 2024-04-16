using DigitalLibrary;
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
    public partial class AddAuthor : Form
    {
        public AddAuthor()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                string name = authname.Text;
                Author auth = new Author();
                auth.Name = name;

                if (authname.Text.Length > 0)
                {
                    if (!Program.DbWriterReader.CheckIfAuthorExist(name))
                    {
                        Program.DbWriterReader.AddNewAuthor(auth);
                        MessageBox.Show("Succesfully Added");

                        authname.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Author Already Exist !");
                    }
                }
                else
                {
                    MessageBox.Show("Fill Author Name !");
                }
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }
        }
    }
}
