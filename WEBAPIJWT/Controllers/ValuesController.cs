using System.Web.Http;
using WEBAPIJWT.Auth;

namespace WEBAPIJWT.Controllers
{
    public class ValuesController : ApiController
    {        
        [JwtAuthentication]
        public string Get()
        {
            return "Hello I am Bushra :*";
        }
    }
}
