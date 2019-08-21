namespace Orders
{
    public class UberShippment : IShippingCalcutor
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 1000f)
                return order.TotalPrice * 0.3f;
            return 0;
        }
    }
}