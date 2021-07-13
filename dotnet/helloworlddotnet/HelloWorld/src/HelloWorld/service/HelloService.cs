namespace HelloWorld 
{
    public interface IHelloService
    {
        Response GenerateHello(string name, string currentLocation);
    }

    public class HelloService : IHelloService
    {
        /// <summary>
        /// A simple function that takes two strings
        /// </summary>
        /// <param name="name"></param>
        /// <param name="currentLocation"></param>
        /// <returns>Returns a string</returns>
        public Response GenerateHello(string name, string currentLocation)
        {
            //string name = request.getName();
            //string currentLocation = System.getenv("currentLocation");

            return new Response(string.Format("Hello {0} from {1}", name, currentLocation));
        }
    }

    public class Response {
        public string output { get; set; }
        public Response(string output) {
            this.output = output;
        }

        public string getOutput() {
            return output;
        }
    }
}