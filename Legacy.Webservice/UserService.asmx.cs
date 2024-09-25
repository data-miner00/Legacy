namespace Legacy.Webservice
{
    using System.Web.Services;
    using Legacy.Core;
    using Legacy.Core.Models;
    using Legacy.Integrations;

    /// <summary>
    /// The web service for <see cref="User"/> related operations.
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    public class UserService : System.Web.Services.WebService
    {
        private readonly IUserRepository userRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserService"/> class.
        /// </summary>
        public UserService()
        {
            this.userRepository = new UserRepository();
        }

        /// <summary>
        /// Simple hello world method.
        /// </summary>
        /// <returns>The hello world string.</returns>
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        /// <summary>
        /// Gets a user by Id.
        /// </summary>
        /// <param name="id">The user ID.</param>
        /// <returns>The found user.</returns>
        [WebMethod(MessageName = "GetUserById")]
        public User GetById(int id)
        {
            return this.userRepository.GetByIdAsync(id).GetAwaiter().GetResult();
        }
    }
}
