using RepositoryDesingPattern.DataAccessLayer.Abstract;
using RepositoryDesingPattern.DataAccessLayer.Concrete;
using RepositoryDesingPattern.DataAccessLayer.Repositories;
using RepositoryDesingPattern.EntityLayer.Concrete;

namespace RepositoryDesingPattern.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal:GenericRepository<Category>,ICategoryDal
    {
        public EfCategoryDal(Context context):base (context)
        {
            
        }
    }
}
