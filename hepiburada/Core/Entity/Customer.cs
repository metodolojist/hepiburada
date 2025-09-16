namespace hepiburada.Core.Entity
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Age { get; set; }
        public List<Order> Orders { get; set; }
    }
}
