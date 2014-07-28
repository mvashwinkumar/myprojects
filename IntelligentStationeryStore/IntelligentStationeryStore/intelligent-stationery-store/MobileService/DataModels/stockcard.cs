using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.ServiceModel.Configuration;
using MobileService;
using com.iss.inventory;
using com.iss.inventory.Entity;
using com.iss.inventory.CustomModels;

namespace MobileService
{

    [DataContract]
    public class StockCardMobile
    {
        
        stockCardDetailsMobile[] stockCardDetails;
        StationeryItemMobile item;
        int month;
        int year;

        public static StockCardMobile Make(int month, int year)
            {
                StockCardMobile s = new StockCardMobile();
                s.month = month;
                s.year = year;
                
                return s;
            }

        [DataMember]
            public int Month
            {
                get { return month; }
                set { month = value; }
            }

            [DataMember]
            public int Year
            {
                get { return year; }
                set { year = value; }
            }
            [DataMember]

            public StationeryItemMobile Item
            {
                get { return item; }
                set { item = value; }
            }


            [DataMember]

            public stockCardDetailsMobile[] Stockcarddetails 
            {
                get { return stockCardDetails; }
                set { stockCardDetails = value; }
            }

            public static StockCardMobile convert(StockCardModel stockCard)
            {

                //StockCardMobile
                StockCardMobile s = new StockCardMobile();
                s.month = stockCard.getMonth();
                s.year = stockCard.getYear();
               // StationeryItemMobile item = new StationeryItemMobile();
                s.item = StationeryItemMobile.convert(stockCard.getItem());
                s.stockCardDetails = stockCardDetailsMobile.convertList(stockCard.getStockCardDetails()).ToArray<stockCardDetailsMobile>();
               // return s;
                return s;
            }

    }
           
}