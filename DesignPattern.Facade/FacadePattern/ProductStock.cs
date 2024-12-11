using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.FacadePattern
{
    public class ProductStock
    {
        Context Context = new Context();
        public void StockDecrease(int id,int amount)
        {
            var value = Context.Products.Find(id);
            value.ProductStock -= amount;
            Context.SaveChanges();
        }
    }
}
