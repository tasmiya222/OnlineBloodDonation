using OnlineBloodBank.Models;
using OnlineBloodDonation.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace OnlineBloodBank.Controllers
{
    public class UserTypeController : Controller
    {
        private OnlineBloodBankdbEntities onlineBloodBankDB = new OnlineBloodBankdbEntities();

        // GET: UserType
        public ActionResult AllUserType()
        {
            var UserTypeList = onlineBloodBankDB.UserTypeTables.ToList();
            var ListOfUserType= new List<UserType>();
            foreach (var requestType in UserTypeList)
            {
                var AddUserType = new UserType
                {
                    UserTypeId = requestType.UserTypeID,
                    UserTypeName= requestType.UserType
                };

                ListOfUserType.Add(AddUserType);
            }
            return View(ListOfUserType);
        }

        public ActionResult Create()
        {
            var newUserType = new UserType();
            return View(newUserType);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserType model)
        {
            if (ModelState.IsValid)
            {
                var AddUserType = new UserTypeTable();
                AddUserType.UserTypeID= model.UserTypeId;
                AddUserType.UserType= model.UserTypeName;
                onlineBloodBankDB.UserTypeTables.Add(AddUserType);
                onlineBloodBankDB.SaveChanges();
                return RedirectToAction("AllUserType");
            }
            return View(model);
        }

        public ActionResult Edit(int? id)
        {
            var userType = onlineBloodBankDB.UserTypeTables.Find(id);
            if (userType  == null)
            {
                return HttpNotFound();
            }
            var userTypeModel = new UserType();
            userTypeModel.UserTypeId = userType.UserTypeID;
            userTypeModel.UserTypeName= userType.UserType;
            return View(userTypeModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UserType userType)
        {
            if (ModelState.IsValid)
            {
                var AddUserType= new UserTypeTable();
                AddUserType.UserTypeID = userType.UserTypeId;
                AddUserType.UserType= userType.UserTypeName;
                onlineBloodBankDB.Entry(AddUserType).State = EntityState.Modified;
                onlineBloodBankDB.SaveChanges();
                return RedirectToAction("AllRequesttype");
            }
            return View(userType);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            var UserType = onlineBloodBankDB.UserTypeTables.Find(id);
            if (UserType == null)
            {
                return HttpNotFound();
            }
            var UserTypeModel = new UserType();
            UserTypeModel.UserTypeId= UserType.UserTypeID;
            UserTypeModel.UserTypeName = UserType.UserType;
            return View(UserTypeModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfrim(int? id)
        {
            var Usertype = onlineBloodBankDB.UserTypeTables.Find(id);
            onlineBloodBankDB.UserTypeTables.Remove(Usertype);
            onlineBloodBankDB.SaveChanges();
            return RedirectToAction("AllUserType");
        }

    }
}
