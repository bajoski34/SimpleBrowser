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
        public Action<string> HomePageSet;
        public string currentHomePage;

        private List<WebsiteDto> previousHomePages = new List<WebsiteDto>();
        public Home(ref string url)
        {
            InitializeComponent();
            currentHomePage = url;
        }

        private void setHomeBtn_Click(object sender, EventArgs e)
        {
            if(this.homeUrl.Text != "" )
            {
                string url = homeUrl.Text;

                if (!url.StartsWith("http://") && !url.StartsWith("https://"))
                {
                    currentHomePage = (new UriBuilder("https", url)).ToString();
                } else
                {
                    currentHomePage = this.homeUrl.Text;
                }

                WebsiteDto currentHomeWebsite = new WebsiteDto() { IsFavorite = true, Url = currentHomePage, VisitTimestamp = DateTime.Now.ToString() };

                WebsiteDto websiteFound = this.previousHomePages.Find(wb => wb.Url == currentHomeWebsite.Url);
                if (websiteFound == null)
                {
                    this.previousHomePages.Add(currentHomeWebsite);
                    currentHomePage = currentHomeWebsite.Url;
                    HomePageSet?.Invoke(currentHomePage);
                    homeUrl.Refresh();
                    homeUrl.DataSource = previousHomePages;
                    homeUrl.DisplayMember = "Url";
                    MessageBox.Show("Home url saved");
                } else
                {
                    MessageBox.Show("Selection saved!");
                }
                
                this.Close();
            } else
            {
                MessageBox.Show("Enter a new url to set as Homepage!");
            }
        }

        private void Init()
        {
            //set home to current homepage address on the field.
            //user can now edit itto their needs.
            this.homeUrl.Text = currentHomePage;
            
            //add current home to prvious home pages.
            WebsiteDto currentHomeWebsite = new WebsiteDto() { IsFavorite = true, Url = currentHomePage, VisitTimestamp = DateTime.Now.ToString() };
            this.previousHomePages.Add(currentHomeWebsite);

            //Display previous home pages.
            this.homeUrl.DataSource = previousHomePages;
            this.homeUrl.DisplayMember = "Url";
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.Init();
        }

    }
}
