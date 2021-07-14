using System.Text.Json.Serialization;

namespace HelloWorld 
{
    public class Request {

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}