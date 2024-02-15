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


    }
}