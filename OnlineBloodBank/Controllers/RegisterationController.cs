using OnlineBloodBank.Models;
using OnlineBloodDonation.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBloodBank.Controllers
{
    public class RegisterationController : Controller
    {
        private OnlineBloodBankdbEntities onlineBloodBankDB = new OnlineBloodBankdbEntities();
        public ActionResult SelectUser(Registeration registeration)
        {
            if(registeration.UserTypeId == 2)
            {
                return RedirectToAction("DonorUser");
            }
            else if (registeration.UserTypeId == 3)
            {
                return RedirectToAction("SeekerUser");
            }
            else if (registeration.UserTypeId == 4)
            {
                return RedirectToAction("HospitalUser");
            }
            else if (registeration.UserTypeId == 5)
            {
                return  RedirectToAction("BloodBankUser");
            }
            else
            {
                return RedirectToAction("MainHome", "Home");
            }

            var reg = new Registeration();

            return View(reg);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult HospitalUser()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SeekerUser()
        {
            return View();
        } 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DonorUser()
        {
            return View();
        } 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BloodBankUser()
        {
            return View();
        }
    }
}