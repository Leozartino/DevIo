namespace DevIo.Business.Model
{
    public abstract class BaseEntity
    {
        protected Guid Id { get; set; }
        protected BaseEntity() 
        { 
            Id = Guid.NewGuid();
        }
    }
}
