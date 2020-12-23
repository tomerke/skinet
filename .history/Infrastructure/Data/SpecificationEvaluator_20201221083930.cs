using Core.Entities;

namespace Infrastructure.Data
{
    public class SpecificationEvaluator<TEntity> where TEntity : BaseEntity
    {
        public static IQueryable<TEntity> GetQuery(IQuerable<TEntity> inputQuery, ISpecification<TEntity> spec)
    }
}