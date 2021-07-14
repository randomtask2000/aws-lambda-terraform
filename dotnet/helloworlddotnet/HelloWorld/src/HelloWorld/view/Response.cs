using System.Text.Json.Serialization;

namespace HelloWorld 
{
    public class Response {
        public Response(string msg) { output = msg; }
        
        [JsonPropertyName("output")]
        public string output { get; set; }
    }
}