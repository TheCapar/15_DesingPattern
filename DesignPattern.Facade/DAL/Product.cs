using System.ComponentModel.DataAnnotations;

namespace DesignPattern.Facade.DAL
{
    public class Product
    {
        [Key]
        public int ProdcutID { get; set; }
        public string? ProductName { get; set; }
        public int ProductStock {  get; set; }
        public decimal ProductPrice { get; set; }
        public string? ProductCategory { get; set; }
        public List<OrderDetail> Details { get; set; }
    }
}
