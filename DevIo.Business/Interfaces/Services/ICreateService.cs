namespace DevIo.Business.Interfaces.Services
{
    public interface ICreateService<TCreateDto, TCreateResponse>
    {
        Task<TCreateResponse> CreateAsync(TCreateDto createDto);
    }
}
