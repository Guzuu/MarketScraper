using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace MarketScraper
{
    public class QueryScraper
    {
        //https://www.biedronka.pl/pl/searchhub,query,
        //https://e-spar.com.pl/index/asortyment?sort=relevancy.desc&query=

        public QueryScraper()
        {
            BiedronkaProducts = new List<PromoScraper.Product>();
            SparProducts = new List<PromoScraper.Product>();
        }

        public void ScrapeBiedronka(string query)
        {
            var web = new HtmlWeb();
            var doc = web.Load("https://www.biedronka.pl/pl/searchhub,query," + query);

            var Links = doc.DocumentNode.SelectNodes("//div[@id='container']/div[@class='inner']/div[@class='search-result']/div/div/div/div/div/a");
            
            if (Links != null) foreach (var link in Links)
            {
                string url = link.GetAttributeValue("href", "");
                    if (url != "")
                    {
                        doc = web.Load("https://www.biedronka.pl" + url);
                        try
                        {
                            var imgUrl = doc.DocumentNode.SelectSingleNode("//div[@id='container']/div[2]/div/div/article/div/div/img").GetAttributeValue("src", "");
                            var name = doc.DocumentNode.SelectSingleNode("//div[@id='container']/div[2]/div/div/article/div/h3").InnerText;
                            var price = doc.DocumentNode.SelectSingleNode("//div[@id='container']/div[2]/div/div/article/div/div/div/span/span/span/span/span").InnerText + '.' + doc.DocumentNode.SelectSingleNode("//div[@id='container']/div[2]/div/div/article/div/div/div/span/span/span/span/span[2]/span").InnerText;
                            var weight = doc.DocumentNode.SelectSingleNode("//div[@id='container']/div[2]/div/div/article/div/span/span[2]").InnerText.Trim();

                            BiedronkaProducts.Add(new PromoScraper.Product(imgUrl, name, float.Parse(price, CultureInfo.InvariantCulture.NumberFormat), weight));
                        }
                        catch (Exception corruptProduct)
                        {

                        }
                    }
            }
        }

        public void ScrapeSpar(string query)
        {
            var web = new HtmlWeb();
            var doc = web.Load("https://e-spar.com.pl/index/asortyment/query/" + query);

            var Products = doc.DocumentNode.SelectNodes("//div[@id='page']/main/div/div[2]/div[2]/div/div/div/div/div/form");

            if (Products != null) foreach (var product in Products)
                {
                    try
                    {
                        var imgUrl = product.SelectSingleNode(".//h3/a/span/img").GetAttributeValue("src", "");
                        var name = product.SelectSingleNode(".//h3/a/span[2]").InnerText;
                        var price = product.SelectSingleNode(".//span/em/span").InnerText.Replace(',', '.');
                        var weight = product.SelectSingleNode(".//h3/a/span/span/span").InnerText;

                        SparProducts.Add(new PromoScraper.Product(imgUrl, name, float.Parse(price, CultureInfo.InvariantCulture.NumberFormat), weight));
                    }
                    catch (Exception corruptProduct)
                    {

                    }
                }
        }

        public List<PromoScraper.Product> BiedronkaProducts { get; private set; }
        public List<PromoScraper.Product> SparProducts { get; private set; }
    }
}
