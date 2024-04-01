namespace CustomerWebAPI.Config
{
    public static class ConfigProvider
    {
        private static IConfiguration configuration = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json").Build();
        public static string GetConnectionString(string str)
        {
            return configuration.GetValue<string>(str);
        }

    }
}
