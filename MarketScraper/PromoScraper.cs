using System;
using System.Collections.Generic;
using HtmlAgilityPack;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;

namespace MarketScraper
{
    public class PromoScraper
    {
        public PromoScraper()
        {
            BiedrImg = new List<string>();
            SparImg = new List<string>();
            LidlPromos = new List<Product>();
        }

        /// <summary>
        /// Scrapes image urls of discount products from Biedronka and Spar Sites
        /// </summary>
        public void ScrapeImages()
        {
            var web = new HtmlWeb(); 
            var doc = web.Load("https://www.biedronka.pl/pl/ale-tydzien");
            
            var Links = doc.DocumentNode.SelectNodes("//div[@id='container']/div[@class='inner']/div[@class='grid']/div/span/img[2]");

            if (Links != null) foreach (var link in Links)
            {
                string url = link.GetAttributeValue("src", "");
                if (url != "") BiedrImg.Add(url);
            }
            
            doc = web.Load("https://spar.pl/promocje/");

            Links = doc.DocumentNode.SelectNodes("//div[@class='block']/div[@class='flex']/div/div[2]/a/img");

            if (Links != null) foreach (var link in Links)
            {
                string url = link.GetAttributeValue("src", "");
                if (url != "") SparImg.Add(url);
            }
        }

        /// <summary>
        /// Scrapes weekly discount products and new products from Lidl site
        /// </summary>
        /// <param name="page">Link to the lidl products site</param>
        public void ScrapeLidl(string page)
        {
            var web = new HtmlWeb();
            var doc = web.Load(page);

            var Links = doc.DocumentNode.SelectNodes("//div[@class='page__main']/div/section/div/ul/li[1]/div[2]/div/div/div[2]/div/div/div/a");    //li[2] nastepny tydzien

            if (Links != null) foreach (var link in Links)
            {
                var url = link.GetAttributeValue("href", "");
                if (url != "")
                {
                    doc = web.Load("https://www.lidl.pl" + url);
                    var Products = doc.DocumentNode.SelectNodes("//div/div/div/section/div/div/div[@data-currency!='']");

                    if (Products != null) foreach (var Product in Products)
                    {
                        try
                        {
                            url = Product.SelectSingleNode(".//article/a/div/picture/source").GetAttributeValue("srcset", "").Split(',')[0];
                            var productName = Product.GetAttributeValue("data-name", "");
                            var price = Product.GetAttributeValue("data-price", "").Replace(',', '.');
                            var weight = Product.SelectSingleNode(".//article/a/span/div/div[2]").InnerText.Trim();

                            LidlPromos.Add(new Product(url, productName, float.Parse(price, CultureInfo.InvariantCulture.NumberFormat), weight));
                        }
                        catch (Exception corruptProduct)
                        {

                        }
                    }
                }
            }
        }

        /// <summary>
        /// Pretends to be a human to be able to download an image
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <returns></returns>
        public static Image DownloadImageFromUrl(string imageUrl)
        {
            Image image = null;

            try
            {
                System.Net.HttpWebRequest webRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(imageUrl);
                webRequest.AllowWriteStreamBuffering = true;
                webRequest.Timeout = 30000;
                webRequest.UserAgent = "[any words that is more than 5 characters]";
                webRequest.Referer = imageUrl;

                System.Net.WebResponse webResponse = webRequest.GetResponse();
                System.IO.Stream stream = webResponse.GetResponseStream();

                image = Image.FromStream(stream);

                webResponse.Close();
            }
            catch (Exception ex)
            {
                return null;
            }

            return image;
        }

        /// <summary>
        /// Changes height of an image keeping aspect ratio, scaling to given width
        /// </summary>
        /// <param name="img"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        public static Image ScaleImage(Image img, int width)
        {
            try
            {
                int height = img.Height / (img.Width / width);

                var destRect = new Rectangle(0, 0, width, height);
                var OutputImage = new Bitmap(width, height);

                using (var graphics = Graphics.FromImage(OutputImage))
                {
                    graphics.CompositingMode = CompositingMode.SourceCopy;
                    graphics.CompositingQuality = CompositingQuality.HighQuality;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                    using (var wrapMode = new ImageAttributes())
                    {
                        wrapMode.SetWrapMode(WrapMode.Clamp);
                        graphics.DrawImage(img, destRect, 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, wrapMode);
                    }
                }

                return OutputImage;
            }
            catch(Exception ImageError)
            {
                return ScaleImage(DownloadImageFromUrl("https://e-spar.com.pl/brak.png"), width);
            }
        }

        public List<string> BiedrImg { get; private set; }
        public List<string> SparImg { get; private set; }
        public List<Product> LidlPromos { get; private set; }

        /// <summary>
        /// Product template
        /// </summary>
        public struct Product
        {
            public Product(string imageUrl, string name, float price, string weight)
            {
                this.imageUrl = imageUrl;
                this.name = name;
                this.price = price;
                this.weight = weight;
            }

            public string imageUrl;
            public string name;
            public float price;
            public string weight;
        }
    }
}
