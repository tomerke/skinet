using Core.Entities;

namespace Core.Specifications
{
    public class   : BaseSpecification<Product>
    {
        public ProductsWithTypesAndBrandsSpecification()
        {
            AddInclude(x => x.ProcutType);
            AddInclude(x => x.ProductBrand);
        }
    }
}