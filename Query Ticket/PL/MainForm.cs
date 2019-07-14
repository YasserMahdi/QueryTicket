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
            this.usersToolStripMenuItem.Enabled = false;
        }

        public void clareBoxes()
        {
            this.txtName.Clear();
            this.txtphone.Clear();
            this.txtfailure.Clear();
            this.txtcost.Clear();
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
            MainForm.GetMainForm.usersToolStripMenuItem.Enabled = false;
            
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


        private void clientListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.clientList frm = new clientList();
            frm.ShowDialog();
        }


        private void usersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PL.users frm = new users();
            frm.ShowDialog();
        }

     
        private void createABackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Backup frm = new Backup();
            frm.ShowDialog();
        }

        private void restoreABackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Restore frm = new Restore();
            frm.ShowDialog();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                BL.clientClass client = new BL.clientClass();
                client.insert(txtName.Text, txtphone.Text, txtfailure.Text, Convert.ToDouble(txtcost.Text));

                if (MessageBox.Show("تمت الاضافة بنجاح هل تريد طباعة الفاتورة", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    clareBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            clareBoxes();

        }
    }
}
