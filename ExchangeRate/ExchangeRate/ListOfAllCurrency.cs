using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Xml.Linq;

namespace ExchangeRate
{
    public class ListOfAllCurrency
    {
        public List<Currency> Currencies { get; }

        public ListOfAllCurrency()
        {
            Currencies = new List<Currency>();
            FillList();
        }

        private void FillList()
        {
            string url = "http://www.nbg.ge/rss.php";
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Chrome");
            string content = httpClient.GetStringAsync(url).Result;
            XElement s = XElement.Parse(content);

            var resource = XElement.Parse(content);
            var description = resource.Element("channel").Element("item").Element("description");
            string value = description.Value.Replace("gif\">", "gif\"></img>");

            XElement xElement = XElement.Parse(value);

            foreach (var item in xElement.Elements())
            {
                var elementCurency = item.Elements("td").ToList();
                Currency newCurrency = new Currency
                {
                    Code = elementCurency[0].Value,
                    Name = elementCurency[1].Value,
                    Rate = Convert.ToDouble(elementCurency[2].Value)
                };
                Currencies.Add(newCurrency);
            }
            Currency gel = new Currency
            {
                Code = "GEL",
                Name = "1 ქართული ლარი",
                Rate = 1
            };
            Currencies.Add(gel);
        }
    }
}
