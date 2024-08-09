using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication.model
{
    internal class Product
    {
        private int _id;
        private string _name;
        private double _price;
        private double _discountPercent;
        private const double DISCOUNT = 100;

        public Product(int id, string name, double price, double discountPercent)
        {
            this._id = id;
            this._name = name;
            this._price = price;
            this._discountPercent = discountPercent;
        }
        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public double Price { get { return _price; } set { _price = value; } }
        public double DiscountPercent { get { return _discountPercent; } set { _discountPercent = value; } }
     

        public void setDiscountPercentage(double discount) { this._discountPercent = discount; }

        public Product() { }
        public static double CalculateDiscountedPrice(Product product)
        {
            return product.Price - (product.Price * (product.DiscountPercent / DISCOUNT));
        }
    }
}
