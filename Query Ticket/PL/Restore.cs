using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Query_Ticket.PL
{
    public partial class Restore : Form
    {
        SqlConnection conn = new SqlConnection(@"server=.\SQLEXPRESS;database=master;integrated security=true");
        SqlCommand cmd;
        public Restore()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = openFileDialog1.FileName;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {

                string query = "ALTER Database DataTeckits SET OFFLINE WITH ROLLBACK IMMEDIATE ; Restore Database sales_stations from Disk='" + txtPath.Text + "'";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("تم استعادة النسخة الاحتياطية");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
