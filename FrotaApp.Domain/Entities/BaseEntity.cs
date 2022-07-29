namespace FrotaApp.Domain.Entities
{
    public abstract class BaseEntity
    {        
        public DateTime CreatedOn => DateTime.Now;
    }
}