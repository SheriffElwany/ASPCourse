namespace Orders
{
    public class FedexShippingCalcutor : IShippingCalcutor
    {

        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 50f)
                return order.TotalPrice * 0.005f;
            return 0;
        }
    }
}