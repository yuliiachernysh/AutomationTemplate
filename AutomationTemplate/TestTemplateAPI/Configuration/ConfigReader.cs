using Microsoft.Extensions.Configuration;

namespace AutomationTemplate.TestTemplateAPI.Configuration
{
    public static class ConfigReader
    {
        public static IConfigurationRoot LoadConfig()
        {

            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            return config;
        }
    }
}
