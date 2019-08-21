using System;

namespace Orders
{
    public class Order
    {
        public bool IsShipped { get; internal set; }
        public Shipment Shipment { get; set; }
        public float TotalPrice { get;  set; }
        public DateTime DatePlaced { get;  set; }
    }
}