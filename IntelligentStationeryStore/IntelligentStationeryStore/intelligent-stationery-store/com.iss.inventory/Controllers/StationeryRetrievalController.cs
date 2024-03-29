﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.iss.inventory.Entity;
using com.iss.inventory.CustomModels;

namespace com.iss.inventory.Controllers
{
    public class StationeryRetrievalController
    {
        InvManagementEntities em;
        
        public List<SRFDetail> getIncompleteRequestsforSRF()
        {
            var incompleteRequestsList = from req in em.RequestDetails
                                               where (req.RequestList.Status == "Approved") || (req.RequestList.Status == "DeliveryInProgress")
                                               orderby req.ItemID, req.RequestList.Status, req.RequestList.DateReceived
                                               select req;
            //request details ordered by item, status and approved date
            List<RequestDetail> rqDetList = incompleteRequestsList.ToList<RequestDetail>();
            List<RequestListSuggestionModel> rqDetSugList = new List<RequestListSuggestionModel>();
            
            foreach (RequestDetail temp_rd in rqDetList)
            {
                RequestListSuggestionModel model = new RequestListSuggestionModel();
                model.setReqDetail(temp_rd);
                int temp_sugQty = Convert.ToInt32(temp_rd.QtyRequested - temp_rd.QtyDelivered);
                //initially suggested amount is based on outstanding qty of each req details
                model.setSuggestionQty(temp_sugQty);
                rqDetSugList.Add(model);
            }

            int temp_itemId = Convert.ToInt32(rqDetSugList[0].getReqDetail().StationeryItem.ItemID);
            int temp_itemAvailQty = Convert.ToInt32(rqDetSugList[0].getReqDetail().StationeryItem.QtyLeft);
            //check suggestion qty
            foreach (RequestListSuggestionModel temp_rds in rqDetSugList)
            {
                if (temp_itemId != temp_rds.getReqDetail().StationeryItem.ItemID)//for next item
                {
                    temp_itemId = temp_rds.getReqDetail().StationeryItem.ItemID;
                    temp_itemAvailQty = Convert.ToInt32(temp_rds.getReqDetail().StationeryItem.QtyLeft);
                }

                if (temp_rds.getSuggestionQty() >= temp_itemAvailQty) //if sufficient stock available
                    temp_itemAvailQty -= temp_rds.getSuggestionQty();
                else  //if insufficient stock, set available stock to zero and give all to existing reqdet
                {
                    temp_rds.setSuggestionQty(temp_itemAvailQty);
                    temp_itemAvailQty = 0;
                }
            }

            //re-order list to suit display by department
            //order by item,department,status and approved date
            var temp_rqds = from r in rqDetSugList
                            orderby r.getReqDetail().StationeryItem.ItemID, r.getReqDetail().RequestList.Employee.DeptID, r.getReqDetail().RequestList.Status, r.getReqDetail().RequestList.DateReceived
                            select r;
            rqDetSugList = temp_rqds.ToList<RequestListSuggestionModel>();

            List<SRFDetail> unsaved_SrfDetailsList = new List<SRFDetail>();
            //create SRF Details from requestDetails list
            int temp_itemID = 0;
            int temp_deptID = 0;
            SRFDetail temp_srfDetail = new SRFDetail();
            foreach (RequestListSuggestionModel temp_rds in rqDetSugList)
            {
                if (!((temp_itemID == temp_rds.getReqDetail().ItemID) && (temp_deptID == temp_rds.getReqDetail().RequestList.Employee.DeptID)))
                {
                    //for creating new SRF Details row
                    temp_srfDetail = new SRFDetail();
                    temp_srfDetail.Department = temp_rds.getReqDetail().RequestList.Employee.Department;
                    
                    //temp_srfDetail.SRFRequestDetails = temp_rds.getReqDetail().SRFRequestDetails;

                    temp_srfDetail.Status = "new"; //list is not yet saved into database
                    temp_srfDetail.StationeryItem = temp_rds.getReqDetail().StationeryItem;
                    temp_srfDetail.QtyRequested = temp_rds.getReqDetail().QtyRequested - temp_rds.getReqDetail().QtyDelivered;
                    temp_srfDetail.QtyRetrieved = temp_rds.getSuggestionQty();
                    temp_srfDetail.CollectionPt = temp_srfDetail.Department.CollectionPoint;
                    temp_srfDetail.CollectionDateTime = System.DateTime.Now.AddDays(7); //needs algorithm to add upto specific day
                    temp_srfDetail.RepresentativeID = temp_srfDetail.Department.RepresentativeID;
                    unsaved_SrfDetailsList.Add(temp_srfDetail);
                    temp_itemID = Convert.ToInt32(temp_srfDetail.ItemID);
                    temp_deptID = Convert.ToInt32(temp_srfDetail.DeptID);
                }
                else
  
                {
                    //for existing SRF Details row
                    int temp_qty = Convert.ToInt32(temp_rds.getReqDetail().QtyRequested - temp_rds.getReqDetail().QtyDelivered);
                    temp_srfDetail.QtyRequested += temp_qty;
                    temp_srfDetail.SRFRequestDetails = temp_rds.getReqDetail().SRFRequestDetails;
                    int temp_retQty = temp_rds.getSuggestionQty();
                    temp_srfDetail.QtyRetrieved += temp_retQty;
                }
                //add SRF Request detail for each request detail into database
                SRFRequestDetail srfrd = new SRFRequestDetail();
                srfrd.SRFDetail = temp_srfDetail;
                srfrd.RequestDetail = temp_rds.getReqDetail();
                em.AddToSRFRequestDetails(srfrd);
            }
            return unsaved_SrfDetailsList;
        }

