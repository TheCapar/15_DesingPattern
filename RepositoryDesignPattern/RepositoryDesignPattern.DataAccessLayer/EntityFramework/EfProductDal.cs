using Microsoft.EntityFrameworkCore;
using RepositoryDesingPattern.DataAccessLayer.Abstract;
using RepositoryDesingPattern.DataAccessLayer.Concrete;
using RepositoryDesingPattern.DataAccessLayer.Repositories;
using RepositoryDesingPattern.EntityLayer.Concrete;

namespace RepositoryDesingPattern.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        private readonly Context _context;
        public EfProductDal(Context context) : base(context)
        {
            _context = context;
        }

        public List<Product> ProductListWithCategory()
        {
            return _context.Products.Include(x => x.Category).ToList();
            
        }
    }
}
