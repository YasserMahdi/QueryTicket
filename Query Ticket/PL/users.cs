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
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            PL.INSERT_NEW_USER frm = new INSERT_NEW_USER();
            frm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PL.EDIT_USER frm = new EDIT_USER();
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PL.DELET_USER frm = new DELET_USER();
            frm.ShowDialog();
        }
    }
}
