using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithTypesAndBrandsSpecification : BaseSpecification<Product>
    {
        public ProductsWithTypesAndBrandsSpecification(ProductSpecParams productParams)
        :base (x =>
        (!productParams.BrandId.HasValue ||  x.ProductBrandId == productParams.BrandId) &&
        (!productParams.TypeId.HasValue || x.ProductTypeId==productParams.TypeId)
        )
        {
            AddInclude(x => x.ProcutType);
            AddInclude(x => x.ProductBrand);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * productParams.PageIndex)

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch(productParams.Sort)
                {
                    case "priceAsc":
                    AddOrderBy( p=> p.Price);
                    break;
                    case "priceDesc":
                    AddOrderByDescending(p => p.Price);
                    break;
                    default:
                    AddOrderBy(n => n.Name);
                    break;

                }
            }
        }

        public ProductsWithTypesAndBrandsSpecification(int Id) : base(x => x.Id == Id)
        {
            AddInclude(x => x.ProcutType);
            AddInclude(x => x.ProductBrand);
        }
    }
}