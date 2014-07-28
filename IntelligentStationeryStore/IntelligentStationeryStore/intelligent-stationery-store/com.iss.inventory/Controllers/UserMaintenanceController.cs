using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.iss.inventory.Entity;

namespace com.iss.inventory.Controllers
{
    public class UserMaintenanceController
    {
        public UserMaintenanceController(){ }

        public List<String> getAllEmpID()
        {
            InvManagementEntities IME = new InvManagementEntities();
            var result = from employee in IME.Employees
                         select new { employee.EmployeeID };
            List<String> allEmpID = new List<String>();
            foreach (var s in result.ToList())
            {
                allEmpID.Add(s.EmployeeID.ToString());
            }
            return allEmpID;
        }

        public String[] getEmpByID(String txtEmpID)
        {
            InvManagementEntities IME = new InvManagementEntities();
            var eID = Convert.ToInt32(txtEmpID);
            Employee e = IME.Employees.First<Employee>(x => x.EmployeeID == eID);
            Department d = IME.Departments.First<Department>(y => y.DeptID==e.DeptID);
            String[] employee = { Convert.ToString(e.EmployeeID), e.Name, e.Role, Convert.ToString(e.DeptID), Convert.ToString(d.HeadID), Convert.ToString(e.Phone), e.Email };
            return employee;
        }

        public List<Employee> getAllEmployeesList()
        {
            InvManagementEntities IME = new InvManagementEntities();
            var empList = from e in IME.Employees
                          select e;
            return empList.ToList<Employee>();
        }

        public String[] getPrevItem(String txtEmpID)
        {
            return getEmpByID(txtEmpID);
        }

        public String[] getNextItem(String txtEmpID)
        {
            return getEmpByID(txtEmpID);
        }

        public String deleteEmp(String txtItemID)
        {
            InvManagementEntities IME = new InvManagementEntities();
            var eID = Convert.ToInt32(txtItemID);
            Employee i = IME.Employees.First<Employee>(x => x.EmployeeID == eID);
            if (i != null)
            {
                IME.DeleteObject(i);
                IME.SaveChanges();
            }
            return "Delete User Successfully";
        }

        public String updateEmp(String txtEmployeeID, String txtName, String ddlRole, String txtDeptID, String txtHeadId, String txtPhone, String txtEmail)
        {
            InvManagementEntities IME = new InvManagementEntities();
            List<String> allEmpID = getAllEmpID();
            //existence checking
            var dID = Convert.ToInt32(txtDeptID);
            var hID=Convert.ToInt32(txtHeadId);
            Department d = IME.Departments.First<Department>(y => y.DeptID == dID);
            Employee e = IME.Employees.First<Employee>(z => z.EmployeeID == hID);
            if ((e.Role=="Employee")||(e.Role=="Clerk")) return "* This employee does not have delegation limit, please enter a new one";
            if (d == null) return "* The department you enter in does not exist, please enter a new one";
            //main function
            var tempID = Convert.ToInt32(txtEmployeeID);
            Employee emp = IME.Employees.First<Employee>(x => x.EmployeeID == tempID);
            emp.Name = txtName; emp.Role = ddlRole; emp.DeptID = Convert.ToInt32(txtDeptID); emp.Phone = Convert.ToInt32(txtPhone); emp.Email = txtEmail;
            IME.SaveChanges();
            return "Update User Successfully";
        }
    }
}
