using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExcerModelView.Models;
using ExcerModelView.Models.ViewModelsUser;


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

        public ActionResult List()
        {
           var ListUser= db.Users.Select(t => new { t.Name, t.Family, t.IsActive, t.Birthdate, t.Phone, t.Ncode }).ToList();

            List<UserList> List1 = new List<UserList>();

            foreach (var item in ListUser)
            {
                List1.Add(new UserList()
                {
                    Name = item.Name,
                    Family=item.Family,
                    Birthdate=item.Birthdate,
                    IsActive=true,
                    Ncode=item.Ncode,
                    Phone=item.Phone
                });
            }
            return PartialView(List1);
        }


        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login([Bind(Include = "Phone,Password")] LoginViewModel login)
        {

            if (ModelState.IsValid)
            {
                var FindId = db.Users.FirstOrDefault(t => t.Phone == login.Phone && t.Password == login.Password);

                if (FindId == null)
                {
                    ModelState.AddModelError("Phone", "نام کاربری یا رمز عبور اشتباه است");
                    return View(login);
                }
                else
                {
                    return View("Index");
                }
            }
            return View();
        }


    }
}