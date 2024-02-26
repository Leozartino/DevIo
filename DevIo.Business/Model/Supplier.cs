namespace DevIo.Business.Model
{
    public class Supplier : BaseEntity
    {
        public string Name { get; set; }
        public string Document { get; set; }
        public bool IsActive { get; set; }
        public Adress Adress { get; set; }
        public SupplierType SupplierType { get; set; }

        public IEnumerable<Product> Products { get; set;}
    }
}
