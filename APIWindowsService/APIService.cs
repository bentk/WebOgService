using System;
using Microsoft.Owin.Hosting;
using Topshelf;

namespace APIWindowsService
{
    public class APIService : ServiceControl
    {
        private IDisposable _apiHost;

        public bool Start(HostControl hostControl)
        {
            _apiHost = WebApp.Start<ApiConfiguration>(url:AppSettings.HostUrl);
            return true;
        }

        public bool Stop(HostControl hostControl)
        {
            if (_apiHost != null)
                _apiHost.Dispose();
            return true;
        }
    }
}