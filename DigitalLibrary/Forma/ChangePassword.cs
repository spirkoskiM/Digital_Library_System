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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (newpass.Text.Length == confirmpass.Text.Length)
                {
                    if (newpass.Text == confirmpass.Text)
                    {
                        var updateEmp = Program.LogedEmployee;
                        updateEmp.Password = newpass.Text;

                        Program.DbWriterReader.UpdateEmployeeInfo(updateEmp);

                        MessageBox.Show("Password successfully updated");
                    }
                    else
                    {
                        MessageBox.Show("Confirm the pass...");
                    }
                }
                else
                {
                    MessageBox.Show("Confirm the pass...");
                }
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }
        }
    }
}
