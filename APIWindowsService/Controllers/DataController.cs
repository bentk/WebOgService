using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace APIWindowsService.Controllers
{
    public class DataController : ApiController
    {
        public HttpResponseMessage GetData()
        {
            return Request.CreateResponse(HttpStatusCode.OK, new{Versjon= Assembly.GetExecutingAssembly().GetName().Version.ToString(), Miljo=AppSettings.Miljo});
        }
    }
}
