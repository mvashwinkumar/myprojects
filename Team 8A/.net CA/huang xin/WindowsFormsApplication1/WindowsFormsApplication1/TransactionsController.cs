using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibraryTeam8A
{

    class TransactionsController
    {
        LibraryController libraryControl;
        DataView dvStaff;
        Form_Transactions TransactionScreen;

        public TransactionsController(LibraryController lc)
        {
            libraryControl = lc;
        }

        public string getStaffIDPassword(string strStaffID, string strPassword)
        {
            dvStaff = new DataView();
            dvStaff.Table = libraryControl.DsMaster.Tables["Staff"];
            dvStaff.Sort = "StaffID";
            int posnID = dvStaff.Find(strStaffID);
            dvStaff.Sort = "StaffPassword";
            int posnPwd = dvStaff.Find(strPassword);
            if (posnID >= 0 && posnPwd >= 0)
            {
               // MessageBox.Show("Welcome " + dsStaff.Tables["Staff"].Rows[posnID]["StaffName"].ToString());
                TransactionScreen = new Form_Transactions();
                TransactionScreen.Show();
                return "Welcome " + dvStaff.Table.Rows[posnID]["StaffName"].ToString();
            }
            else
                return "Incorrect Login";
            }
        }

        public void RunProgram()
        {
            Form_Login loginStaffUI = new Form_Login(this);
            loginStaffUI.Show();


        }
    }
}
