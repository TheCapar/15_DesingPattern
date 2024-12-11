using System.ComponentModel.DataAnnotations;

namespace DesignPattern.Facade.DAL
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderDetail> Details { get; set; }

    }
}
