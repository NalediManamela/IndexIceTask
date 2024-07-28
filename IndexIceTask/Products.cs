using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexIceTask
{
    public class Products
    {
        private int productId;
        private string productName;
        private string category;
        private double price;
        private int stock;

        public Products(int productId, string productName, string category, double price, int stock)
        {
            this.productId = productId;
            this.productName = productName;
            this.category = category;
            this.price = price;
            this.stock = stock;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.productId;
                else if (index == 1)
                    return this.productName;
                else if (index == 2)
                    return this.category;
                else if (index == 3)
                    return this.price;
                else if (index == 4)
                    return this.stock;
                return null;

            }
            set
            {
                if (index == 0)
                    this.productId = (int)value;
                else if (index == 1)
                    this.productName = (string)value;
                else if (index == 2)
                    this.category = (string)value;
                else if (index == 3)
                    this.price = (double)value;
                else if (index == 4)
                    this.stock = (int)value;

            }
        }
        public object this[string attrName]
        {
            get
            {
                if (attrName.ToLower().Equals("Product ID"))
                    return this.productId;
                else if (attrName.ToLower().Equals("Product Name"))
                    return this.productName;
                else if (attrName.ToLower().Equals("Category"))
                    return this.category;
                else if (attrName.ToLower().Equals("Price"))
                    return this.price;
                else if (attrName.ToLower().Equals("Stock"))
                    return this.stock;
                return null;
            }
            set
            {
                if (attrName.ToLower().Equals("Product Id"))
                    this.productId = (int)value;
                if (attrName.ToLower().Equals("Procuct Name"))
                    this.productName = (string)value;
                if (attrName.ToLower().Equals("Category"))
                    this.category = (string)value;
                if (attrName.ToLower().Equals("Price"))
                    this.price = (double)value;
                if (attrName.ToLower().Equals("Stock"))
                    this.productId = (int)value;
            }
        }
    }
}
