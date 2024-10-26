namespace Legacy.Webservice
{
    using System.Web;
    using System.Web.Services;
    using Autofac;
    using Autofac.Integration.Web;
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
    public sealed class UserService : WebService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserService"/> class.
        /// </summary>
        public UserService()
        {
            var accessor = (IContainerProviderAccessor)HttpContext.Current.ApplicationInstance;
            var provider = accessor.ContainerProvider;
            provider.RequestLifetime.InjectProperties(this);
        }

        /// <summary>
        /// Gets or sets the user repository.
        /// </summary>
        public IUserRepository UserRepository { get; set; }

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
            return this.UserRepository.GetByIdAsync(id).GetAwaiter().GetResult();
        }
    }
}
