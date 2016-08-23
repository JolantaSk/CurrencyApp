using CurrencyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CurrencyApp.services
{
    public class ComparingService
    {

        private IEnumerable<ComparedRate> GetComparedRates(IEnumerable<CurrencyRate> rates, IEnumerable<CurrencyRate> pastRates)
        {
            List<ComparedRate> result = new List<ComparedRate>();
            foreach(var rate in rates)
            {
                var pastRate = pastRates.First(r => r.Country == rate.Country).Rate;

                result.Add(new ComparedRate {
                    Country = rate.Country,
                    Rate = rate.Rate,
                    PastRate = pastRate,
                    Unit = rate.Unit,
                    Quantity = rate.Quantity,
                    Change = rate.Rate - pastRate,
                    Date = rate.Date
                });
            }

            return result;
        }

        private IEnumerable<ComparedRate> GetSortedRatesDesc(IEnumerable<ComparedRate> rates)
        {
            return rates.OrderByDescending(r=>Math.Abs(r.Change)).ToList();
        }

        public IEnumerable<ComparedRate> GetComparedAndSortedRates(IEnumerable<CurrencyRate> rates, IEnumerable<CurrencyRate> pastRates)
        {
            IEnumerable<ComparedRate> result = GetComparedRates(rates, pastRates);
            return GetSortedRatesDesc(result);
        }
    }
}