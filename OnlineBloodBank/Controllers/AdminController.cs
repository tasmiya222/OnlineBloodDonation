using OnlineBloodBank.Models;
using OnlineBloodDonation.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBloodBank.Controllers
{

    public class AdminController : Controller
    {
        private OnlineBloodBankdbEntities onlineBloodBankDB = new OnlineBloodBankdbEntities();
        // GET: Admin
        public ActionResult Home()
        {
            if (Session["AdminID"] == null && Session["Name"] == null && Session["Email"] == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            return View();
        }

        public ActionResult Login()
        {
            AdminModelView view = new AdminModelView();
            return View(view);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LoginToAdmin(AdminModelView admin)
        {
            if (ModelState.IsValid)
            {
                var user = onlineBloodBankDB.AdminTables.FirstOrDefault(u => u.Email == admin.Email && u.Password == admin.password);
                if (user != null)
                {
                    // Create a session or authentication ticket here
                    Session["Name"] = user.Name;
                    Session["Email"] = user.Email;
                    Session["AdminID"] = user.ID;
                    return RedirectToAction("Home", "Admin");
                }
                ModelState.AddModelError("", "Invalid username or password.");
            }
            return View(admin);


        }

        [HttpGet]
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login", "Admin");
        }

    }
}
