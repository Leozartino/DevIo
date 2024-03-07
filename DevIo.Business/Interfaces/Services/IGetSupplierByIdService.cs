namespace DevIo.Business.Interfaces.Services
{
    public interface IGetSupplierByIdService<TResponse> where TResponse : class
    {
        Task<TResponse> GetSupplierById(Guid id);
    }
}
