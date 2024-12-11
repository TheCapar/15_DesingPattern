using System.ComponentModel.DataAnnotations;

namespace DesignPattern.Facade.DAL
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerSurname { get; set; }
        public string? CustomerAddress { get; set; }
        public string? CustomerCity { get; set; }
        public List<Order> Orders { get; set; }
        public List<OrderDetail> Details { get; set; }
    }
}
