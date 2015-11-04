namespace MusicSystem.Api
{
    using System.Reflection;
    using System.Web;
    using System.Web.Http;

    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            DatabaseConfig.Initialize();
            AutomapperConfig.RegisterMappings(Assembly.Load("MusicSystem.Api"));
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
