namespace HelloWorld 
{
    public interface IHelloService
    {
        string GenerateHello(string name, string currentLocation);
    }

    public class HelloService : IHelloService
    {
        /// <summary>
        /// A simple function that takes two strings
        /// </summary>
        /// <param name="name"></param>
        /// <param name="currentLocation"></param>
        /// <returns>Returns a string</returns>
        public string GenerateHello(string name, string currentLocation)
        {
            return string.Format("Hello {0} from {1}", name, currentLocation);
            //return "{\"msg\":\"Hello Emilio\"}";
        }
    }
}