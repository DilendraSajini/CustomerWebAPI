namespace CustomerWebAPI.Config
{
    public static class ConfigProvider
    {
        private static IConfiguration configuration = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json").Build();
        public static string GetConfiguration(string str)
        {
            if(configuration != null)
            {
                return configuration.GetValue<string>(str);
            }
            else
            {
                throw new Exception("Configuration is not found");
            }
        }

    }
}
