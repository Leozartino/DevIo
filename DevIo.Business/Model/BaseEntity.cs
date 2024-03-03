namespace DevIo.Business.Model
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        protected BaseEntity() 
        {
            Id = new Guid();
        }
    }
}