        //SRF Details are only saved and a form number is generated, no changes to request details
        public bool saveSrfDetails(List<SRFDetail> srfDetailsList)
        {
            SRF srf;
            if (srfDetailsList[0].SRFID.Equals(null))
                srf = new SRF();
            else srf = srfDetailsList[0].SRF;

            srf.RFDate = System.DateTime.Now;
            srf.CreatedbyID = 0;//logged in employee ID is stored here from session
            srf.StatusforForm = "Created"; //list is not disbursed now, hence request details are not updated
            em.AddToSRFs(srf);
            em.SaveChanges();
            srf = em.SRFs.LastOrDefault();

            foreach (SRFDetail srfd in srfDetailsList)
            {
                srfd.SRF = srf;
                em.AddToSRFDetails(srfd);
            }
            return em.SaveChanges()>0;
            
        }

        public SRF getSRF(int srfId)
        {
            var srfVal = from s in em.SRFs
                         where s.SRFID == srfId
                         select s;
            return (SRF)srfVal;
        }

        public void updateStationeryRequestFormsStatus(List<RequestDetail> requestDetailsList)
        {
            var temp_reqList = requestDetailsList.Select(r=>r.RequestList).Distinct();

            List<RequestList> reqList = temp_reqList.ToList<RequestList>();

            foreach (RequestList rl in reqList)
            {
                bool isIncomplete = false;
                foreach (RequestDetail rd in rl.RequestDetails)
                {
                    if (rd.QtyRequested != rd.QtyDelivered)
                    {
                        isIncomplete = true;
                        break;
                    }
                }

                if (!isIncomplete) rl.Status = "Delivered"; 
            }
        }

        public void generateDisbursementList(List<SRFDetail> srfDetailsList)  //need to write the code further, after confirming with ben
        {
            //4 stages:
            //1.update stock card of all items
            //2a.get request details of all stationery retrievals and update using suggestion logic
            //2b.update request IDs status as per delivery completed
            //3.change srf status to disbursed
            //4.send e-mail to all concerned employees of the latest disbursement list (need new function)

            foreach (SRFDetail srfd in srfDetailsList)
            {
                srfd.CollectionPt = srfd.Department.CollectionPoint;
                srfd.CollectionDateTime = System.DateTime.Now.AddDays(7); //needs algorithm to add upto specific day
                srfd.RepresentativeID = srfd.Department.RepresentativeID;

                StationeryItem item = em.StationeryItems.FirstOrDefault(x => x.ItemID == srfd.ItemID);
                item.QtyLeft -= srfd.QtyRetrieved;

                //order request details of particular srf details by status and date
                var temp_srfReqDetails = from s in em.SRFRequestDetails
                                         where s.SRFDetailsID == srfd.SRFDetailsID
                                         select s;

                var temp_ReqDetList = from s in temp_srfReqDetails
                                      orderby s.RequestDetail.RequestList.Status, s.RequestDetail.RequestList.DateReceived
                                      select s.RequestDetail;
                List<RequestDetail> requestDetailsList = temp_ReqDetList.ToList<RequestDetail>();

                int temp_srfdqty = Convert.ToInt32(srfd.QtyRetrieved);
                
                //update request details qty as requested with retrieved qty
                foreach (RequestDetail rd in requestDetailsList)
                {
                    int temp_rdQty = Convert.ToInt32(rd.QtyRequested - rd.QtyDelivered);
                    if (temp_srfdqty >= temp_rdQty) // sufficient stock available
                    {
                        rd.QtyDelivered = rd.QtyRequested;
                        temp_srfdqty -= temp_rdQty;
                    }
                    else //insufficient stock available
                    {
                        rd.QtyDelivered += temp_srfdqty;
                        temp_srfdqty = 0;
                    }

                }

                //check for updating Stationery Request Form Status
                updateStationeryRequestFormsStatus(requestDetailsList);
            }

            SRF srf = srfDetailsList[0].SRF;
            srf.StatusforForm = "Disbursed";

            em.SaveChanges();
            //send e-mails
            foreach (SRFDetail srfd in srfDetailsList)
            {
                int headID = Convert.ToInt32(srfd.Department.HeadID);
                int representativeID = Convert.ToInt32(srfd.Department.RepresentativeID);
                //email_DisbursementList(headID,representativeID,srfd.SRFID); Function from e-mail controller
            }
        }
    }
}
