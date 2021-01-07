using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithTypesAndBrandsSpecification : BaseSpecification<Product>
    {
        public ProductsWithTypesAndBrandsSpecification(string sort)
        {
            AddInclude(x => x.ProcutType);
            AddInclude(x => x.ProductBrand);
            AddOrderBy(x => x.Name);

            if (!string.IsNullOrEmpty(sort))
            {
                switch(sort)
                {

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