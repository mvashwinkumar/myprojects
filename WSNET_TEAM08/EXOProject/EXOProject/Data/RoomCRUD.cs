using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EXOProject.Data
{
    public class RoomCRUD
    {
        public Room getRoombyID(int roomID)
        {
            using (HotelDBEntities cntx = new HotelDBEntities())
            {
                Room room = cntx.Rooms.FirstOrDefault(m => m.RID == roomID);
                if (room != null)
                    return room;
                else return null;
            }
        }

        public List<Room> getRoomsbyType(string sType)
        {
            using (HotelDBEntities cntx = new HotelDBEntities())
            {
                var roomList = from r in cntx.Rooms
                               where r.Type == sType
                               select r;
                List<Room> rooms =    roomList.ToList<Room>();
                return rooms;
            }
        }

        public Room updateRoom(Room updRoom)
        {
            using (HotelDBEntities cntx = new HotelDBEntities())
            {
                Room room = cntx.Rooms.FirstOrDefault(m => m.RID == updRoom.RID);
                room.Name = updRoom.Name;
                room.Capacity = updRoom.Capacity;
                room.Summary = updRoom.Summary;
                room.Amenities = updRoom.Amenities;
                room.Price = updRoom.Price;
                room.Type = updRoom.Type;
                cntx.SaveChanges();
                return room;
            }
        }

        public bool deleteRoom(string roomID)
        {
            using (HotelDBEntities cntx = new HotelDBEntities())
            {
                int temp = Convert.ToInt32(roomID);
                Room room = cntx.Rooms.FirstOrDefault(m => m.RID == temp);
                cntx.Rooms.Remove(room);
                cntx.SaveChanges();
                return true;
            }
        }

        public Room createRoom(Room crRoom)
        {
            using (HotelDBEntities cntx = new HotelDBEntities())
            {
                cntx.Rooms.Add(crRoom);
                cntx.SaveChanges();
                return crRoom;
            }
        }

        public Room getRoombyName(string roomName, string roomType)
        {
            using (HotelDBEntities cntx = new HotelDBEntities())
            {
                Room room = cntx.Rooms.FirstOrDefault(m => m.Name==roomName && m.Type == roomType);
                if (room != null)
                    return room;
                else return null;
            }
        }
    }
}