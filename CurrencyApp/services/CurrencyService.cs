using CurrencyApp.CurrencyRates;
using CurrencyApp.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Linq;

namespace CurrencyApp.services
{
    public class CurrencyService
    {
        [WebMethod]
        public List<CurrencyRate> GetCurrencyRates(string date)
        {           
            ExchangeRatesSoapClient client = new ExchangeRatesSoapClient();
            var response = client.getExchangeRatesByDate(date).InnerXml;
            response = string.Format("<root> {0} </root>", response);
            var rates = XElement.Parse(response);

            var rateList = rates.Elements("item").Select(rate => new CurrencyRate()
            {
                Date = DateTime.ParseExact(rate.Element("date").Value.ToString(), "yyyy.MM.dd", CultureInfo.InvariantCulture),
                Country = rate.Element("currency").Value,
                Rate = decimal.Parse(rate.Element("rate").Value),
                Unit = rate.Element("unit").Value,
                Quantity = int.Parse(rate.Element("quantity").Value)
            }).ToList();

            return rateList;
        }

    }
}