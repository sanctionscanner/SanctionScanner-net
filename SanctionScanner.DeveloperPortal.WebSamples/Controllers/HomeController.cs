using SanctionScanner.DeveloperPortal.WebSamples.Models;
using System;
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

        public ActionResult GetMyOrganizationUsers()
        {
            var url = "api/Operations/GetMyOrganizationUsers";
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
        public ActionResult AssignUserToSearch()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AssignUserToSearch(string ScanId, int UserId)
        {
            var url = "api/Operations/AssignUserToSearch";
            var requestModel = new AssignUserModels();
            requestModel.ScanId = ScanId;
            requestModel.UserId = UserId;

            var response = HttpPost(url, requestModel);

            if (response != null)
            {
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(response);
                var model = new JsonResponse();
                model.response = json;
                return View(model);
            }

            return View();
        }
        public ActionResult SetSearchMatchStatus()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SetSearchMatchStatus(string ScanId, int StatusId)
        {
            var url = "api/Operations/SetSearchMatchStatus";
            var requestModel = new MatchStatusModels();
            requestModel.ScanId = ScanId;
            requestModel.StatusId = StatusId;

            var response = HttpPost(url, requestModel);

            if (response != null)
            {
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(response);
                var model = new JsonResponse();
                model.response = json;
                return View(model);
            }

            return View();
        }

        public ActionResult SetSearchRiskLevel()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SetSearchRiskLevel(string ScanId, int RiskLevelId)
        {
            var url = "api/Operations/SetSearchRiskLevel";
            var requestModel = new RiskLevelModels();
            requestModel.ScanId = ScanId;
            requestModel.RiskLevelId = RiskLevelId;

            var response = HttpPost(url, requestModel);

            if (response != null)
            {
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(response);
                var model = new JsonResponse();
                model.response = json;
                return View(model);
            }

            return View();
        }

        public ActionResult AddMemoToSearch()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMemoToSearch(string ScanId, string Memo)
        {
            var url = "api/Operations/AddMemoToSearch";
            var requestModel = new AddMemoModels();
            requestModel.ScanId = ScanId;
            requestModel.Memo = Memo;

            var response = HttpPost(url, requestModel);

            if (response != null)
            {
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(response);
                var model = new JsonResponse();
                model.response = json;
                return View(model);
            }

            return View();
        }

        public ActionResult AddSearchToSafeList()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSearchToSafeList(string ScanId)
        {
            var url = "api/Operations/SearchAddToSafeList";
            var requestModel = new SafeListModels();
            requestModel.ScanId = ScanId;

            var response = HttpPost(url, requestModel);

            if (response != null)
            {
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(response);
                var model = new JsonResponse();
                model.response = json;
                return View(model);
            }

            return View();
        }

        public ActionResult DeleteFromSafeListByReferenceNumber()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteFromSafeListByReferenceNumber(string ReferenceNumber)
        {
            var url = "api/Operations/DeleteFromSafeListByReferenceNumber";
            var requestModel = new DeleteFromSafeListModels();
            requestModel.ReferenceNumber = ReferenceNumber;

            var response = HttpPost(url, requestModel);

            if (response != null)
            {
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(response);
                var model = new JsonResponse();
                model.response = json;
                return View(model);
            }

            return View();
        }

        public ActionResult GetSearchByScanId()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetSearchByScanId(string ScanId)
        {
            var url = "api/Retrieving/GetSearchByScanId?scanId=" + ScanId;
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

        public ActionResult GetSearchesByReferenceNumber()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetSearchesByReferenceNumber(string ReferenceNumber)
        {
            var url = "api/Retrieving/GetSearchesByReferenceNumber?referenceNumber=" + ReferenceNumber;
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

        public ActionResult GetLastWeekStatistics()
        {
            var url = "api/Reports/GetLastWeekStatistics";
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

        public ActionResult GetStatisticsWithDateRange()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetStatisticsWithDateRange(string StartDate, string EndDate)
        {
            var url = "api/Reports/GetStatisticsWithDateRange?StartDate="+StartDate+"&EndDate="+EndDate;
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

        public ActionResult NewBlackList()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewBlackList(int TypeId, string FirstName, string SecondName, string LastName, string BirthDayDate, string NationalityId, int DocumentNumber, string OtherInformation, string ExtraInfo, string ReferenceNumber)
        {
            var url = "api/LocalList/NewBlackList";
            var requestModel = new NewBlackListModels();
            requestModel.TypeId = TypeId;
            requestModel.FirstName = FirstName;
            requestModel.SecondName = SecondName;
            requestModel.LastName = LastName;
            requestModel.BirthDayDate = BirthDayDate;
            requestModel.NationalityId = NationalityId;
            requestModel.DocumentNumber = DocumentNumber;
            requestModel.OtherInformation = OtherInformation;
            requestModel.ExtraInfo = ExtraInfo;
            requestModel.ReferenceNumber = ReferenceNumber;

            var response = HttpPost(url, requestModel);

            if (response != null)
            {
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(response);
                var model = new JsonResponse();
                model.response = json;
                return View(model);
            }

            return View();
        }

        public ActionResult GetBlackListById()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetBlackListById(string Guid)
        {
            var url = "api/LocalList/GetBlackListById?guid=" + Guid;
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

        public ActionResult UpdateBlackList()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateBlackList(int TypeId, string FirstName, string SecondName, string LastName, string BirthDayDate, string NationalityId, int DocumentNumber, string OtherInformation, string ExtraInfo, string Guid, string ReferenceNumber)
        {
            var url = "api/LocalList/UpdateBlackList";
            var requestModel = new UpdateBlackListModels();
            requestModel.TypeId = TypeId;
            requestModel.FirstName = FirstName;
            requestModel.SecondName = SecondName;
            requestModel.LastName = LastName;
            requestModel.BirthDayDate = BirthDayDate;
            requestModel.NationalityId = NationalityId;
            requestModel.DocumentNumber = DocumentNumber;
            requestModel.OtherInformation = OtherInformation;
            requestModel.ExtraInfo = ExtraInfo;
            requestModel.Guid = Guid;
            requestModel.ReferenceNumber = ReferenceNumber;

            var response = HttpPost(url, requestModel);

            if (response != null)
            {
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(response);
                var model = new JsonResponse();
                model.response = json;
                return View(model);
            }

            return View();
        }

        public ActionResult DeleteBlackList()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteBlackList(string Guid)
        {
            var url = "api/LocalList/DeleteBlackList";
            var requestModel = new DeleteBlackListModels();
            requestModel.Guid = Guid;

            var response = HttpPost(url, requestModel);

            if (response != null)
            {
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(response);
                var model = new JsonResponse();
                model.response = json;
                return View(model);
            }

            return View();
        }

        public ActionResult NewWhiteList()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewWhiteList(int TypeId, string Name, string IdentityNumber, string PassportNumber, string ReferenceNumber, string Description)
        {
            var url = "api/GeneralWhiteList/NewWhiteList";
            var requestModel = new NewWhiteListModels();
            requestModel.TypeId = TypeId;
            requestModel.Name = Name;
            requestModel.IdentityNumber = IdentityNumber;
            requestModel.PassportNumber = PassportNumber;
            requestModel.ReferenceNumber = ReferenceNumber;
            requestModel.Description = Description;

            var response = HttpPost(url, requestModel);

            if (response != null)
            {
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(response);
                var model = new JsonResponse();
                model.response = json;
                return View(model);
            }

            return View();
        }

        public ActionResult GetWhiteListById()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetWhiteListById(string Guid)
        {
            var url = "api/GeneralWhiteList/GetWhiteListById?guid=" + Guid;
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

        public ActionResult UpdateWhiteList()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateWhiteList(int TypeId, string Name, string IdentityNumber, string PassportNumber, string ReferenceNumber, string Description, string Guid)
        {
            var url = "api/GeneralWhiteList/UpdateWhiteList";
            var requestModel = new UpdateWhiteListModels();
            requestModel.TypeId = TypeId;
            requestModel.Name = Name;
            requestModel.IdentityNumber = IdentityNumber;
            requestModel.PassportNumber = PassportNumber;
            requestModel.ReferenceNumber = ReferenceNumber;
            requestModel.Description = Description;
            requestModel.Guid = Guid;

            var response = HttpPost(url, requestModel);

            if (response != null)
            {
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(response);
                var model = new JsonResponse();
                model.response = json;
                return View(model);
            }

            return View();
        }

        public ActionResult DeleteWhiteList()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteWhiteList(string Guid)
        {
            var url = "api/GeneralWhiteList/DeleteWhiteList?guid=" + Guid;
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