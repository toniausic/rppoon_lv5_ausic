using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoon_lv5
{
    public class ShippingService
    {
        private double price;

        public ShippingService(double price)
        {
            this.price = price;
        }

        public double CalculateShippingPrice(IShipable item)
        {
            return item.Weight * price;
        }
    }
}
