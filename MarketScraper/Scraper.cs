﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace MarketScraper
{
    public class Scraper
    {
        public Scraper()
        {
            BiedrImg = new List<string>();
            SparImg = new List<string>();
            LidlPromos = new List<LidlProduct>();
        }

        public void ScrapeImages()
        {
            var web = new HtmlWeb(); 
            var doc = web.Load("https://www.biedronka.pl/pl/ale-tydzien");
            var Links = doc.DocumentNode.SelectNodes("//div[@id='container']/div[@class='inner']/div[@class='grid']/div/span/img[2]");

            foreach (var link in Links)
            {
                string url = link.GetAttributeValue("src", "");
                if (url != "") BiedrImg.Add(url);
            }
            
            doc = web.Load("https://spar.pl/promocje/");

            Links = doc.DocumentNode.SelectNodes("//div[@class='block flex promocje']/div/img");

            foreach (var link in Links)
            {
                string url = link.GetAttributeValue("src", "");
                if (url != "") SparImg.Add(url);
            }
        }

        public void ScrapeLidl(string page)
        {
            var web = new HtmlWeb();
            var doc = web.Load(page);

            var Links = doc.DocumentNode.SelectNodes("//div[@class='page__main']/div/section/div/ul/li/div[2]/div/div/div[2]/div/div/div/a");

            foreach(var link in Links)
            {
                var url = link.GetAttributeValue("href", "");
                if (url != "")
                {
                    doc = web.Load("https://www.lidl.pl/" + url);
                    var Products = doc.DocumentNode.SelectNodes("//div[@class='page__main']/div/div/section/div/div/div");

                    foreach(var Product in Products)
                    {

                    }
                }
            }
        }

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

        public static Image ScaleImage(Image img, int width)
        {
            int height = img.Height/(img.Width / width);

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

        public List<string> BiedrImg { get; private set; }
        public List<string> SparImg { get; private set; }
        public List<LidlProduct> LidlPromos { get; private set; }

        public struct LidlProduct
        {
            public string imageUrl;
            public string name;
            public float price;
            public string weight;
        }
    }
}
