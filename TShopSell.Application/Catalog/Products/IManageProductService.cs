using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TShopSell.Application.Catalog.Products.Dtos;
using TShopSell.Application.Dtos;

namespace TShopSell.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductEditRequest request);
        Task<int> Delete(int ProductID);

        Task<List<ProductViewModel>> GetAll();
        Task<PagedViewModel<ProductViewModel>> GetAllPaging(string keyword, int PageIndex, int PageSize);
    }
}
