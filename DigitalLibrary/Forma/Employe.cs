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
    public partial class Employe : Form
    {
        public Employe()
        {
            InitializeComponent();
        }
        private void acc_Click(object sender, EventArgs e)
        {
            MyAccount myAccount = new MyAccount();
            myAccount.ShowDialog();
        }
        private void bookreport_Click(object sender, EventArgs e)
        {
            ViewBookEmp viewBookEmp = new ViewBookEmp();
            viewBookEmp.ShowDialog();
        }
        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
