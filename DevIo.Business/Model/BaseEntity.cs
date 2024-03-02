namespace DevIo.Business.Model
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; } = Guid.Empty;
        protected BaseEntity() 
        {
            Id = Guid.Empty;
        }
    }
}
