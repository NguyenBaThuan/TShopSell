using System;
using System.Collections.Generic;
using System.Text;
using TShopSell.Application.Dtos;

namespace TShopSell.Application.Catalog.Products.Dtos.Public
{
    public class GetProductPagingRequest:PagingRequestBase
    {
        
        public int? CategoryId{get; set;}
    }
}
