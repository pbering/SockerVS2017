using System;
using Sitecore.Pipelines.HttpRequest;

namespace WebApp.Processors
{
    public class ExampleProcessor : HttpRequestProcessor
    {
        public override void Process(HttpRequestArgs args)
        {
            if (args.Context.Request.Path == "/")
            {
                args.Context.Response.Write($"<b>HOST: {Environment.MachineName}</b>");
            }
        }
    }
}