using System;
using System.Collections.Generic;
using System.Text;
using TShopSell.Application.Catalog.Products.Dtos;
using TShopSell.Application.Dtos;

namespace TShopSell.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        int Create(ProductCreateRequest request);
        int Update(ProductEditRequest request);
        int Delete(int ProductID);

        PagedViewModel<ProductViewModel> GetAllByCategoryId(int categoryId,int pageIndex,int pageSize);

    }
}
