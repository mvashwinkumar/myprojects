    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using com.iss.inventory.Entity;

    namespace com.iss.inventory.Controllers
    {
    public class LoginController
    {
        private InvManagementEntities invManEn;
        private Employee emp;
        private Department dep;

            public LoginController()
        {
            invManEn = new InvManagementEntities();
        }

        public List<string> Login(String username,String password)
        {
            List<string> res = new List<string>();
             emp= (from e in invManEn.Employees where e.Name == username && e.Password == password select e).FirstOrDefault<Employee>();
             if (emp != null)
             {

                 string empID = emp.EmployeeID.ToString();
                 res.Add(empID);
                 string role = getRole(emp.EmployeeID);
                  res.Add(role);
                  string department = getDepName((int)emp.DeptID);
                  res.Add(department);
                   string headid = getHeadID((int)emp.DeptID).ToString();
                  res.Add(headid);

                 return res;
             }
             else
             {
                 string errormsg="UserName and password are incorrected";
                 res.Add(errormsg);
                 return res;
             }
        }

        public String getRole(int EmployeeID )
        {
            if (emp.Role == "Employee")
            {
                return getDepName((int)emp.DeptID);

            }
            else
            {
                return emp.Role;
            }
        }
        public String getDepName(int departmentID)
        {
          
            dep = (from d in invManEn.Departments where d.DeptID==departmentID select d).FirstOrDefault();
             return dep.DeptName;
         }
        public int getHeadID(int departmentID)
        {
            return (int)(from d in invManEn.Departments where d.DeptID==departmentID select d.HeadID).First();
        }
       
    }
    }
