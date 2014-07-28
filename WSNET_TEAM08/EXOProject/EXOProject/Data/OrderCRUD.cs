using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EXOProject.Data
{
    public class OrderCRUD
    {
        public Order getOrderbyID(string orderID)
        {
            using (HotelDBEntities cntx = new HotelDBEntities())
            {
                int temp = Convert.ToInt32(orderID);
                Order order = cntx.Orders.FirstOrDefault(m => m.OID == temp);
                if (order != null)
                    return order;
                else return null;
            }
        }

        public List<Order> getOrdersbyCustID(string custID)
        {
            using (HotelDBEntities cntx = new HotelDBEntities())
            {
                int temp = Convert.ToInt32(custID);
                var orderList = from o in cntx.Orders
                                where o.CID == temp
                                select o;
                List<Order> orders = orderList.ToList<Order>();
                return orders;
            }
        }

        public List<Order> getOrdersbyRoomID(string roomID)
        {
            int intRoomID = Convert.ToInt32(roomID);
            using (HotelDBEntities cntx = new HotelDBEntities())
            {
                var orderList = from o in cntx.Orders
                                where o.RID == intRoomID
                                select o;
                List<Order> orders = orderList.ToList<Order>();
                return orders;
            }
        }

        public Order updateOrder(Order updOrder)
        {
            using (HotelDBEntities cntx = new HotelDBEntities())
            {
                Order order = cntx.Orders.FirstOrDefault(m => m.OID == updOrder.OID);
                order.RID = updOrder.RID;
                order.CID = updOrder.CID;
                order.DateIn = updOrder.DateIn;
                order.DateOut = updOrder.DateOut;
                order.PaxCount = updOrder.PaxCount;
                order.RoomCount = updOrder.RoomCount;
                order.SpecialRequest = updOrder.SpecialRequest;

                cntx.SaveChanges();
                return updOrder;
            }
        }

        public bool deleteOrder(string orderID)
        {
            using (HotelDBEntities cntx = new HotelDBEntities())
            {
                int temp = Convert.ToInt32(orderID);
                Order order = cntx.Orders.FirstOrDefault(m => m.OID == temp);
                cntx.Orders.Remove(order);
                cntx.SaveChanges();
                return true;
            }
        }

        public Order createOrder(Order crOrder)
        {
            using (HotelDBEntities cntx = new HotelDBEntities())
            {
                cntx.Orders.Add(crOrder);
                cntx.SaveChanges();
                return crOrder;
            }
        }
    }
}