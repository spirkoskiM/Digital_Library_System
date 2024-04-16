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
    public partial class EmployeeReport : Form
    {
        public EmployeeReport()
        {
            InitializeComponent();
        }
        private void EmployeeReport_Load(object sender, EventArgs e)
        {
            try
            {
                var branches = Program.DbWriterReader.ReadAllBranches();

                foreach (var Branch in branches)
                {
                    branchbox.Items.Add(Branch);
                }

                branchbox.DisplayMember = nameof(DigitalLibrary.Branch.BranchName);
                branchbox.ValueMember = nameof(DigitalLibrary.Branch.Id);

                if (branchbox.Items.Count > 0)
                {
                    branchbox.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }
        }
        private void viewbutton_Click(object sender, EventArgs e)
        {
            try
            {
                var employes = Program.DbWriterReader.ReadAllEmployees((Branch)branchbox.SelectedItem);

                tableEmployee.DataSource = employes;
            }
            catch (Exception ex)
            {
                Logging.ExceptionHandling(ex);
            }
        }
    }
}
