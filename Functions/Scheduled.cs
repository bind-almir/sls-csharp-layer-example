using Amazon.Lambda.Core;

namespace AwsDotnetCsharp
{
    public class Scheduled
    {
       public Response Handler(Request request)
       {
          string secret = System.Environment.GetEnvironmentVariable("SECRET");
          System.Console.Write(secret);
          return new Response("success", request);
       }
       
    }

}
