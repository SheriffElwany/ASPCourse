using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer objContanier = new UnityContainer();
            objContanier.RegisterType<OrderProcessor>();
            objContanier.RegisterType<IShippingCalcutor, ArmexShippingCalcutor>();
            //var orderProcessor = new OrderProcessor(new ArmexShippingCalcutor());
            var orderProcessor = objContanier.Resolve<OrderProcessor>();
            var order = new Order { DatePlaced = DateTime.Today, TotalPrice = 100f };
            orderProcessor.Process(order);
            Console.WriteLine(order.Shipment.Cost);
        }
    }
}
