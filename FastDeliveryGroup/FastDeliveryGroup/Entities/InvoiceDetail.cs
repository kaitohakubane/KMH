using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastDeliveryGroup.Entities
{
    public class InvoiceDetail
    {
        private int mInvoiceID;

        public int InvoiceID
        {
            get { return mInvoiceID; }
            set { mInvoiceID = value; }
        }
        private int mProductID;

        public int ProductID
        {
            get { return mProductID; }
            set { mProductID = value; }
        }
        private int mQuantity;

        public int Quantity
        {
            get { return mQuantity; }
            set { mQuantity = value; }
        }

        private double mSubTotal;

        public InvoiceDetail(int invoiceID, Product product, int quantity)
        {
            InvoiceID = invoiceID;
            ProductID = product.ProductID;
            Quantity = quantity;
            SubTotal = product.Price * Quantity;
        }

        public double SubTotal
        {
            get { return mSubTotal; }
            set { mSubTotal = value; }
        }

        public string Product
        {
            get
            {
                return mProduct;
            }

            set
            {
                mProduct = value;
            }
        }

        private string mProduct;

    }
}
