using AutomationTemplate.TestTemplateAPI.Configuration;
using RestSharp;

namespace AutomationTemplate.TestTemplateAPI
{
    public class BaseApiTest
    {
        protected RestClient _client;

        [OneTimeSetUp]
        public void SetUp()
        {
            var config = ConfigReader.LoadConfig();
            string baseUrl = config.GetSection("baseUrl").Value;
            _client = new RestClient(baseUrl);
        }


        [OneTimeTearDown]
        public void TearDown()
        {
            _client?.Dispose();
        }
    }
}
