using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace APIWindowsService
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                x.Service(() => new APIService());
                x.RunAsLocalSystem();
                x.StartAutomatically();
                x.EnablePauseAndContinue();
                x.EnableShutdown();
                x.SetDescription("Tjeneste som gir deg data");
                x.SetDisplayName("APIWindowsService");
                x.SetServiceName("APIWindowsService");
            });
        }
    }
}
