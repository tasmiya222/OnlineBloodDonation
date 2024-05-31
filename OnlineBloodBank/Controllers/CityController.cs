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
    public class CityController : Controller
    {
        private OnlineBloodBankdbEntities onlineBloodBankDB = new OnlineBloodBankdbEntities();

        // GET: City
        public ActionResult AllCity()
        {
            var CityList = onlineBloodBankDB.CityTables.ToList();
            var ListOfCity = new List<City>();
            foreach (var City in CityList)
            {
                var addCity = new City
                {
                    CityID= City.CityID,
                    CityName = City.CityName
                };

                ListOfCity.Add(addCity);
            }
            return View(ListOfCity);
        }
        public ActionResult Create()
        {
            var newCity = new City();
            return View(newCity);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(City city)
        {
            if (ModelState.IsValid)
            {
                var AddCity = new CityTable();
                AddCity.CityID = city.CityID;
                AddCity.CityName = city.CityName;
                onlineBloodBankDB.CityTables.Add(AddCity);
                onlineBloodBankDB.SaveChanges();
                return RedirectToAction("AllCity");
            }
            return View(city);
        }

        public ActionResult Edit(int? id)
        {
            var City = onlineBloodBankDB.CityTables.Find(id);
            if (City == null)
            {
                return HttpNotFound();
            }
            var CityModel  = new City();
            CityModel.CityID= City.CityID;
            CityModel.CityName= City.CityName;
            return View(CityModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(City City)
        {
            if (ModelState.IsValid)
            {
                var AddCity = new CityTable();
                AddCity.CityID = City.CityID;
                AddCity.CityName = City.CityName;
                onlineBloodBankDB.Entry(AddCity).State = EntityState.Modified;
                onlineBloodBankDB.SaveChanges();
                return RedirectToAction("AllCity");
            }
            return View(City);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            var City = onlineBloodBankDB.CityTables.Find(id);
            if (City == null)
            {
                return HttpNotFound();
            }
            var AddCity = new CityTable();
            AddCity.CityID = City.CityID;
            AddCity.CityName = City.CityName;
            return View(City);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfrim(int? id)
        {
            var city = onlineBloodBankDB.CityTables.Find(id);
            onlineBloodBankDB.CityTables.Remove(city);
            onlineBloodBankDB.SaveChanges();
            return RedirectToAction("AllCity");
        }

    }
}