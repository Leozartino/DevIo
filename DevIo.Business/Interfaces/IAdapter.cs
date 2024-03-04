namespace DevIo.Business.Interfaces
{
    public interface IAdapter<in TSource, out  TDestination>
    {
        TDestination ConvertToDestinationObject(TSource source);
    }
}
