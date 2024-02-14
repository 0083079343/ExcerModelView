using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExcerModelView.Models;

namespace ExcerModelView.Controllers
{
    public class UserController : Controller
    {
        DbMasoudContext db=new DbMasoudContext();
   
        public ActionResult Index()
        {
            var Index= db.Users.ToList();

            return View(Index);
        }
    }
}