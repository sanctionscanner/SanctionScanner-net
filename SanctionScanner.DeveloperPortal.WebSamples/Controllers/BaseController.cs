using SanctionScanner.DeveloperPortal.WebSamples.Models;
using System.Web.Mvc;
using System;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
namespace SanctionScanner.DeveloperPortal.WebSamples.Controllers
{
    public class BaseController : Controller
    {
        public static Token token = new Token()
        {
            username= "",
            password= ""
        };


        public static Response HttpGet(string path)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage httpResponseMessage = null;
            Response response = null;
            try
            {
                client.BaseAddress = new Uri("https://api.sanctionscanner.com/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(token.username + ":" + token.password)));
                Task.Run(async () => { httpResponseMessage = await client.GetAsync(path); }).Wait();
                Task.Run(async () => { response = await httpResponseMessage.Content.ReadAsAsync<Response>(); }).Wait();
                return response;
            }
            catch (HttpRequestException ex)
            {
                throw ex;
            }
        }

        public static Response HttpPost(string path, object obj)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage httpResponseMessage = null;
            Response response = null;
            try
            {
                client.BaseAddress = new Uri("https://api.sanctionscanner.com/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(token.username + ":" + token.password)));

                Task.Run(async () => { httpResponseMessage = await client.PostAsJsonAsync(path, obj); }).Wait();
                Task.Run(async () => { response = await httpResponseMessage.Content.ReadAsAsync<Response>(); }).Wait();
                return response;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}