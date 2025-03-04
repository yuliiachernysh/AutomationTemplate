namespace AutomationTemplate.TestTemplateAPI.Contracts.Responses
{
    public class NewDeckResponse
    {
        public string deck_id { get; set; }
        public int remaining { get; set; }
        public bool success { get; set; }
        public bool shuffled { get; set; }
    }
}
