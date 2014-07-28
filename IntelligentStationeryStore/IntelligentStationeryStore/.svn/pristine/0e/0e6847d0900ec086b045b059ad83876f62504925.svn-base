using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.iss.inventory.CustomModels;
using com.iss.inventory.BusinessLogic;
using com.iss.inventory.Entity;

namespace com.iss.inventory.Controllers
{
    public class StockCardController
    {
        InvManagementEntities em = new InvManagementEntities();
        SearchController searchcontrol = new SearchController();
        SearchItemsModel model = new SearchItemsModel();

        public StockCardModel getStockCardbyItemId(string itemId)
        {
            model.getCriteriaList().Add("");
            model.getCriteriaList().Add(itemId.Trim());

            model = searchcontrol.getSearchByItemID(model);
            StationeryItem item = model.getStationeryItemsList()[0];

            List<SRFDetail> item_srfd = em.SRFDetails.Where(x => x.ItemID == item.ItemID).ToList<SRFDetail>();
            List<PurchaseOrderDetail> item_pod = em.PurchaseOrderDetails.Where(x => x.ItemID == item.ItemID).ToList<PurchaseOrderDetail>();
            List<AdjVoucherDetail> item_adjvd = em.AdjVoucherDetails.Where(x => x.ItemID == item.ItemID).ToList<AdjVoucherDetail>();

            List<StockCardDetailsModel> stockCardDetailsModelList = new List<StockCardDetailsModel>();

            foreach (SRFDetail srfd in item_srfd)
            {
                StockCardDetailsModel scdm = new StockCardDetailsModel();
                scdm.setDate(Convert.ToDateTime(srfd.SRF.RFDate));
                scdm.setCategory("Department");
                scdm.setName(srfd.Department.DeptName);
                scdm.setQuantity(Convert.ToInt32(srfd.QtyRetrieved)*(-1));
                stockCardDetailsModelList.Add(scdm);
            }
            foreach (PurchaseOrderDetail pod in item_pod)
            {
                StockCardDetailsModel scdm = new StockCardDetailsModel();
                scdm.setDate(Convert.ToDateTime(pod.PurchaseOrder.DeliveryOrder.DateDelivered));
                scdm.setCategory("Supplier");
                scdm.setName(pod.PurchaseOrder.Supplier.Name);
                scdm.setQuantity(Convert.ToInt32(pod.Qty));
                stockCardDetailsModelList.Add(scdm);
            }
            foreach (AdjVoucherDetail adjvd in item_adjvd)
            {
                if (adjvd.AdjustID != null)
                {
                    StockCardDetailsModel scdm = new StockCardDetailsModel();
                    scdm.setDate(Convert.ToDateTime(adjvd.AdjVoucher.DateIssued));
                    scdm.setCategory("Stock Adjustment");
                    scdm.setName("Voucher " + adjvd.AdjustID);
                    scdm.setQuantity(Convert.ToInt32(adjvd.QtyAdjust));
                    stockCardDetailsModelList.Add(scdm);
                }
            }

            stockCardDetailsModelList.OrderByDescending(x => x.getDate());
            int itemBalance = Convert.ToInt32(item.QtyLeft);
            foreach (StockCardDetailsModel scdm in stockCardDetailsModelList)
            {
                if (scdm.Quantity >= 0) itemBalance -= scdm.Quantity;
                else itemBalance += scdm.Quantity;
                scdm.Balance = itemBalance;
            }
            DateTime startDate = System.DateTime.Now.AddDays(-30);
            DateTime endDate = System.DateTime.Now;
            stockCardDetailsModelList.Where(x => x.Date < endDate && x.Date > startDate);

            StockCardModel stockCard = new StockCardModel();
            stockCard.setStockCardDetails(stockCardDetailsModelList);
            stockCard.setItem(item);

            return stockCard;
        }

        public List<SupplierPriceList> getSupplierInfobyItemId(string itemId)
        {
            int itemID = Convert.ToInt32(itemId);
            var supplierList_item = from spl in em.SupplierPriceLists
                                    where spl.ItemID == itemID
                                    select spl;
            return supplierList_item.ToList<SupplierPriceList>();
        }
    }
}
