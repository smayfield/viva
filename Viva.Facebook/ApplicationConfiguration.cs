using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace Viva.Facebook
{
    public static class ApplicationConfiguration
    {
        public static string FacebookAppId { get { return ConfigurationManager.AppSettings["FacebookAppId"]; } }
        public static string FacebookClientSecret { get { return ConfigurationManager.AppSettings["FacebookClientSecret"]; } }
        public static string FacebookAppToken { get { return ConfigurationManager.AppSettings["FacebookAppToken"]; } }
    }
}
