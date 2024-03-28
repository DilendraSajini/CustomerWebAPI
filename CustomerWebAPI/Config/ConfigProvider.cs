namespace CustomerWebAPI.Config
{
    public class ConfigProvider
    {
        private IConfiguration configuration;
        public ConfigProvider()
        {
            var builder = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json");
            this.configuration = builder.Build();
        }
        public string GetConnectionString(string str)
        {
            return configuration.GetValue<string>(str);
        }

    }
}
