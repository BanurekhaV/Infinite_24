using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace WebApi_BasicAuthentication.Models
{
    public class BasicAuthenticationAttribute : AuthorizationFilterAttribute
    {
        private const string Realm = "My Realm";
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            //if the authorization header is empty or null, then 
            //return UnAthorised error to the customer
            if(actionContext.Request.Headers.Authorization == null)
            {
               actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized);

                if(actionContext.Response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    actionContext.Response.Headers.Add("WWW-Authenticate", string.Format("Basic realm =\"{0}\"", Realm));
                }
            }
            else
            {
                //get the authentication token from the request header which is encoded to the base64 encoding
                string authenticationToken = actionContext.Request.Headers.Authorization.Parameter;

                //decode the string
                string decodeAuthenticationToken = Encoding.UTF8.GetString(
                    Convert.FromBase64String(authenticationToken));

                //split the string into 2 i.e. string[]
                string[] usernamePasswordArray = decodeAuthenticationToken.Split(':');

                //let us seperate the array values into 2 different strings

                string username = usernamePasswordArray[0];
                string password = usernamePasswordArray[1];

                //call the login method of the UserValidate class
                if(UserValidate.Login(username,password))
                {
                    var identity = new GenericIdentity(username);
                    IPrincipal principal = new GenericPrincipal(identity, null);
                    Thread.CurrentPrincipal = principal;

                    if(HttpContext.Current !=null)
                    {
                        HttpContext.Current.User = principal;
                    }
                }
                else
                {
                    actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized);
                }
            }
        }

    }
}