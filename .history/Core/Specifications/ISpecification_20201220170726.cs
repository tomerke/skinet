namespace Core.Specifications
{
    public interface ISpecification<T>
    {
        Expression<Func<T,bool>> Criteria {get;}
        List<Expression<Func<T, object>>> Inc

    }
}