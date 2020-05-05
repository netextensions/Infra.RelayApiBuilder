using System.Net;

namespace NetExtensions.Infra.RelayApiBuilder.RelayApiEntities
{
    public class ResourceConfig
    {
        public int DelayInMs { get; set; }
        public HttpStatusCode? HttpStatusCode { get; set; }
        public string InvalidToken { get; set; }
    }
}