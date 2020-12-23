using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Specifications
{
    public class BaseSpecification<T> :  ISpecification<T>
    {
        public Expression<Func<T, bool>> Criteria {};

        public List<Expression<Func<T, object>>> Includes ;
    }
}