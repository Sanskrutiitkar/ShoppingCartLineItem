using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication.model
{
    internal class LineItem : Product
    {
        private int _id;
        private int _quantity;
        private Product _product;

        public LineItem(int id, int quantity, Product product)
        {
            _id = id;
            _quantity = quantity;
            _product = product;
        }
        public LineItem() { }
        public int Id { get { return _id; } set { _id = value; } }
        public int Quantity { get { return _quantity; } set { _quantity = value; } }
        public Product Product { get { return _product; } set { _product = value; } }

        public static double CalculateLineItemCost(LineItem lineItem) 
        {
            double discountedPrice = CalculateDiscountedPrice(lineItem.Product);
            double cost = lineItem.Quantity * discountedPrice;
            return cost;
        }

    }
}
