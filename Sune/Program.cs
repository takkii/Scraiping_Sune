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

            // サンプル
            //var idP = doc.GetElementById("id-p");
            //Console.WriteLine("GetElementById : {0}", idP.TextContent);
            //var classpList = doc.GetElementsByClassName("class-p");
            //foreach (var c in classpList)
            //{
            //    Console.WriteLine("GetElementsByClassName [class-p] : {0}", c.TextContent);
            //}
            // var elements = doc.Body.QuerySelectorAll("p.class-p");
            // foreach (var e in elements)
            // {
            //    Console.WriteLine("QuerySelectorAll [class-p] : {0}", e.TextContent);
            // }
        }
    }
}
