namespace ApiGateWayLab.Order.Api
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
    }
}