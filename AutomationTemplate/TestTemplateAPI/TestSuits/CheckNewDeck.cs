using RestSharp;

namespace AutomationTemplate.TestTemplateAPI.TestSuits
{
    [TestFixture]
    public class CheckNewDeck : BaseApiTest
    {
        [Test]
        public async Task GetNewDeck()
        {
            var request = new RestRequest("/api/deck/new/", Method.Get);
            var response = await _client.ExecuteAsync(request);

            //NewDeckResponse actualResult = JsonSerializer<NewDeckResponse>(response);
        }

    }
}
