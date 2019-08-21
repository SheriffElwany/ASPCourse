using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
   public class OrderProcessor
    {
        private readonly IShippingCalcutor _shippingCalcutor;
        public OrderProcessor(IShippingCalcutor shippingCalc)
        {
            _shippingCalcutor = shippingCalc;
        }

        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("The Order Is alerady processed");
            order.Shipment = new Shipment
            {
                Cost = _shippingCalcutor.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}
