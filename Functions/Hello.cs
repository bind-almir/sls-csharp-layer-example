using Amazon.Lambda.Core;
using System.Reflection;

[assembly:LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]
namespace AwsDotnetCsharp
{
    public class Hello
    {
       public Response Handler(Request request)
       {
          Assembly asm = Assembly.LoadFrom(@"/opt/layer.dll");
          var t = asm.GetType("layer.Hello");
          var method = t.GetMethod("hi");
          var hello = System.Activator.CreateInstance(t);

          // Invoke static method
          var hi = method.Invoke(hello, null);
          
          return new Response("Your function executed successfully! \n method says: " + hi, request);
       }
       
    }

    public class Response
    {
      public string Message {get; set;}
      public Request Request {get; set;}

      public Response(string message, Request request){
        Message = message;
        Request = request;
      }
    }

    public class Request
    {
      public string Key1 {get; set;}
      public string Key2 {get; set;}
      public string Key3 {get; set;}
    }
}
