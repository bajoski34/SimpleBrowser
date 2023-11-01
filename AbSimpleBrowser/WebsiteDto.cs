using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbSimpleBrowser
{
    class WebsiteDto
    {
        public String Url { get; set; }
        public String VisitTimestamp { get; set; }

        public bool IsFavorite { get; set; } = false;
    }
}
