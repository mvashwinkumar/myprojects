using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.iss.inventory.CustomModels
{
    public class StockCardDetailsModel
    {
        DateTime date;
        String category;
        String name;
        int quantity;
        int balance;

        public string Name{
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

        public int Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }

        public String getCategory()
        {
            return category;
        }

        public void setCategory(String cat)
        {
            category = cat;
        }

        public String getName() {
            return name;
        }

        public void setName(String name) {
            this.name = name;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public DateTime getDate()
        {
            return date;
        }

        public void setDate(DateTime date)
        {
            this.date = date;
        }

    }
}
