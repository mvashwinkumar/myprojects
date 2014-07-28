using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.ServiceModel.Configuration;
using com.iss.inventory.CustomModels;
using MobileService;

namespace MobileService
{
    [DataContract]
    public class stockCardDetailsMobile
    {
        //DateTime date;
        string dateTimeString;
        string category;
        string name;
        int quantity;
        int balance;

        public static stockCardDetailsMobile Make( string category, string name, int quantity, int balance)
        {
            stockCardDetailsMobile sc = new stockCardDetailsMobile();
            //sc.date = date;
            sc.category = category;
            sc.name = name;
            sc.quantity = quantity;
            sc.balance = balance;
            return sc;

        }

        //[DataMember]  do not use datetime object here
        //public DateTime Date
        //{
        //    get { return date; }
        //    set { date = value; }
        //}

        [DataMember]
        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        [DataMember]
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        [DataMember]
        public string DateTimeString
        {
            get { return dateTimeString; }
            set { dateTimeString = value; }
        }


        public static stockCardDetailsMobile convert(StockCardDetailsModel stockCardDetails)
        {
            stockCardDetailsMobile sc = new stockCardDetailsMobile();
            //sc.date = stockCardDetails.Date;
            sc.dateTimeString = stockCardDetails.Date.ToShortDateString();
            sc.category = stockCardDetails.Category;
            sc.name = stockCardDetails.Name;
            sc.quantity = stockCardDetails.Quantity;
            sc.balance = stockCardDetails.Balance;
            return sc;

        }

        public static List<stockCardDetailsMobile> convertList(List<StockCardDetailsModel> stockCardDetailsList)
        {
            List<stockCardDetailsMobile> stockCardDetails_Mobile = new List<stockCardDetailsMobile>();
            foreach (StockCardDetailsModel l_StockCardDetails in stockCardDetailsList)
            {
                stockCardDetails_Mobile.Add(convert(l_StockCardDetails));
            }
            return stockCardDetails_Mobile;
        }
    }
}


    

