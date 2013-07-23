using System.Net;
using ServiceStack.Common.Web;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace ServiceStackHost
{
    [Route("/customer", "POST,PUT,OPTIONS")]
    [Route("/customer/{Id}", "GET,OPTIONS")]
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CustomerService : Service
    {
        public object Get(Customer customer)
        {
            return new HttpResult(new Customer(){Id = 1})
            {
                StatusCode = HttpStatusCode.OK
            };
        }

        public object Post(Customer customer)
        {
            return new HttpResult
                       {
                           StatusCode = HttpStatusCode.Created
                       };
        }

        public object Put(Customer customer)
        {
            return new HttpResult
            {
                StatusCode = HttpStatusCode.OK
            };            
        }
    }
}