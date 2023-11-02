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
        private static int count = 0;
        public Favorite()
        {
            InitializeComponent();
        }

        private void Favorite_Load(object sender, EventArgs e)
        {
        }

        private void addSite_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty("") || string.IsNullOrEmpty(""))
                return;
        }

        public void UpdateUiOnFavoriteStackUpdate( string url, string timestamp )
        {
            count++;
            ListViewItem website = new ListViewItem(count.ToString());
            website.SubItems.Add(url);
            website.SubItems.Add(timestamp);
            listView1.Items.Add(website);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
