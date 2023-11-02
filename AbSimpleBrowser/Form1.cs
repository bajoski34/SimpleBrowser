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
    public partial class Form1 : Form
    {
        public string DefaultHome = "https://www.hw.ac.uk";
        private List<WebsiteDto> historyStack = new List<WebsiteDto>();
        private WebsiteDto currentWebsite = null;
        private Home homeWindow;
        private History historyWindow;
        private Favorite favoriteWindow;
        private FavoriteManager favoriteManager = new FavoriteManager();
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            //Setup tooltip for navigation
            SetToolTipsToActions();

            // Prepare the settings dropdown.
            List<Settings> menu = new List<Settings>();
            menu.Add(new Settings() { ID = (int)(Menu_Settings)Menu_Settings.Home_Url_Change , Text = "see home address" });
            menu.Add(new Settings() { ID = (int)(Menu_Settings)Menu_Settings.View_History, Text = "see all  history" });
            menu.Add(new Settings() { ID = (int)(Menu_Settings)Menu_Settings.View_Favorites, Text = "see favorites" });
            menu.Add(new Settings() { ID = (int)(Menu_Settings)Menu_Settings.View_Downloads, Text = "see all downloads" });
            menu.Add(new Settings() { ID = (int)(Menu_Settings)Menu_Settings.Change_Themes, Text = "change themes" });
            this.settingsDrpDown.DataSource = menu;
            this.settingsDrpDown.DisplayMember = "Text";
        }

        private void SetToolTipsToActions()
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.isFavorite, "Favorites");
            ToolTip1.SetToolTip(this.button2, "Click to go foward.");
            ToolTip1.SetToolTip(this.button3, "Click to go back.");
            ToolTip1.SetToolTip(this.button4, "Home");
            ToolTip1.SetToolTip(this.button5, "Refresh.");
            ToolTip1.SetToolTip(this.button6, "Settings");
            ToolTip1.SetToolTip(this.button7, "Bulk Download.");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //forward
            if (this.currentWebsite.Url != this.historyStack.Last().Url)
            {
                this.currentWebsite = NextWebsite(this.currentWebsite);
                Client wb = new Client { Name = "James Bond", Url = this.currentWebsite.Url };
                this.searchBox.Text = currentWebsite.Url;
                this.richTextBox1.Text = wb.AccessWebPage();
                // this.historyStack.Add(this.currentWebsite);
            }
            else
            {
                Console.WriteLine($"last url in history { this.historyStack.Last().Url }");
                Console.WriteLine($"current url : { this.currentWebsite.Url }");
                MessageBox.Show($"No forward history!");
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Download Bulk");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.settingsDrpDown.Visible = !this.settingsDrpDown.Visible;   
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //redirect to current homepage.
            if(DefaultHome != currentWebsite.Url)
            {
                //redirect to  home page
                Client wb = new Client { Name = "James Bond", Url = this.DefaultHome };
                this.searchBox.Text = DefaultHome;
                this.richTextBox1.Text = wb.AccessWebPage();
                this.currentWebsite = new WebsiteDto() { Url = this.DefaultHome, IsFavorite = true, VisitTimestamp = DateTime.Now.ToString() };
                this.historyStack.Add(currentWebsite);
            }
        }

        private void Print_Stack()
        {
            Console.WriteLine("##############################");
            foreach ( WebsiteDto site in historyStack)
            {
                Console.WriteLine(site.Url);
            }
            Console.WriteLine("##############################");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            //refresh
            Client wb = new Client { Name = "James Bond", Url = this.currentWebsite.Url };
            // this.searchBox.Text = currentWebsite.Url;
            this.richTextBox1.Text = wb.AccessWebPage();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //back...
            if(historyStack.Count() > 1 && (this.historyStack.First().Url != this.currentWebsite.Url))
            {
                WebsiteDto website = historyStack.FirstOrDefault(w => w.Url == this.currentWebsite.Url);
                // Back...
                if (website != null)
                {
                    this.currentWebsite = PreviousWebsite(this.currentWebsite);
                    Client wb = new Client { Name = "James Bond", Url = website.Url };
                    this.searchBox.Text = currentWebsite.Url;
                    this.richTextBox1.Text = wb.AccessWebPage();
                    Button5_Click(sender, e);
                    // this.historyStack.Add(this.currentWebsite);
                } 
            } else
            {
                MessageBox.Show($"No previous history found!");
            }
            
        }

        private WebsiteDto PreviousWebsite(WebsiteDto website)
        {
            WebsiteDto[] history = this.historyStack.ToArray();

            for(int i = 0; i < history.Length; i++)
            {
                if(website.Url == history[i].Url)
                {
                    Print_Stack();
                    return history[i - 1];
                }
            }

            return null;
        }

        private WebsiteDto NextWebsite(WebsiteDto website)
        {
            WebsiteDto[] history = this.historyStack.ToArray();

            for (int i = 0; i < history.Length; i++)
            {
                if (website.Url == history[i].Url)
                {
                    return history[i + 1];
                }
            }

            return null;
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

            if(this.settingsDrpDown.Visible)
            {
                this.settingsDrpDown.Hide();
            }
            // Todo: Make suggestions based on history and favorite data.
            Console.WriteLine($"searching for : {this.searchBox.Text }");
            // MessageBox.Show($"Something...");
        }

        private void GetAddress_Html(string url)
        {
            Client wb = new Client { Name = "James Bond", Url = url };

            // get page title
            string html = wb.AccessWebPage();
            this.Text = Helper.Get_Title(html);
            this.richTextBox1.Text = html;
            this.currentWebsite = new WebsiteDto() { Url = url, VisitTimestamp = DateTime.Now.ToString() };
            this.Effect_Favorite_Change();
            this.historyStack.Add(currentWebsite);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //load windows settings.
            this.Screen_Settings();

            // add subscriber.
            homeWindow.HomePageSet += currentHomePageDisplay_TextChanged;
            favoriteManager.MarkedAsFavorite += favoriteWindow.UpdateUiOnFavoriteStackUpdate;

            this.currentHomePageDisplay.Text = DefaultHome;
            Client wb = new Client { Name = "James Bond", Url = DefaultHome };
            this.richTextBox1.Text = wb.AccessWebPage();
            this.searchBox.Text = DefaultHome;

            this.currentWebsite = new WebsiteDto() { Url = DefaultHome, VisitTimestamp = DateTime.Now.ToString() };
            //add home url to history stack.
            this.historyStack.Add(currentWebsite);
            this.Effect_Favorite_Change();
        }

        private void SearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            string url = this.searchBox.Text.Trim();
            if (e.KeyCode == Keys.Enter && url != "")
                GetAddress_Html( url );
        }

        private void RichTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            // needed.
        }

        private void settingsDrpDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentSettingChoice = ((Settings)this.settingsDrpDown.SelectedItem).ID;
            switch (currentSettingChoice)
            {
                case 1:
                    homeWindow.ShowDialog();
                    break;
                case 2:
                    break;
                case 3:
                    this.favoriteWindow.ShowDialog();
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
            //settings dropdown
            //Console.WriteLine( );
        }

        private void currentHomePageDisplay_TextChanged(string url)
        {
            this.DefaultHome = url;
            this.currentHomePageDisplay.Text = url;
        }

        private void chgHomeAddress_Click(object sender, EventArgs e)
        {
            // on hold set home url
            homeWindow.ShowDialog();
        }  

        private void Screen_Settings()
        {
            // initiate windows.
            homeWindow = new Home(ref this.DefaultHome);
            favoriteWindow = new Favorite();
            historyWindow = new History();

            //homeWindow
            homeWindow.Text = "Configure Homepage";
            homeWindow.Icon = Properties.Resources.home_main_ico;
            homeWindow.TopLevel = true;
            homeWindow.StartPosition = FormStartPosition.CenterScreen;
            homeWindow.Owner = this;

            //favoriteWindow
            favoriteWindow.Text = "Favorites";
            favoriteWindow.Icon = Properties.Resources.favorite_added_icon;
            favoriteWindow.TopLevel = true;
            favoriteWindow.StartPosition = FormStartPosition.CenterScreen;
            favoriteWindow.Owner = this;

            //homeWindow
            historyWindow.Text = "History";
            historyWindow.Icon = Properties.Resources.home_main_ico;
            historyWindow.TopLevel = true;
            historyWindow.StartPosition = FormStartPosition.CenterScreen;
            historyWindow.Owner = this;
        }

        private void isFavorite_Click(object sender, EventArgs e)
        {
            // Effect change.
            this.currentWebsite.IsFavorite = !this.currentWebsite.IsFavorite;
            string text = "Please enter a name for your site ?";
            //prompt user for a name 

            //return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";

            this.Effect_Favorite_Change();
        }

        private void Effect_Favorite_Change()
        {
            // Visual Apperance change and Information change.
            Bitmap favorite_minus = Properties.Resources.favorite_minus_two;
            Bitmap favorite_plus = Properties.Resources.favorite_added_icon1;

            switch (this.currentWebsite.IsFavorite)
            {
                case true:
                    this.isFavorite.Image = favorite_plus;
                    favoriteManager.Add(this.currentWebsite);
                    break;

                case false:
                    this.isFavorite.Image = favorite_minus;
                    favoriteManager.Remove(this.currentWebsite);
                    break;
            }
        }

        private void RichTextBox1_TextChanged(object sender, MouseEventArgs e)
        {
            if (this.settingsDrpDown.Visible)
            {
                this.settingsDrpDown.Hide();
            }
        }

        private void historyCta_Click(object sender, EventArgs e)
        {
            historyWindow.ShowDialog();
        }
    }
}
