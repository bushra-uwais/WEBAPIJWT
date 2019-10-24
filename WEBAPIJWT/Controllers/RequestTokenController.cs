using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEBAPIJWT.Auth;

namespace WEBAPIJWT.Controllers
{
    public class RequestTokenController : ApiController
    {
        public HttpResponseMessage Get(string username, string password)
        {
            if (CheckUser(username, password))
            {                
                return Request.CreateResponse(HttpStatusCode.OK,
             JwtAuthManager.GenerateJWTToken(username));
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.Unauthorized,
             "Invalid Request");
            }
        }
        public bool CheckUser(string username, string password)
        {
            if (username == "bushra" && password == "abc123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
