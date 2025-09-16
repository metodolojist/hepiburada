namespace hepiburada.Core.Entity
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }


    }
}
