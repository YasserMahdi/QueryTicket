using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Query_Ticket.PL
{
    public partial class Login : Form
    {
        BL.LoginClass loginobject = new BL.LoginClass();
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            DataTable dt = loginobject.login(textBox1.Text, textBox2.Text);
            if (dt.Rows.Count > 0)
            {
                MainForm.GetMainForm.createABackupToolStripMenuItem.Enabled = true;
                MainForm.GetMainForm.restoreABackupToolStripMenuItem.Enabled = true;
                MainForm.GetMainForm.restoreABackupToolStripMenuItem.Enabled = true;
                MainForm.GetMainForm.logOutToolStripMenuItem.Enabled = true;
                //MainForm.GetMainForm.insertNewCostumerToolStripMenuItem.Enabled = true;
                //MainForm.GetMainForm.deletCustomerToolStripMenuItem.Enabled = true;
                //MainForm.GetMainForm.editCustomerInfoToolStripMenuItem.Enabled = true;
                MainForm.GetMainForm.usersToolStripMenuItem.Enabled = true;
                MainForm.GetMainForm.loginToolStripMenuItem.Enabled = false;
             
                this.Close();
            }

            else
                MessageBox.Show("failed");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
