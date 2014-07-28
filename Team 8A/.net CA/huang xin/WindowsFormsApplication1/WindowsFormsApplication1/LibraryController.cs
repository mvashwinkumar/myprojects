using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LibraryTeam8A
{
    class LibraryController
    {
        SqlConnection cnMaster;
        SqlCommand cmMaster;
        SqlDataAdapter daMaster;
        DataSet dsMaster;
        SqlCommandBuilder cmbMaster;
        DataView dvMaster;

        public void makeConnection(string strSqlCommand)
        {
            cnMaster = new SqlConnection("data source = (local); integrated security = SSPI; initial catalog = Library");
            cnMaster.Open();
            cmMaster = new SqlCommand(strSqlCommand, cnMaster);
            daMaster = new SqlDataAdapter(cmMaster);
            cmbMaster = new SqlCommandBuilder(daMaster);
            dsMaster = new DataSet();
            daMaster.Fill(dsMaster);
            dvMaster = new DataView();
        }

        public DataSet DsMaster
        {
            get {
                return dsMaster;
            }
            }
        public void RunProgram()
        {
            makeConnection("select * from Books; select * from Members; select * from Transactions; select * from Staff");
            TransactionsController transactionsControl = new TransactionsController(this);
            transactionsControl.RunProgram();
        }
    }
}
