using Funq;
using ServiceStack.ServiceHost;
using ServiceStack.WebHost.Endpoints;

namespace ServiceStackHost
{
    public class AppHost : AppHostHttpListenerBase
    {
        public AppHost() : base("Customer Service", typeof(CustomerService).Assembly)
        {
            
        }
        public override void Configure(Container container)
        {
            PreRequestFilters.Add((req, res) =>
            {
                if (req.HttpMethod != "OPTIONS")
                    return;
                res.AddHeader("Access-Control-Allow-Origin", GetAllowedOrigins(req));
                res.AddHeader("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE, OPTIONS");
                res.AddHeader("Access-Control-Allow-Headers", "accept, origin, x-requested-with, content-type");
                res.End();
            });

            RequestFilters.Add((req, res, dto) => res.AddHeader("Access-Control-Allow-Origin", GetAllowedOrigins(req) ));
        }

        private string GetAllowedOrigins(IHttpRequest request)
        {
            return request.Headers["Origin"];
        }
    }
}