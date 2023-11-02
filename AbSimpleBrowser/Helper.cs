using HtmlAgilityPack;
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbSimpleBrowser
{
    class Helper
    {
        public static string Get_Title(string html)
        {
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            //get title.
            var titleElement = htmlDocument.DocumentNode.SelectSingleNode("//title");
            var title = titleElement.InnerText.Trim();
            Console.WriteLine(title);
            return title;
        }
    }
}
