using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Query_Ticket.BL
{
    class insert_client
    {
        public DataTable insert(string fullname, string phone,string failure, float cost)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@fullname", SqlDbType.VarChar, 50);
            param[0].Value = fullname;

            param[1] = new SqlParameter("@phone", SqlDbType.VarChar, 50);
            param[1].Value = phone;

            param[2] = new SqlParameter("@failure", SqlDbType.VarChar, 50);
            param[2].Value = failure;

            param[3] = new SqlParameter("@cost", SqlDbType.Float);
            param[3].Value = cost;

            accessobject.open();


            DataTable Dt = new DataTable();
            accessobject.Executecmd("InsertClients", param);
            accessobject.close();

            return Dt;

        }
    }
}
