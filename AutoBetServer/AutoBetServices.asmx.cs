using System.Runtime.Remoting.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Web.Services;
using AutoBetServer.Resource;

namespace AutoBetServer
{
    [WebService(Namespace = "ns:autobet:server")]
    public class AutoBetServices : WebService
    {
        [WebMethod]
        [SoapMethod(SoapAction = "Hello")]
        public string HelloWorld(string name)
        {
            return string.Format("Hello, my name is {0}", name);
        }

        [WebMethod]
        [SoapMethod(SoapAction = "Authenticate")]
        public bool Authenticate(string username, string password)
        {
            X509Certificate2 cert = new X509Certificate2(Resources.Autobet,"1");
            
            return true;
        }
    }
}