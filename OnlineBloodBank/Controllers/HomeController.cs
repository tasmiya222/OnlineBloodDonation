using OnlineBloodBank.Models;
using OnlineBloodDonation.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBloodBank.Controllers
{
    public class HomeController : Controller
    {
        private OnlineBloodBankdbEntities onlineBloodBankDB = new OnlineBloodBankdbEntities();

        // GET: Home
        public ActionResult MainHome()
        {
            var registeration = new Registeration();
            ViewBag.UserTypeId = new SelectList(onlineBloodBankDB.UserTypeTables.Where(ut =>ut.UserTypeID>1).ToList(), "UserTypeID", "UserType", "0");
            ViewBag.CityId = new SelectList(onlineBloodBankDB.CityTables.ToList(), "CityID", "CityName", "0");
            return View(registeration);
        }
    }
}