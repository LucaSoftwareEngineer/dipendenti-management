using CyberCrypt;
using dipendenti_management.App_Start;
using dipendenti_management.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dipendenti_management.Controllers
{
    public class AmministratoreController : Controller
    {

        private readonly DbContextConfig _dbContextConfig;
        
        public AmministratoreController()
        {
            _dbContextConfig = new DbContextConfig();
        }

        [HttpPost]
        public JsonResult Login(LoginRequest request)
        {

            var password = _SHA.SHA512Hash(request.password);

            var amministratore = _dbContextConfig.amministratori
                .Where(a => a.username == request.username && a.password == password)
                .FirstOrDefault();

            if (amministratore == null)
            {
                throw new HttpException("username o password errati");
            } else
            {
                Session["user"] = amministratore.username;
                return Json(new { success = true });
            }

        }
    }
}