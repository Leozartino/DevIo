using DevIo.Api.Exceptions;

namespace DevIo.Api.Utils.ApplicationSettings
{
    public class ApplicationConfig
    {
        private ConnectionStrings? _connectionStrings { get; set; }

        public ConnectionStrings ConnectionStrings 
        { 
            get 
            { 
                if(_connectionStrings == null)
                {
                    throw new MissingConfigurationException("ConnectionStrings");
                }
                return _connectionStrings;
            }
            set 
            { 
                _connectionStrings = value; 
            }
        }

    }

    public class ConnectionStrings
    {
        private string? _defaultConnection { get; set; }

        public string DefaultConnection 
        { 
            get
            {
                if(_defaultConnection == null)
                {
                    throw new MissingConfigurationException("ConnectionStrings:DefaultConnection");
                }
                return _defaultConnection;
            }
            set
            {
                _defaultConnection = value;
            }
        }
    }
}
