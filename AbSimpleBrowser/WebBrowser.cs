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

        public void AccessWebPage()
        {
            // check that url set by user is valid
            //if not valid display 404 page

            if (!Uri.IsWellFormedUriString(this.Url, UriKind.Absolute))
                throw new ArgumentException("Invalid Url Suplied");

            if (!this.Url.StartsWith("http") || !this.Url.StartsWith("https"))
            {
                // https://learn.microsoft.com/en-us/dotnet/api/system.uribuilder?view=net-7.0&redirectedfrom=MSDN
                // make use of the Uri builder to build a proper url.
            }

            // call the client class to make the request and return the response

            var request = new HttpRequestMessage { RequestUri = new Uri(Url), Method = HttpMethod.Get };

            // and details of the browser to the header.

            using(var client = new HttpClient())
            {


                var response = client.GetAsync(Url).Result; //making the call synchronously
                var headers = response.Content.Headers;
                var data = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(data);
            }

            
            

            // pass a response in a certain format to the render engine to parse and display the reponse in plain text.
        }
    }
}
