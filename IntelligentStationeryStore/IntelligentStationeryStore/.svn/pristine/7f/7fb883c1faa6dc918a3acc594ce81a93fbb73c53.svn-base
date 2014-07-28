using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using com.iss.inventory.Entity;


namespace com.iss.inventory.Controllers
{
    public class DepartmentMaintenanceController
    {
        public List<String> getAllDeptID() {
            InvManagementEntities IME = new InvManagementEntities();
            var result = from department in IME.Departments
                         select new { department.DeptID };
            List<String> allDeptID = new List<String>();
            foreach (var s in result.ToList())
            {
                allDeptID.Add(s.DeptID.ToString());
            }
            return allDeptID;
        }
        //used by all
        public String[] getDeptByID(String txtDeptID) {
            InvManagementEntities IME = new InvManagementEntities();
            var dID = Convert.ToInt32(txtDeptID);
            Department d = IME.Departments.First<Department>(x => x.DeptID == dID);
            Employee h = IME.Employees.First<Employee>(y => y.EmployeeID == d.HeadID);
            Employee r = IME.Employees.First<Employee>(z => z.EmployeeID == d.RepresentativeID);
            String[] department = { Convert.ToString(d.DeptID), d.DeptName, d.ContactName, Convert.ToString(d.Phone), Convert.ToString(d.Fax), h.Name, d.CollectionPoint, r.Name };
            return department;
        }

        public String[] getPrevDept(String txtDeptID) {
            return getDeptByID(txtDeptID);
        }

        public String[] getNextDept(String txtDeptID) {
            return getDeptByID(txtDeptID);
        }

        public String createDept(String txtDeptName, String txtContactName, String txtPhone,String txtFax, String txtHeadID, String txtCollectionPoint, String txtRepresentativeID)
        {
            InvManagementEntities IME = new InvManagementEntities();
            List<String> allDeptID = getAllDeptID();
            //duplication checking
            foreach (String s in allDeptID)
            {
                var ID = Convert.ToInt32(s);
                Department d= IME.Departments.First<Department>(x => x.DeptID == ID);
                if (d.DeptName == txtDeptName) return "* This department already exist, please enter a new one";
            }
            //existence checking
            Employee h = IME.Employees.First<Employee>(y => y.Name == txtHeadID);
            Employee r = IME.Employees.First<Employee>(z => z.Name == txtRepresentativeID);
            if (h == null) return "* The department head's you enter in does not exist, please enter a new one";
            if (r == null) return "* The representative's you enter in does not exist, please enter a new one";
            //main function
            Department department = new Department();
            department.DeptName = txtDeptName; department.ContactName = txtContactName; department.Phone = Convert.ToInt32(txtPhone); department.Fax = Convert.ToInt32(txtFax); department.HeadID = h.EmployeeID; department.CollectionPoint = txtCollectionPoint; department.RepresentativeID = r.EmployeeID;
            IME.AddToDepartments(department);
            IME.SaveChanges();
            return "Create Department Successfully";
        }

        public String deleteDept(String txtDeptID) {
            InvManagementEntities IME = new InvManagementEntities();
            var dID = Convert.ToInt32(txtDeptID);
            Department d = IME.Departments.First<Department>(x => x.DeptID == dID);
            if (d != null) {
                IME.DeleteObject(d);
                IME.SaveChanges();
            }
            return "Delete Department Successfully";
        }

        public String updateDept(String txtDeptID, String txtDeptName, String txtContactName, String txtPhone, String txtFax, String txtHeadID, String txtCollectionPoint, String txtRepresentativeID)
        {
            InvManagementEntities IME = new InvManagementEntities();
            List<String> allDeptID = getAllDeptID();
            //duplication checking
            foreach (String s in allDeptID)
            {
                var ID = Convert.ToInt32(s);
                Department d = IME.Departments.First<Department>(x => x.DeptID == ID);
                if (d.DeptID == Convert.ToInt32(txtDeptID)) { continue; }
                if (d.DeptName == txtDeptName) return "* This department already exist, please enter a new one";
            }
            //existing checking
            Employee h; Employee r;
            try {
                h = IME.Employees.First<Employee>(y => y.Name == txtHeadID);
            }
            catch (Exception ex) { 
                return "* The department head's you enter in does not exist, please enter a new one";
            }
            try
            {
                r = IME.Employees.First<Employee>(z => z.Name == txtRepresentativeID);
            }
            catch (Exception ex)
            {
                return "* The representative's you enter in does not exist, please enter a new one";
            }
            //main function
            var tempID=Convert.ToInt32(txtDeptID);
            Department department = IME.Departments.First<Department>(x => x.DeptID == tempID);
            department.DeptName = txtDeptName; department.ContactName = txtContactName; department.Phone = Convert.ToInt32(txtPhone); department.Fax = Convert.ToInt32(txtFax); department.HeadID = h.EmployeeID; department.CollectionPoint = txtCollectionPoint; department.RepresentativeID = r.EmployeeID;
            IME.SaveChanges();
            return "Update Department Successfully";
        }

        public List<String> getAllDeptName() {
            InvManagementEntities IME = new InvManagementEntities();
            var result = from department in IME.Departments
                         select new { department.DeptName };
            List<String> allDeptName = new List<String>();
            foreach (var s in result.ToList())
            {
                allDeptName.Add(s.DeptName.ToString());
            }
            return allDeptName;
        }
    }
}
