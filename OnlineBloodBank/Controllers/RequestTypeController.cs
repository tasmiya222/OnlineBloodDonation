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
    public class RequestTypeController : Controller
    {
        private OnlineBloodBankdbEntities onlineBloodBankDB = new OnlineBloodBankdbEntities();
        public ActionResult AllRequesttype()
        {
            var requestTypeList = onlineBloodBankDB.RequestTypeTables.ToList();
            var ListOfreqquestType = new List<RequestType>();
            foreach (var requestType in requestTypeList)
            {
                var addRequestType = new RequestType
                {
                    RequestTypeID = requestType.RequestTypeID,
                    RequestTypes = requestType.RequestTypeName
                };

                ListOfreqquestType.Add(addRequestType);
            }
            return View(ListOfreqquestType);
        }

        public ActionResult Create()
        {
            var newRequestType = new RequestType();
            return View(newRequestType);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RequestType requestType)
        {
            if(ModelState.IsValid)
            {
                var AddRequestTypes = new RequestTypeTable();
                AddRequestTypes.RequestTypeID = requestType.RequestTypeID;
                AddRequestTypes.RequestTypeName = requestType.RequestTypes;
                onlineBloodBankDB.RequestTypeTables.Add(AddRequestTypes);
                onlineBloodBankDB.SaveChanges();
                return RedirectToAction("AllRequesttype");
            }
            return View(requestType);
        }

        public ActionResult Edit(int?id)
        {
            var requestType = onlineBloodBankDB.RequestTypeTables.Find(id);
            if(requestType == null)
            {
                return HttpNotFound();
            }
            var requestTypeModel = new RequestType();
            requestTypeModel.RequestTypeID = requestType.RequestTypeID;
            requestTypeModel.RequestTypes= requestType.RequestTypeName;
            return View(requestTypeModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(RequestType requestType)
        {
            if (ModelState.IsValid)
            {
                var AddRequestTypes = new RequestTypeTable();
                AddRequestTypes.RequestTypeID = requestType.RequestTypeID;
                AddRequestTypes.RequestTypeName = requestType.RequestTypes;
                onlineBloodBankDB.Entry(AddRequestTypes).State = EntityState.Modified;
                onlineBloodBankDB.SaveChanges();
                return RedirectToAction("AllRequesttype");
            }
            return View(requestType);
        }

        public ActionResult Delete(int ? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            var requestType = onlineBloodBankDB.RequestTypeTables.Find(id);
            if(requestType == null)
            {
                return HttpNotFound();
            }
            var RequestModel = new RequestType();
            RequestModel.RequestTypeID = requestType.RequestTypeID;
            RequestModel.RequestTypes = requestType.RequestTypeName;
            return View(RequestModel);
        }

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfrim(int ?id)
        {
            var requestType = onlineBloodBankDB.RequestTypeTables.Find(id);
            onlineBloodBankDB.RequestTypeTables.Remove(requestType);
            onlineBloodBankDB.SaveChanges();
            return RedirectToAction("AllRequesttype");
        }

    }
}