using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TShopSell.Application.Catalog.Products.Dtos;
using TShopSell.Application.Catalog.Products.Dtos.Manage;
using TShopSell.Application.Dtos;

namespace TShopSell.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int ProductId);
        Task<bool> UpdatePrice(int ProductId, decimal newPrice);
        Task<bool> UpdateStock(int ProductId, int AddedQuantity);
        Task AddViewCount(int ProductId);
       Task <PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);

    }
}
