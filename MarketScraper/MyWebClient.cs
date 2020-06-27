using HtmlAgilityPack;
using System;
using System.IO;
using System.Net;

namespace MarketScraper
{
    /// <summary>
    /// Class required to get and hold a cookie of user's location
    /// </summary>
    public class MyWebClient
    {
        //The cookies will be here.
        private CookieContainer _cookies = new CookieContainer();

        //In case you need to clear the cookies
        public void ClearCookies()
        {
            _cookies = new CookieContainer();
        }

        /// <summary>
        /// downloads html document and gets the cookies of connection
        /// </summary>
        /// <param name="url">website link</param>
        /// <returns>html document</returns>
        public HtmlDocument GetPage(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            //Set more parameters here...
            //...

            //This is the important part.
            request.CookieContainer = _cookies;

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                var stream = response.GetResponseStream();

                //When you get the response from the website, the cookies will be stored
                //automatically in "_cookies".

                using (var reader = new StreamReader(stream))
                {
                    string html = reader.ReadToEnd();
                    var doc = new HtmlDocument();
                    doc.LoadHtml(html);
                    return doc;
                }
            }
            catch (Exception NotFound404)
            {
                return null;
            }
        }
    }
}
