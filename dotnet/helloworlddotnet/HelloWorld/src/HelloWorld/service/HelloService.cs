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
            //string currentLocation = System.getenv("currentLocation");

            return new Response(string.Format("Hello {0} from {1}", name, currentLocation));
        }
    }
}