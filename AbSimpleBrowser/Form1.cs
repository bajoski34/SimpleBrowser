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
            MessageBox.Show($"Go Forward!");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
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
            MessageBox.Show($"Refresh");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Go back!");
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
            wb.AccessWebPage();

            MessageBox.Show($"404...Nothing found");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            string url = this.searchBox.Text.Trim();

            if (e.KeyCode == Keys.Enter && url != "")
                GetAddress_Html( url );
        }

        private void ActivePage_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Main Page");
        }

    }
}
