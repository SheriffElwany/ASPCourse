namespace Orders
{
    public interface IShippingCalcutor
    {
        float CalculateShipping(Order order);
    }
}