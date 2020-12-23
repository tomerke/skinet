using Core.Entities;

namespace Infrastructure.Data
{
    public class SpecificationEvaluator<TEntity> where TEntity : BaseEntity
    {
        public static IQuerable<TEntity> GetQuery(IQuerable<TEntity> inputQuery, ISpecification)
    }
}