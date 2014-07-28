using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EXOProject.Service
{
    public class UserAccountService
    {
        private EXOProject.Data.CustomerCRUD customerCRUD = new Data.CustomerCRUD();
        private EXOProject.Data.RoomCRUD roomCRUD = new Data.RoomCRUD();
        private EXOProject.Data.LoginCRUD loginCRUD = new Data.LoginCRUD();
        private EXOProject.Data.OrderCRUD orderCRUD = new Data.OrderCRUD();

        public Cust getCustomerInfo(int customerID)
        {
            Cust customerData = customerCRUD.getCustomerbyID(customerID);
            return customerData;
        }

        public Cust getCustomerInfobyUID(int userID)
        {
            Cust customerData = customerCRUD.getCustomerbyUID(userID);
            return customerData;
        }

        public void createNewCustomer(Cust newCustomer)
        {
            if (!isExistingCustomer(newCustomer.Passport))
            {
                Cust tempCust = customerCRUD.createCustomer(newCustomer);
                if (tempCust != null)
                    Console.WriteLine("Created Successfully");
                else Console.WriteLine("Create Failed");
            }
        }
        public bool isExistingCustomer(string PassportNum)
        {
            Cust tempCust = customerCRUD.getCustomerbyPassport(PassportNum.ToUpper());
            if (tempCust != null) return true;
            else return false;
        }


        public void updateCustomerInfo(Cust updCustomer)
        {
            Cust tempCust = customerCRUD.updateCustomer(updCustomer);
            if (tempCust != null)
                Console.WriteLine("Updated Successfully");
            else Console.WriteLine("Update Failed");
        }

        public void deleteCustomerInfo(string custID)
        {
            if (customerCRUD.deleteCustomer(custID))
                Console.WriteLine("Deleted Successfully");
            else Console.WriteLine("Delete Failed");
        }

        public Room getRoomInfo(int roomID)
        {
            Room roomData = roomCRUD.getRoombyID(roomID);
            return roomData;
        }

        public Room getRoomInfo(string roomName, string roomType)
        {
            Room roomData = roomCRUD.getRoombyName(roomName,roomType);
            return roomData;
        }


        public void createNewRoom(Room newRoom)
        {
            Room tempRoom = roomCRUD.createRoom(newRoom);
            if (tempRoom != null)
                Console.WriteLine("Created Successfully");
            else Console.WriteLine("Create Failed");
        }

        public List<Room> getRoomsbyType(string Type)
        {
            List<Room> roomsList = roomCRUD.getRoomsbyType(Type);
            return roomsList;
        }


        public void updateRoomInfo(Room updRoom)
        {
            Room tempRoom = roomCRUD.updateRoom(updRoom);
            if (tempRoom != null)
                Console.WriteLine("Updated Successfully");
            else Console.WriteLine("Update Failed");
        }

        public void deleteRoomInfo(string roomID)
        {
            if (roomCRUD.deleteRoom(roomID))
                Console.WriteLine("Deleted Successfully");
            else Console.WriteLine("Delete Failed");
        }

        public Login getLoginInfo(string userName)
        {
            Login loginData = loginCRUD.getUserbyName(userName);
            return loginData;
        }

        public Login getLoginInfo(int userID)
        {
            Login loginData = loginCRUD.getUserbyID(userID);
            return loginData;
        }

        public void createNewUser(Login newUser)
        {
            if (!isExistingUser(newUser.UserName))
            {
                Login tempUser = loginCRUD.createUser(newUser);
                if (tempUser != null)
                    Console.WriteLine("Created Successfully");
                else Console.WriteLine("Create Failed");
            }
        }

        public bool isExistingUser(string userName)
        {
            Login tempUser = loginCRUD.getUserbyName(userName);
            if (tempUser != null) return true;
            else return false;
        }

        public void updateUserInfo(Login updUser)
        {
            Login tempUser = loginCRUD.updateUser(updUser);
            if (tempUser != null)
                Console.WriteLine("Updated Successfully");
            else Console.WriteLine("Update Failed");
        }

        public void deleteUserInfo(string userID)
        {
            if (loginCRUD.deleteUser(userID))
                Console.WriteLine("Deleted Successfully");
            else Console.WriteLine("Delete Failed");
        }

        public List<Login> getAllUserDetails()
        {
            return loginCRUD.getAllUsers();
        }

        public Order getOrderInfo(string orderID)
        {
            Order orderData = orderCRUD.getOrderbyID(orderID);
            return orderData;
        }

        public int createNewOrder(Order newOrder)
        {
            Order tempOrder = orderCRUD.createOrder(newOrder);
            if (tempOrder != null)
                Console.WriteLine("Created Successfully");
            else Console.WriteLine("Create Failed");
            return tempOrder.OID;
        }

        public List<Order> getOrdersbyCriteria(string Cri, string ID)
        {
            List<Order> ordersList = null;
            if(Cri.ToUpper() == "CUSTID")
                ordersList = orderCRUD.getOrdersbyCustID(ID);
            if(Cri.ToUpper() == "ROOMID")
                ordersList = orderCRUD.getOrdersbyRoomID(ID);
            return ordersList;
        }

        public bool isRoomAvailable(int roomID, DateTime DateIn, DateTime DateOut, int roomCount)
        {
            List<Order> tempOrderList = getOrdersbyCriteria("ROOMID", roomID.ToString());
            int capacity = getRoomInfo(roomID).Capacity;
            int totalBooked = 0;
            foreach (Order o in tempOrderList)
            {
                if(isNotDateOverlap(o.DateIn,o.DateOut,DateIn,DateOut))
                    totalBooked++;
            }
            if(totalBooked<capacity) return true;
            else return false;
        }

        private bool isNotDateOverlap(DateTime DateIn1,DateTime DateOut1, DateTime DateIn2, DateTime DateOut2)
        {
            bool result = false;
            int cmp1 = DateIn1.CompareTo(DateOut2);
            int cmp2 = DateOut1.CompareTo(DateIn2);
            if (cmp1 >= 0 && cmp2 <= 0) result = true;
            return result;
        }

        public int getNumNightsCount(DateTime DateIn, DateTime DateOut)
        {
            TimeSpan ts = DateOut.Subtract(DateIn);
            int numdays = ts.Days;
            if (numdays == 0) numdays = 1;
            return numdays;
        }

        public void updateOrderInfo(Order updOrder)
        {
            Order tempOrder = orderCRUD.updateOrder(updOrder);
            if (tempOrder != null)
                Console.WriteLine("Updated Successfully");
            else Console.WriteLine("Update Failed");
        }

        public void deleteOrderInfo(string orderID)
        {
            if (orderCRUD.deleteOrder(orderID))
                Console.WriteLine("Deleted Successfully");
            else Console.WriteLine("Delete Failed");
        }

        public Login validateLoginDetails(string userName, string password)
        {
            Login chkLogin = getLoginInfo(userName);
            if (chkLogin.Password == password)
                return chkLogin;
            else return null;
        }

    }
}