using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EXOProject.Data
{
    public class CustomerCRUD
    {
        public Cust getCustomerbyID(int custID)
        {
            using (HotelDBEntities cntx = new HotelDBEntities())
            {
                Cust customer = cntx.Custs.FirstOrDefault(m => m.CID == custID);
                if (customer != null)
                    return customer;
                else return null;
            }
        }

        public Cust getCustomerbyUID(int userID)
        {
            using (HotelDBEntities cntx = new HotelDBEntities())
            {
                Cust customer = cntx.Custs.FirstOrDefault(m => m.UID == userID);
                if (customer != null)
                    return customer;
                else return null;
            }
        }

        public Cust getCustomerbyPassport(string PassportNum)
        {
            using (HotelDBEntities cntx = new HotelDBEntities())
            {
                Cust customer = cntx.Custs.FirstOrDefault(m => m.Passport == PassportNum);
                if (customer != null)
                    return customer;
                else return null;
            }
        }

        public List<Cust> getAllCustomers()
        {
            using (HotelDBEntities cntx = new HotelDBEntities())
            {
                var customerList = from c in cntx.Custs
                                   select c;
                List<Cust> customers = customerList.ToList<Cust>();
                return customers;
            }
        }

        public Cust updateCustomer(Cust updCust)
        {
            using (HotelDBEntities cntx = new HotelDBEntities())
            {
                Cust customer = cntx.Custs.FirstOrDefault(m => m.CID == updCust.CID);
                customer.UID = updCust.UID;
                customer.Name = updCust.Name;
                customer.Age = updCust.Age;
                customer.Sex = updCust.Sex;
                customer.Mobile = updCust.Mobile;
                customer.Address = updCust.Address;
                customer.NOKName = updCust.NOKName;
                customer.NOKContact = updCust.NOKContact;
                customer.NOKAddress = updCust.NOKAddress;
                customer.Passport = updCust.Passport;

                cntx.SaveChanges();
                return updCust;
            }
        }

        public bool deleteCustomer(string custID)
        {
            using (HotelDBEntities cntx = new HotelDBEntities())
            {
                int temp = Convert.ToInt32(custID);
                Cust customer = cntx.Custs.FirstOrDefault(m => m.CID == temp);
                cntx.Custs.Remove(customer);
                cntx.SaveChanges();
                return true;
            }
        }

        public Cust createCustomer(Cust crCustomer)
        {
            using (HotelDBEntities cntx = new HotelDBEntities())
            {
                cntx.Custs.Add(crCustomer);
                cntx.SaveChanges();
                return crCustomer;
            }
        }
    }
}