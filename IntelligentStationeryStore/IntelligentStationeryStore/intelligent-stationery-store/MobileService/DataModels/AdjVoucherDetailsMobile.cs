using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using com.iss.inventory.CustomModels;
using com.iss.inventory.Controllers;
using com.iss.inventory.BusinessLogic;
using com.iss.inventory.Entity;

namespace MobileService.DataModels
{
    [DataContract] 
    public class AdjVoucherDetailsMobile
    {
        int adjVoucherDetailID;
        int itemID;
        string qtyAdj;
        string reason;
        double cost;

        [DataMember]
        public int AdjVoucherDetailID
        {
            get { return adjVoucherDetailID; }
            set { adjVoucherDetailID = value; }
        }

        [DataMember]
        public int ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }

        [DataMember]
        public string QtyAdj
        {
            get { return qtyAdj; }
            set { qtyAdj = value; }
        }

        [DataMember]
        public string Reason
        {
            get { return reason; }
            set { reason = value; }
        }

        [DataMember]
        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public static AdjVoucherDetailsMobile convert(VoucherDetailsModel adjVoucherDetail)
        {
            AdjVoucherDetailsMobile a = new AdjVoucherDetailsMobile();
            a.AdjVoucherDetailID = adjVoucherDetail.AdjVoucherDetailID;
            a.ItemID = adjVoucherDetail.ItemID;
            a.QtyAdj = adjVoucherDetail.QtyAdj;
            a.Reason = adjVoucherDetail.Reason;
            a.Cost = adjVoucherDetail.Cost;
            
            return a;
        }

        public static List<AdjVoucherDetailsMobile> convertList(List<VoucherDetailsModel> adjVoucherDetailsList)
        {
            List<AdjVoucherDetailsMobile> adjVoucherDetailsListMobile = new List<AdjVoucherDetailsMobile>();
            foreach (VoucherDetailsModel l_adjVoucherDetail in adjVoucherDetailsList)
            {
                adjVoucherDetailsListMobile.Add(convert(l_adjVoucherDetail));
            }
            return adjVoucherDetailsListMobile;
        }

    }

    [DataContract]
    public class AdjVoucherMobile
    {
        int adjustId;
        string approvalByName;
        int voucherId;
        string dateIssuedString;
        AdjVoucherDetailsMobile[] adjVoucherDetailsListMobile;
        

        [DataMember]
        public int AdjustId
        {
            get { return adjustId; }
            set { adjustId = value; }
        }

        [DataMember]
        public string ApprovalByName
        {
            get { return approvalByName; }
            set { approvalByName = value; }
        }

        [DataMember]
        public int VoucherId
        {
            get { return voucherId; }
            set { voucherId = value; }
        }

        [DataMember]
        public string DateIssuedString
        {
            get { return dateIssuedString; }
            set { dateIssuedString = value; }
        }

        [DataMember]
        public AdjVoucherDetailsMobile[] AdjVoucherDetailsListMobile
        {
            get { return adjVoucherDetailsListMobile; }
            set { adjVoucherDetailsListMobile = value; }
        }

        public static AdjVoucherMobile convert(AdjVoucher adjVoucher,List<VoucherDetailsModel> adjVoucherDetails)
        {
            AdjVoucherMobile a = new AdjVoucherMobile();

            a.AdjustId = adjVoucher.AdjustID;
            a.ApprovalByName = adjVoucher.Employee.Name;
            a.DateIssuedString = adjVoucher.DateIssued.ToString();
            a.VoucherId = Convert.ToInt32(adjVoucher.VoucherID);
            a.AdjVoucherDetailsListMobile = AdjVoucherDetailsMobile.convertList(adjVoucherDetails).ToArray<AdjVoucherDetailsMobile>();
            return a;
        }
    }
}