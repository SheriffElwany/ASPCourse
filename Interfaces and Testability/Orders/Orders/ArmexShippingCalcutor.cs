namespace Orders
{
    //Step 2
    public class ArmexShippingCalcutor: IShippingCalcutor
    {

        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 40f)
                return order.TotalPrice * 0.2f;
            return 0;
        }
    }
}