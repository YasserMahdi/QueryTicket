using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Query_Ticket.BL
{
    class clientClass
    {
        public void insert(string fullname, string phone,string failure, double cost)
        {

            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            param[0].Value = fullname;

            param[1] = new SqlParameter("@phone", SqlDbType.VarChar, 50);
            param[1].Value = phone;

            param[2] = new SqlParameter("@failure", SqlDbType.VarChar, 50);
            param[2].Value = failure;

            param[3] = new SqlParameter("@cost", SqlDbType.Money);
            param[3].Value = cost;

            accessobject.open();


            
            accessobject.Executecmd("InsertClients", param);
            accessobject.close();

            

        }

        public DataTable clientList()
        {

            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            

            accessobject.open();


            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("ClientList", null);
            accessobject.close();

            return Dt;

        }
    }
}
