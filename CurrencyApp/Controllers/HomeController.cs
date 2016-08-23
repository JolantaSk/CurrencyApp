using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace CurrencyApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public void GetCurrencyRates()
        {
            //string url = @"http:/ldb.lt/webservices/ExchangeRates/ExchangeRates.asmx/getExchangeRatesByDate";
            //string urlParams = string.Format("?date={0}", DateTime.Now.ToShortDateString());

            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri(url);

            //client.DefaultRequestHeaders.Accept.Add(
            //new MediaTypeWithQualityHeaderValue("application/json"));

            //// List data response.
            //HttpResponseMessage response = client.GetAsync(urlParams).Result;  // Blocking call!
            //if (response.IsSuccessStatusCode)
            //{
            //    // Parse the response body. Blocking!
            //    //var dataObjects = response.Content.ReadAsAsync<IEnumerable<DataObject>>().Result;
            //    //foreach (var d in dataObjects)
            //    //{
            //    //    Console.WriteLine("{0}", d.Name);
            //    //}
            //}
            //else
            //{
            //    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            //}
        }
    }
}