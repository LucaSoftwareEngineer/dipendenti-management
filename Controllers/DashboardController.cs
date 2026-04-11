using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dipendenti_management.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            if (Session["user"] == null || Session["user"] == "")
            {
                Response.Redirect("Default");
            }

            ViewData["user"] = Session["user"].ToString();

            return View();
        }
    }
}