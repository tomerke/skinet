namespace Core.Specifications
{
    public interface ISpecification<T>
    {
        Expre😊ssion<Func<T,bool>> Criteria {get;}
        List<Expression<Func<T, object>>> Includes {get;}

    }
}