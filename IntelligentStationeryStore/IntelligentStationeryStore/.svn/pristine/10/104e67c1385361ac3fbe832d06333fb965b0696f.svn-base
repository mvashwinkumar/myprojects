using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.iss.inventory;
using com.iss.inventory.Entity;
using com.iss.inventory.CustomModels;

namespace com.iss.inventory.Controllers
{
    public class StationeryRequestController
    {
        private InvManagementEntities invManEn;
        public StationeryRequestController()
        {
            invManEn = new InvManagementEntities();
           
        }
        public int InsertStationeryRequest(RequestListModel rlm)
        {
            RequestList rl = new RequestList();
            rl.EmployeeID = rlm.EmployeeID;
            rl.ApprovedbyID = rlm.ApproveID;
            //rl.DateSubmitted = rlm.DateReceieve;
            rl.DateSubmitted = DateTime.Now;
            rl.DateReceived = null;
            rl.SpecialRequest = rlm.SpecialRequest;
            rl.Status = rlm.Status;
            rl.Remarks = null;
            invManEn.RequestLists.AddObject(rl);
            invManEn.SaveChanges();

            var lastrequestID = (from s in invManEn.RequestLists orderby s.RequestID descending select s).FirstOrDefault<RequestList>();
            return lastrequestID.RequestID;
        }
        public int ReterieveLastOutput()
        {
             return (from s in invManEn.RequestLists orderby s.RequestID descending select s.RequestID).First();
        }

        public void AddRequestListDetails(int requestListID,string description,int qty)
        {
            int itemId= (from s in invManEn.StationeryItems where s.Description == description select s.ItemID).First();
            RequestDetail requestDetail = new RequestDetail();
            requestDetail.RequestID = requestListID;
            requestDetail.ItemID = itemId;
            requestDetail.QtyRequested = qty;
            requestDetail.QtyDelivered = 0;
            invManEn.RequestDetails.AddObject(requestDetail);
            invManEn.SaveChanges();

        }

        
    }
}
