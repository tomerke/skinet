namespace Core.Specifications
{
    public class ProductWithFiltersForCountSpecification :Base
    {
        public ProductWithFiltersForCountSpecification(ProductSpecParams productParams)
          :base (x =>
        (!productParams.BrandId.HasValue ||  x.ProductBrandId == productParams.BrandId) &&
        (!productParams.TypeId.HasValue || x.ProductTypeId==productParams.TypeId)
        )
        {
        }
    }
}