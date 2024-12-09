using RepositoryDesingPattern.EntityLayer.Concrete;

namespace RepositoryDesingPattern.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> TProductListWithCategory();
    }
}
