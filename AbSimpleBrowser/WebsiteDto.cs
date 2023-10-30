using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbSimpleBrowser
{
    class WebsiteDto
    {
        public string Url { get; set; }
        public string VisitTimestamp { get; set; }

        public bool IsFavorite { get; set; } = false;
    }
}
