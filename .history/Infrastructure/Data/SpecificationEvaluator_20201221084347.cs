using System.Linq;
using Core.Entities;
using Core.Specifications;

namespace Infrastructure.Data
{
    public class SpecificationEvaluator<TEntity> where TEntity : BaseEntity
    {
        public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuery, ISpecification<TEntity> spec)
        {
            var query = inputQuery;
            if (spec!=null){
               query = query.Where(spec.Criteria);
            }
            query = spec.Includes.Aggregate(query,(current, include)=>current.Include(include));
        }
    }
}