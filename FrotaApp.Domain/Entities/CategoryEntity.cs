namespace FrotaApp.Domain.Entities
{
    public class CategoryEntity : BaseEntity
    {
        public CategoryEntity(string categoryName)
        {
            CategoryName = categoryName;
        }
        
        public string CategoryName { get; private set; }
    }
}