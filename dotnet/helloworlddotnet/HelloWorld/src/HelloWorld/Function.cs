using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace HelloWorld
{
    public class Function
    {
        private IHelloService helloService;
        public Function()
        {
            helloService = new HelloService();
        }
        
        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public string FunctionHandler(object input, ILambdaContext context)
        {
            var json = (System.Text.Json.JsonElement)input;
            var name = GetPropertyValue(json, "name");
            var str = helloService.GenerateHello(name, "Salt Lake City");
            
            return Newtonsoft.Json.JsonConvert.SerializeObject(str);
        }

        private string GetPropertyValue(JsonElement eventDetails, string propertyName)
        {
            string propertyValue = string.Empty;
            JsonElement jsonElement;
            if (eventDetails.TryGetProperty(propertyName, out jsonElement))
            {
                propertyValue = jsonElement.GetString();
            }
            return propertyValue;
        }
    }

}
