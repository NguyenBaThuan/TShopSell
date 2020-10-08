using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TShopSell.Application.Catalog.Products.Dtos;
using TShopSell.Application.Catalog.Products.Dtos.Public;
using TShopSell.Application.Dtos;

namespace TShopSell.Application.Catalog.Products
{
    public interface IPublicProductService
    {

        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);

    }
}
