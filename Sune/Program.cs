using System;
using System.IO;
using AngleSharp.Html.Parser;
using System.Net;

namespace Sune
{
    class Ashi
    {
        public static void Main()
        {
            WebClient wctd = new WebClient();
            wctd.DownloadFile(
              "https://rubyist.hatenablog.com",
              "index.html");

            var html = File.ReadAllText("index.html", System.Text.Encoding.UTF8);
            var parser = new HtmlParser();
            var doc = parser.ParseDocument(html);

            var tit = doc.Title;
            Console.WriteLine(tit);
        }
    }
}
