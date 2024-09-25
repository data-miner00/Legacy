using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Legacy.Core;
using Legacy.Core.Models;
using Legacy.Integrations;

namespace Legacy.Webservice
{
    /// <summary>
    /// Summary description for UserService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UserService : System.Web.Services.WebService
    {
        private readonly IUserRepository userRepository;

        public UserService()
        {
            this.userRepository = new UserRepository();
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod(MessageName = "GetUserById")]
        public User GetById(int id)
        {
            return this.userRepository.GetByIdAsync(id).GetAwaiter().GetResult();
        }
    }
}
