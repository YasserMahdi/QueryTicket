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
    public partial class MainForm : Form
    {
        public static MainForm frm;

        static void frm_frmclose(object sender, FormClosedEventArgs e)
        {
            frm = null; 
        }
        public static MainForm GetMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new MainForm();
                    frm.FormClosed += new FormClosedEventHandler(frm_frmclose);

                }
                return frm;
            }
        }
        public MainForm()
        {
            InitializeComponent();
            if (frm == null)
            {
                frm = this;
            }
            this.createABackupToolStripMenuItem.Enabled = false;
            this.restoreABackupToolStripMenuItem.Enabled = false;
            this.logOutToolStripMenuItem.Enabled = false;
            //this.editToolStripMenuItem.Enabled = false;
            this.insertNewUserToolStripMenuItem.Enabled = false;
            this.editUserToolStripMenuItem.Enabled = false;
            this.deletUserToolStripMenuItem.Enabled = false;
        }

        private void insertNewCostumerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.ShowDialog();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
             
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void insertNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            INSERT_NEW_USER INSUSER = new INSERT_NEW_USER();
            INSUSER.ShowDialog();
          
        }

        private void deletUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DELET_USER delluser = new DELET_USER();
            delluser.ShowDialog();
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EDIT_USER edituser = new EDIT_USER();
            edituser.ShowDialog();

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm.GetMainForm.loginToolStripMenuItem.Enabled = true;
            MainForm.GetMainForm.createABackupToolStripMenuItem.Enabled = false;
            MainForm.GetMainForm.restoreABackupToolStripMenuItem.Enabled = false;
            MainForm.GetMainForm.restoreABackupToolStripMenuItem.Enabled = false;
            MainForm.GetMainForm.logOutToolStripMenuItem.Enabled = false;
            MainForm.GetMainForm.insertNewUserToolStripMenuItem.Enabled = false;
            MainForm.GetMainForm.deletUserToolStripMenuItem.Enabled = false;
            MainForm.GetMainForm.editUserToolStripMenuItem.Enabled = false;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
