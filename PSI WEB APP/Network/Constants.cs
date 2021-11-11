using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSI_WEB_APP.Network
{
    public static class Constants
    {
        public const String BASE_URL = "https://7378-197-232-247-107.ngrok.io/api";
        //public const String BASE_URL = "http://localhost:8098/api";
        //specific
        public const String URL_CITIZEN = "/ct/";
        public const String URL_CRIMINAL = "/cr/";
        public const String URL_FOREIGNER = "/fr/";
        public const String URL_OFFICER = "/of/";
        public const String URL_STATION = "/st/";
        public const String URL_SUSPECT = "/sp/";
        public const String URL_WORK = "/wk/";
        //general
        public const String URL_DELETE = "remove/";
        public const String URL_UPDATE = "update";
        public const String URL_INSERT = "add";
    }
}
