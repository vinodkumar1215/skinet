using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product>GetProductByIdAsynk(int id);
        Task<IReadOnlyList<Product>>GetProductsAsync();
        Task<IReadOnlyList<productBrand>>GetProductBrandsAsync();
        Task<IReadOnlyList<ProductType>>GetProductTypesAsync();
        
    }
}