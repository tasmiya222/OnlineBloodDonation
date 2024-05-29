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
    public class AccountStatusController : Controller
    {
        private OnlineBloodBankdbEntities onlineBloodBankDB = new OnlineBloodBankdbEntities();

        // GET: AccountStatus
        public ActionResult AllAccountStatus()
        {
            var AccountStatusList = onlineBloodBankDB.AccountStatusTables.ToList();
            var ListOfAccoountStatus = new List<AccountStatus>();
            foreach (var accountStatus in AccountStatusList)
            {
                var addAccountStatus = new AccountStatus
                {
                    AccountStatusId = accountStatus.AccountStatusID,
                    AccountStatusName = accountStatus.AccountStatus
                };

                ListOfAccoountStatus.Add(addAccountStatus);
            }
            return View(ListOfAccoountStatus);
        }

        public ActionResult Create()
        {
            var newAccountStatus = new AccountStatus();
            return View(newAccountStatus);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AccountStatus model)
        {
            if (ModelState.IsValid)
            {
                var checkAccountStatus = onlineBloodBankDB.AccountStatusTables.Where(b => b.AccountStatus == model.AccountStatusName).FirstOrDefault();
                if (checkAccountStatus == null)
                {
                    var AddAccountStatus = new AccountStatusTable();
                    AddAccountStatus.AccountStatusID = model.AccountStatusId;
                    AddAccountStatus.AccountStatus = model.AccountStatusName;
                    onlineBloodBankDB.AccountStatusTables.Add(AddAccountStatus);
                    onlineBloodBankDB.SaveChanges();
                    return RedirectToAction("AllAccountStatus");
                }
                else
                {
                    ModelState.AddModelError("AccountStatus", "Account Status Already Exits");
                }
            }
            return View(model);
        }

        public ActionResult Edit(int? id)
        {
            var accountStatus = onlineBloodBankDB.AccountStatusTables.Find(id);
            if (accountStatus == null)
            {
                return HttpNotFound();
            }
            var AcountStatusModel = new AccountStatus();
            AcountStatusModel.AccountStatusId = accountStatus.AccountStatusID;
            AcountStatusModel.AccountStatusName= accountStatus.AccountStatus;
            return View(AcountStatusModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AccountStatus model)
        {
            if (ModelState.IsValid)
            {
                var checkAccountStatus = onlineBloodBankDB.AccountStatusTables.Where(b => b.AccountStatus == model.AccountStatusName && b.AccountStatusID != model.AccountStatusId).FirstOrDefault();
                if (checkAccountStatus == null)
                {
                    var AddAccountStatus = new AccountStatusTable();
                    AddAccountStatus.AccountStatusID = model.AccountStatusId;
                    AddAccountStatus.AccountStatus = model.AccountStatusName;
                    onlineBloodBankDB.Entry(AddAccountStatus).State = EntityState.Modified;
                    onlineBloodBankDB.SaveChanges();
                    return RedirectToAction("AllAccountStatus");
                }
                else
                {
                    ModelState.AddModelError("AccountStatus", "Account Status Already Exits");

                }
            }
            return View(model);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            var accountStatus = onlineBloodBankDB.AccountStatusTables.Find(id);
            if (accountStatus == null)
            {
                return HttpNotFound();
            }
            var AcountStatusModel = new AccountStatus();
            AcountStatusModel.AccountStatusId = accountStatus.AccountStatusID;
            AcountStatusModel.AccountStatusName = accountStatus.AccountStatus;
            return View(AcountStatusModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfrim(int? id)
        {
            var accountStatus = onlineBloodBankDB.AccountStatusTables.Find(id);
            onlineBloodBankDB.AccountStatusTables.Remove(accountStatus);
            onlineBloodBankDB.SaveChanges();
            return RedirectToAction("AllAccountStatus");
        }
    }
}