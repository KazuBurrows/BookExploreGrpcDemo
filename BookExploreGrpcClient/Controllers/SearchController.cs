using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookExploreGrpcClient.Controllers
{
    public class SearchController : Controller
    {
        /// <summary>
        /// "Starts the send and gets and outputs db response."
        /// </summary>
        /// <param name="param_search">"User search query input."</param>
        /// <returns>"Table of book records from db."</returns>
        //[OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
        //[OutputCache(NoStore = true, Duration = 0)]
        [HttpGet]
        public ActionResult Search(string param_search)
        {


            

            return Json("Made it to search controller.", JsonRequestBehavior.AllowGet);
        }
    }
}