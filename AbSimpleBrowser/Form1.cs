﻿using System;
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
        public Form1()
        {
            InitializeComponent();
            SetToolTipsToActions();
        }

        private void SetToolTipsToActions()
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.button1, "Favorites");
            ToolTip1.SetToolTip(this.button2, "Click to go foward.");
            ToolTip1.SetToolTip(this.button3, "Click to go back.");
            ToolTip1.SetToolTip(this.button4, "Home");
            ToolTip1.SetToolTip(this.button5, "Refresh.");
            ToolTip1.SetToolTip(this.button6, "Settings");
            ToolTip1.SetToolTip(this.button7, "Bulk Download.");
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //forward
            if (historyStack.Count() > 1 && (this.historyStack.Last().Url != this.currentWebsite.Url))
            {
                WebsiteDto website = historyStack.FirstOrDefault(w => w.Url == this.currentWebsite.Url);
                // Back...
                if (website != null)
                {
                    this.currentWebsite = NextWebsite(this.currentWebsite);
                    WebBrowser wb = new WebBrowser { Name = "James Bond", Url = this.currentWebsite.Url };
                    this.searchBox.Text = currentWebsite.Url;
                    this.richTextBox1.Text = wb.AccessWebPage();
                    this.historyStack.Add(this.currentWebsite);
                }
            }
            else
            {
                MessageBox.Show($"No forward history!");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //favorite 

            //On click, using the current id of the Website check the isFavorite option as true
            MessageBox.Show($"Favorties");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Download Bulk");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Settings");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Home");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            //refresh
            WebBrowser wb = new WebBrowser { Name = "James Bond", Url = this.currentWebsite.Url };
            this.searchBox.Text = currentWebsite.Url;
            this.richTextBox1.Text = wb.AccessWebPage();
            this.historyStack.Add(this.currentWebsite);
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
                    WebBrowser wb = new WebBrowser { Name = "James Bond", Url = website.Url };
                    this.searchBox.Text = currentWebsite.Url;
                    this.richTextBox1.Text = wb.AccessWebPage();
                    this.historyStack.Add(this.currentWebsite);
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
            // Todo: Make suggestions based on history and favorite data.
            Console.WriteLine($"searching for : {this.searchBox.Text }");
            // MessageBox.Show($"Something...");
        }

        private void GetAddress_Html(string url)
        {
            WebBrowser wb = new WebBrowser { Name = "James Bond", Url = url };
            this.richTextBox1.Text = wb.AccessWebPage();
            this.currentWebsite = new WebsiteDto() { Url = url, VisitTimestamp = DateTime.Now.ToString() };
            this.historyStack.Add(currentWebsite);
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            //On load render the hw.ac.uk website.
            WebBrowser wb = new WebBrowser { Name = "James Bond", Url = DefaultHome };
            this.richTextBox1.Text = wb.AccessWebPage();
            this.searchBox.Text = DefaultHome;

            this.currentWebsite = new WebsiteDto() { Url = DefaultHome, VisitTimestamp = DateTime.Now.ToString() };
            //add home url to history stack.
            this.historyStack.Add(currentWebsite);
        }

        private void SearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            string url = this.searchBox.Text.Trim();
            if (e.KeyCode == Keys.Enter && url != "")
                GetAddress_Html( url );
        }

        private void MarkAsFavorite()
        {
            WebsiteDto website = historyStack.FirstOrDefault(w => w.Url == this.currentWebsite.Url);

            //historyStack.Count();

            if(website != null)
            {
                this.currentWebsite.IsFavorite = true;
                website.IsFavorite = true;
                //update the ui to show this is a favorite website.
                
            }
        }



        private void RichTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            // needed.
        }
    }
}
