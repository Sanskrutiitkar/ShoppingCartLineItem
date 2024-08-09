using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication.model
{
    internal class Order : LineItem
    {
        private int _id;
        private DateTime _date;
        private List<LineItem> _items = new List<LineItem>();

        public Order() { }
        public int Id { get { return _id; } set { _id = value; } }
        public DateTime Date { get { return _date; } set { _date = value; } }
        public List<LineItem> Items { get { return this._items; }  set { _items = value; } }
        public Order(int id, DateTime date) 
        {
            _id = id; 
            _date = date;
        }

        public static double CalculateOrderPrice(Order order) 
        {
            double totalOrderPrice = 0;
            foreach (LineItem lineItem in order.Items)
            {
                double lineItemCost = CalculateLineItemCost(lineItem);
                totalOrderPrice = totalOrderPrice + lineItemCost; 
            }
            return totalOrderPrice;

        }

    }
}
