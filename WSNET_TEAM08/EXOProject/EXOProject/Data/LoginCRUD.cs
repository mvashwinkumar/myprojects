using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EXOProject.Data
{
    public class LoginCRUD
    {
        public Login getUserbyID(int userID)
        {
            using (HotelDBEntities cntx = new HotelDBEntities())
            {
                Login user = cntx.Logins.FirstOrDefault(m => m.UID == userID);
                if (user != null)
                    return user;
                else return null;
            }
        }
        public Login getUserbyName(string userName)
        {
            using (HotelDBEntities cntx = new HotelDBEntities())
            {
                Login user = cntx.Logins.FirstOrDefault(m => m.UserName == userName);
                if (user != null)
                    return user;
                else return null;
            }
        }

        public List<Login> getAllUsers()
        {
            using (HotelDBEntities cntx = new HotelDBEntities())
            {
                var userList = from u in cntx.Logins
                                   select u;
                List<Login> users = userList.ToList<Login>();
                return users;
            }
        }

        public Login updateUser(Login updUser)
        {
            using (HotelDBEntities cntx = new HotelDBEntities())
            {
                Login user = cntx.Logins.FirstOrDefault(m => m.UID == updUser.UID);
                user.UserName = updUser.UserName;
                user.Password = updUser.Password;
                user.Security_Question = updUser.Security_Question;
                user.Answer = updUser.Answer;
                user.Type = updUser.Type;
                cntx.SaveChanges();
                return updUser;
            }
        }

        public bool deleteUser(string userID)
        {
            using (HotelDBEntities cntx = new HotelDBEntities())
            {
                int temp = Convert.ToInt32(userID);
                Login user = cntx.Logins.FirstOrDefault(m => m.UID == temp);
                cntx.Logins.Remove(user);
                cntx.SaveChanges();
                return true;
            }
        }

        public Login createUser(Login crUser)
        {
            using (HotelDBEntities cntx = new HotelDBEntities())
            {
                cntx.Logins.Add(crUser);
                cntx.SaveChanges();
                return crUser;
            }
        }
    }
}