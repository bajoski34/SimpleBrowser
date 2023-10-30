using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace AbSimpleBrowser
{
    class WebBrowser
    {
        public string Url;
        public string Name = "Abe/v1.0";
        public string Html = "";

        public string AccessWebPage()
        {

            // if (!Uri.IsWellFormedUriString(this.Url, UriKind.Absolute))
                //throw new ArgumentException("Invalid Url Suplied");

            if (!this.Url.StartsWith("http://") && !this.Url.StartsWith("https://"))
            {
                // https://learn.microsoft.com/en-us/dotnet/api/system.uribuilder?view=net-7.0&redirectedfrom=MSDN
                // make use of the Uri builder to build a proper url.

                if(!this.Url.Contains(".com"))
                {
                    this.Url = (new UriBuilder("https", Url + ".com")).ToString();
                } else
                {
                    this.Url = (new UriBuilder("https", Url)).ToString();
                }  
            }

            // call the client class to make the request and return the response
            Console.WriteLine(Url);
            ///var request = new HttpRequestMessage { RequestUri = new Uri(Url), Method = HttpMethod.Get };

            var client = new HttpClient();
            var response = client.GetAsync(Url).Result; //making the call synchronously
            var headers = response.Content.Headers;
            var data = response.Content.ReadAsStringAsync().Result;
            return data;
        }
    }
}
