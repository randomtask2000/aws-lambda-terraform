namespace HelloWorld 
{
    public class HelloService
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
    }
}