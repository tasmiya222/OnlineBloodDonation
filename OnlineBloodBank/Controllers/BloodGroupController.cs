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
    public class BloodGroupController : Controller
    {
        private OnlineBloodBankdbEntities onlineBloodBankDB = new OnlineBloodBankdbEntities();
        public ActionResult AllBloodGroup()
        {

            var BloodGroupList = onlineBloodBankDB.BloodGroupsTables.ToList();
            var ListOfBloodGroup = new List<BloodGroup>();
            foreach (var bloodgroup in BloodGroupList)
            {
                var addBloodGroup = new BloodGroup
                {
                    BloodGroupId = bloodgroup.BloodGroupID,
                    BloodGroupName = bloodgroup.BloodGroupName
                };

                ListOfBloodGroup.Add(addBloodGroup);
            }
            return View(ListOfBloodGroup);
        }

        public ActionResult Create()
        {
            var newBloodGroup = new BloodGroup();
            return View(newBloodGroup);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BloodGroup model)
        {
            if (ModelState.IsValid)
            {
                var checkbloodGroup = onlineBloodBankDB.BloodGroupsTables.Where(b => b.BloodGroupName == model.BloodGroupName).FirstOrDefault();
                if (checkbloodGroup == null)
                {
                    var AddBloodGroup = new BloodGroupsTable();
                    AddBloodGroup.BloodGroupID = model.BloodGroupId;
                    AddBloodGroup.BloodGroupName = model.BloodGroupName;
                    onlineBloodBankDB.BloodGroupsTables.Add(AddBloodGroup);
                    onlineBloodBankDB.SaveChanges();
                    return RedirectToAction("AllBloodGroup");
                }
                else
                {
                    ModelState.AddModelError("BloodGroup", "Blood Group Already Exits");
                }
            }
            return View(model);
        }

        public ActionResult Edit(int? id)
        {
            var BloodGroup = onlineBloodBankDB.BloodGroupsTables.Find(id);
            if (BloodGroup  == null)
            {
                return HttpNotFound();
            }
            var BloodGroupModel = new BloodGroup();
            BloodGroupModel.BloodGroupId = BloodGroup.BloodGroupID;
            BloodGroupModel.BloodGroupName = BloodGroup.BloodGroupName;
            return View(BloodGroupModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BloodGroup model)
        {
            if (ModelState.IsValid)
            {
                var checkbloodGroup = onlineBloodBankDB.BloodGroupsTables.Where(b => b.BloodGroupName == model.BloodGroupName && b.BloodGroupID != model.BloodGroupId).FirstOrDefault();
                if (checkbloodGroup == null)
                {
                    var AddBloodGrooup = new BloodGroupsTable();
                    AddBloodGrooup.BloodGroupID = model.BloodGroupId;
                    AddBloodGrooup.BloodGroupName = model.BloodGroupName;
                    onlineBloodBankDB.Entry(AddBloodGrooup).State = EntityState.Modified;
                    onlineBloodBankDB.SaveChanges();
                    return RedirectToAction("AllBloodGroup");
                }
                else
                {
                    ModelState.AddModelError("BloodGroup", "Blood Group Already Exits");

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
            var BloodGroup = onlineBloodBankDB.BloodGroupsTables.Find(id);
            if (BloodGroup == null)
            {
                return HttpNotFound();
            }
            var BloodGroupModel = new BloodGroup();
            BloodGroupModel.BloodGroupId = BloodGroup.BloodGroupID;
            BloodGroupModel.BloodGroupName = BloodGroup.BloodGroupName;
            return View(BloodGroupModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfrim(int? id)
        {
            var BloodGroup = onlineBloodBankDB.BloodGroupsTables.Find(id);
            onlineBloodBankDB.BloodGroupsTables.Remove(BloodGroup);
            onlineBloodBankDB.SaveChanges();
            return RedirectToAction("AllBloodGroup");
        }

    }
}