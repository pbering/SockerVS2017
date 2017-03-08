using System;
using Sitecore;
using Sitecore.Pipelines.HttpRequest;

namespace WebApp.Processors
{
    public class ExampleProcessor : HttpRequestProcessor
    {
        public override void Process(HttpRequestArgs args)
        {
            if (Context.Site != null && Context.Site.Name.Equals("website", StringComparison.OrdinalIgnoreCase))
            {
                args.Context.Response.Write($"<b>HOST: {Environment.MachineName}</b>");
            }
        }
    }
}