using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace AbSimpleBrowser
{
    class Client
    {
        public string Url;
        public string Name = "Abe/v1.0";
        public int status { get; set; }

        public string AccessWebPage()
        {

            // if (!Uri.IsWellFormedUriString(this.Url, UriKind.Absolute))
                //throw new ArgumentException("Invalid Url Suplied");

            if (!this.Url.StartsWith("http://") && !this.Url.StartsWith("https://"))
            {
                if(this.Url.StartsWith("status.savanttools"))
                {
                    this.Url = "http://" + this.Url;
                } else
                {
                    this.Url = (new UriBuilder("https", Url)).ToString();
                }
                // https://learn.microsoft.com/en-us/dotnet/api/system.uribuilder?view=net-7.0&redirectedfrom=MSDN
                // make use of the Uri builder to build a proper url.
            }

            // call the client class to make the request and return the response
            Console.WriteLine(Url);
            ///var request = new HttpRequestMessage { RequestUri = new Uri(Url), Method = HttpMethod.Get };

            var client = new HttpClient();

            try
            {
                var response = client.GetAsync(Url).Result; //making the call synchronously
                var headers = response.Content.Headers;
                this.status = (int)((HttpStatusCode)(response.StatusCode));
                var data = response.Content.ReadAsStringAsync().Result;
                return data;
            }
            catch(Exception ex) {
                this.status = (int)((HttpStatusCode.NotFound));
                return "<html><head><title>Not Found<title></head><p>"+ ex.Message.ToString() + "</p><html>";
            }
        }
    }
}
