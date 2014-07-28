using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.ServiceModel.Configuration;
using System.Web.Configuration;
using System.ServiceModel.Activation;
using com.iss.inventory.Controllers;
using com.iss.inventory.Entity;
using com.iss.inventory.CustomModels;
using MobileService.DataModels;


namespace MobileService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class Service1 : IService1
   {

       StockCardController stockCardControl = new StockCardController();
        UserMaintenanceController empControl = new UserMaintenanceController();
        ViewAdjVoucherController adjVoucherControl = new ViewAdjVoucherController();
        ApproveAdjVoucherController approveAdjVoucherControl = new ApproveAdjVoucherController();


       public string[] empDetails(string id)
       {
           //return new string[]{"1","1"}; 
           return empControl.getEmpByID(id);
       }

        //string GetData(int value);
       public AdjVoucherMobile GetAdjVoucherDetails(string adjustid)
       {
           List<VoucherDetailsModel> voucherDetailsList = adjVoucherControl.getVoucherByAdjustID(adjustid);
           AdjVoucher adjVoucher = adjVoucherControl.getAdjVoucher(adjustid);
           return AdjVoucherMobile.convert(adjVoucher, voucherDetailsList);
       }

       public AdjVoucherDetailsMobile[] GetPendingAdjVoucherDetails()
       {
           List<VoucherDetailsModel> voucherDetailsList = approveAdjVoucherControl.getAllPendingVouchers();
           List<AdjVoucherDetailsMobile> adjVoucherDetailsListMobile = AdjVoucherDetailsMobile.convertList(voucherDetailsList);
           return adjVoucherDetailsListMobile.ToArray<AdjVoucherDetailsMobile>();
       }

       public string DeleteAdjVoucherDetails(int adjvdid)
       {
           string feedback = approveAdjVoucherControl.deletePendingVoucher(adjvdid);
           return feedback;
       }

       public string ApproveAdjVoucherDetails(string empid, List<int> voucherList)
       {
           DateTime currentTime = System.DateTime.Now;
           string feedback = approveAdjVoucherControl.approvePendingVoucher(voucherList, empid, currentTime);
           return feedback;
       }

       public string GetData()
       {
           return string.Format("You entered: {0}", "KMB");
       }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
               throw new ArgumentNullException("composite");
           }
           if (composite.BoolValue)
           {
               composite.StringValue += "Suffix";
           }
            return composite;
        }

        public StockCardMobile GetStockCardDetails(string itemid)
        {
            StockCardModel stockCard = stockCardControl.getStockCardbyItemId(itemid);
            StockCardModel newCard = new StockCardModel();
            newCard.setYear(stockCard.getYear());
            newCard.setMonth(stockCard.getMonth());
            StationeryItem newItem = new StationeryItem();
            
            StockCardMobile stockCardMobile = StockCardMobile.convert(stockCard);
            return stockCardMobile;
        }
    }
}
