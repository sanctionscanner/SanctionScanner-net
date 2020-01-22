using SanctionScanner.DeveloperPortal.WebSamples.Models;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace SanctionScanner.DeveloperPortal.WebSamples.Controllers
{
    public class HomeController : BaseController
    {
        
        public ActionResult Index()
        {
         
            return View();
        }
        public ActionResult SearchByName()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SearchByName(string name,int searchType, int start, int limit, string outReferenceNumber, string birthYear, int minMatchRate, string referenceNumber, bool isDeepSearch)
        {
            var url = "api/Search/SearchByName?name="+name+"&searchType="+searchType+"&start="+ start + "&limit="+ limit + "&referenceNumber="+ referenceNumber+"&outReferenceNumber=" + outReferenceNumber +
                "&birthYear="+ birthYear+ "&minMatchRate=" + minMatchRate + "&isDeepSearch=" + isDeepSearch;
            var response = HttpGet(url);
            if(response!=null)
            {
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(response);
                var model = new JsonResponse();
                model.response = json;
                return View(model);
            }

            return View();
        }

        public ActionResult SearchByIdentity()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SearchByIdentity(string id,int start, int limit, string outReferenceNumber,string referenceNumber)
        {
            var url = "api/Search/SearchByIdentity?id=" + id + "&start=" + start + "&limit=" + limit + "&referenceNumber=" + referenceNumber + "&outReferenceNumber=" + outReferenceNumber;
            var response = HttpGet(url);
            if (response != null)
            {
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(response);
                var model = new JsonResponse();
                model.response = json;
                return View(model);
            }

            return View();
        }

        public ActionResult SearchByPassportNo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SearchByPassportNo(string passportNo, int start, int limit, string outReferenceNumber, string referenceNumber)
        {
            var url = "api/Search/SearchByPassportNo?passportNo=" + passportNo + "&start=" + start + "&limit=" + limit + "&referenceNumber=" + referenceNumber + "&outReferenceNumber=" + outReferenceNumber;
            var response = HttpGet(url);
            if (response != null)
            {
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(response);
                var model = new JsonResponse();
                model.response = json;
                return View(model);
            }

            return View();
        }

        public ActionResult SearchByHashedIdentity()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SearchByHashedIdentity(string id, int start, int limit, string outReferenceNumber, string referenceNumber)
        {
            var url = "api/Search/SearchByHashedIdentity?id=" + id + "&start=" + start + "&limit=" + limit + "&referenceNumber=" + referenceNumber + "&outReferenceNumber=" + outReferenceNumber;
            var response = HttpGet(url);
            if (response != null)
            {
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(response);
                var model = new JsonResponse();
                model.response = json;
                return View(model);
            }

            return View();
        }

        public ActionResult SearchByHashedPassportNo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SearchByHashedPassportNo(string passportNo, int start, int limit, string outReferenceNumber, string referenceNumber)
        {
            var url = "api/Search/SearchByHashedPassportNo?passportNo=" + passportNo + "&start=" + start + "&limit=" + limit + "&referenceNumber=" + referenceNumber + "&outReferenceNumber=" + outReferenceNumber;
            var response = HttpGet(url);
            if (response != null)
            {
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(response);
                var model = new JsonResponse();
                model.response = json;
                return View(model);
            }

            return View();
        }
    }
}