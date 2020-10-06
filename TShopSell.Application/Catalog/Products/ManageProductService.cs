
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TShopSell.Application.Catalog.Products.Dtos;
using TShopSell.Application.Dtos;
using TShopSell.Data.EF;
using TShopSell.Data.Entities;

namespace TShopSell.Application.Catalog.Products
{
    public class ManageProductService : IManageProductService
    {
        private readonly TShopDbContext _context;
        public ManageProductService(TShopDbContext context)
        {
            _context = context;
        }

        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Price = request.Price,
            };
            _context.Products.Add(product);
            return await _context.SaveChangesAsync();
        }

        public async  Task<int> Delete(int ProductID)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<PagedViewModel<ProductViewModel>> GetAllPaging(string keyword, int PageIndex, int PageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(ProductEditRequest request)
        {
            throw new NotImplementedException();
        }

    }
}
