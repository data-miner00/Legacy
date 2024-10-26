namespace Legacy.Webservice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Security;
    using System.Web.SessionState;
    using Autofac;
    using Autofac.Integration.Web;

    public class Global : System.Web.HttpApplication, IContainerProviderAccessor
    {
        static IContainerProvider containerProvider = new ContainerProvider(ContainerConfig.Configure());

        /// <inheritdoc/>
        public IContainerProvider ContainerProvider => containerProvider;

        protected void Application_Start(object sender, EventArgs e)
        {
            // no implementation
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            // no implementation
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            // no implementation
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            // no implementation
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            // no implementation
        }

        protected void Session_End(object sender, EventArgs e)
        {
            // no implementation
        }

        protected void Application_End(object sender, EventArgs e)
        {
            // no implementation
        }
    }
}
