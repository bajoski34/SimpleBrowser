using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbSimpleBrowser
{
    enum Menu_Settings { Home_Url_Change=1, View_History, View_Downloads, View_Favorites, Change_Themes }
    class Settings
    {
        public int ID { get; set; }
        public string Text { get; set; }
    }


}
