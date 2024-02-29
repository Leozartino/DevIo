namespace DevIo.Api.Exceptions
{
    public class MissingConfigurationException : Exception
    {
        public string Key { get; private set; }

        public MissingConfigurationException(string key) 
            : base($"Missing configuration value for key: '{key}'")
        {
            Key = key;
        }
    }
}
