using DevIo.Api.Exceptions;

namespace DevIo.Api.Utils.ApplicationSettings
{
    public class ApplicationConfig
    {
        public ConnectionStrings? ConnectionStrings { get; set; }


    }

    public class ConnectionStrings
    {
        public string? DefaultConnection { get; set; }

    }
}
