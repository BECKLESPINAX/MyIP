using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyIP.Controllers
{
    public class IpController : Controller
    {
        public ActionResult MostrarIP()
        {
            string userIp = ObtenerIPUsuario();
            ViewData["IP"]  = userIp;
            return View();
        }

        private string ObtenerIPUsuario()
        {
        string ip = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
    if (string.IsNullOrEmpty(ip))
    {
        ip = Request.ServerVariables["REMOTE_ADDR"];
    }

    // Comprobar si la IP es localhost
    if (ip == "::1" || ip == "127.0.0.1")
    {
        ip = "Acceso local: IP no disponible";
    }

    return ip;
        }
    }
}