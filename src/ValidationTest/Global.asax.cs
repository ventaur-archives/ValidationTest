using System;
using System.Web;
using FubuMVC.Core;

namespace ValidationTest
{
    public class Global : HttpApplication
    {
        private FubuRuntime _runtime;

        protected void Application_Start(object sender, EventArgs e)
        {
            _runtime = FubuApplication.BootstrapApplication<ValidationTestApplication>();
        }

        protected void Application_End(object sender, EventArgs e)
        {
            _runtime.Dispose();
        }
    }
}