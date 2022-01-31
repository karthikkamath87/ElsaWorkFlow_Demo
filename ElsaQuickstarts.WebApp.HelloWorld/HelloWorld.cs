using System.Net;
using Elsa.Activities.Http;
using Elsa.Builders;

namespace ElsaQuickstarts.WebApp.HelloWorld
{
    /// <summary>
    /// A workflow that is triggered when HTTP requests are made to /hello-world and writes a response.
    /// </summary>
    public class HelloWorld : IWorkflow
    {
        public void Build(IWorkflowBuilder builder)
        {
            builder
                .HttpEndpoint("/hello-world")
                .WriteHttpResponse(HttpStatusCode.OK, "<h1>Hello World!123566</h1>", "text/html");
        }
    }
}