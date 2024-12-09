using RepositoryDesingPattern.EntityLayer.Concrete;

namespace RepositoryDesingPattern.DataAccessLayer.Abstract
{
    public interface IProductDal:IGenericDal<Product>
    {
        List<Product> ProductListWithCategory();
    }
}
