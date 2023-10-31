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
    public partial class Home : Form
    {
        public string currentHomePage;
        public Home(ref string url)
        {
            InitializeComponent();
            currentHomePage = url;
        }

        private void homeUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void setHomeBtn_Click(object sender, EventArgs e)
        {
            if(this.homeUrl.Text != "")
            {
                string url = homeUrl.Text;

                if (!url.StartsWith("http://") && !url.StartsWith("https://"))
                {
                    currentHomePage = (new UriBuilder("https", url)).ToString();
                } else
                {
                    currentHomePage = this.homeUrl.Text;
                }
                
                MessageBox.Show("Home url saved");
                this.Hide();
            } else
            {
                MessageBox.Show("Enter a new url to set as Homepage!");
            }
        }
    }
}
