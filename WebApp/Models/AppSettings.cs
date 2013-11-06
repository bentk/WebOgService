using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class AppSettings
    {
        public static string WebServiceUrl 
        {
            get { return ConfigurationManager.AppSettings["WebServiceUrl"]; }
        }
    }
}