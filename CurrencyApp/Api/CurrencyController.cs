using CurrencyApp.Models;
using CurrencyApp.services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace CurrencyApp.Api
{
    public class CurrencyController : ApiController
    {
        private CurrencyService _service;
        private ComparingService _comparer;

        public CurrencyController()
        {
             _service = new CurrencyService();
             _comparer = new ComparingService();
        }

        [HttpGet]
        public IEnumerable<ComparedRate> Get(string date)
        {
            var requestedRates =  _service.GetCurrencyRates(date);
            var pastRates = _service.GetCurrencyRates(DateTime.Parse(date).AddDays(-1).ToString());

            return _comparer.GetComparedAndSortedRates(requestedRates, pastRates);
        }
    }
}
