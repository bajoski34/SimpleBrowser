using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbSimpleBrowser
{
    public partial class Favorite : Form
    {
        public Action<bool> MarkedAsFavorite;
        public Favorite()
        {
            InitializeComponent();
        }

        private void Favorite_Load(object sender, EventArgs e)
        {

        }

        private void MarkAsFavorite(WebsiteDto website)
        {
            website.IsFavorite = true;
            MarkedAsFavorite?.Invoke(website.IsFavorite);
        }

        private void addSite_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty("") || string.IsNullOrEmpty(""))
                return;
        }
    }
}
