using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using TestApp.Models;

namespace TestApp.Controllers
{
    public class HomeController : Controller
    {
        private hcid_lookupEntities db = new hcid_lookupEntities();
        public ActionResult Index(string StreetAddress)
        {
            List<Bims2ViewModel> bvm = new List<Bims2ViewModel>();
            List<Rent2ViewModel> rvm = new List<Rent2ViewModel>();
            //var bims2return = (from bim in db.bims2
            //                  where bim.Property_Address.Contains(StreetAddress1)
            //                  select bim).Take(1);
            //var rent2return = (from rent in db.bims2
            //                  where rent.Property_Address.Contains(StreetAddress1)
            //                  select rent).Take(1);
            if (StreetAddress != null)
            {
                bims2 bims2return = db.bims2.Where(y => y.Property_Address.Contains(StreetAddress)).First();
                rent2 rent2return = db.rent2.Where(y => y.Property_Address.Contains(StreetAddress)).First();
                bvm.Add(new Bims2ViewModel { StatementNum = bims2return.StatementNum, APN = bims2return.APN });
                rvm.Add(new Rent2ViewModel { APN = rent2return.APN, Property_Address = rent2return.Property_Address });
                ModelTotal finalItem = new ModelTotal();
                finalItem.Bims2List = bvm;
                finalItem.Rent2List = rvm;
                return View(finalItem);
            } else
            {
                StreetAddress = "8325 DUCOR AVE";
                bims2 bims2return = db.bims2.Where(y => y.Property_Address.Contains(StreetAddress)).First();
                rent2 rent2return = db.rent2.Where(y => y.Property_Address.Contains(StreetAddress)).First();
                bvm.Add(new Bims2ViewModel { StatementNum = bims2return.StatementNum, APN = bims2return.APN, StatementDate = bims2return.StatementDate, Property_Address = bims2return.Property_Address, Property_City_State_Zip = bims2return.Property_City_State_Zip });
                rvm.Add(new Rent2ViewModel { APN = rent2return.APN, Property_Address = rent2return.Property_Address, Service_Date = rent2return.Service_Date, Land_Use_Code = rent2return.Land_Use_Code , Unit_Count =rent2return.Unit_Count });
                ModelTotal finalItem = new ModelTotal();
                finalItem.Bims2List = bvm;
                finalItem.Rent2List = rvm;
                return View(finalItem);
            }
        }

        public ActionResult AboutPart()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}