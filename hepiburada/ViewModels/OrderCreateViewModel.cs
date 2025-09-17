using hepiburada.Core.Entity;

namespace hepiburada.ViewModels
{
    public class OrderCreateViewModel
    {
        public Order Order { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
