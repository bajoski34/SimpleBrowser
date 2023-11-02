using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbSimpleBrowser
{
    
    class FavoriteManager
    {
        public Action<string,string> MarkedAsFavorite;
        private List<WebsiteDto> favoriteStack = new List<WebsiteDto>();

        public void Add(WebsiteDto website)
        {
            this.favoriteStack.Add(website);
            MarkedAsFavorite(website.Url, website.VisitTimestamp);
        }

        public void Remove(WebsiteDto website)
        {
            this.favoriteStack.Remove(website);
        }
    }
}
