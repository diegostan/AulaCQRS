namespace FrotaApp.Domain.Specs
{
    public interface ISpec<in T> where T : class
    {
         bool IsSatisfiedBy(T candidate);
    }
}