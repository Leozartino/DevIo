namespace DevIo.Business.Model
{
    public class Supplier
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Document { get; set; }
        public int SupplierType { get; set; }
        public bool IsActive { get; set; }
    }
}
