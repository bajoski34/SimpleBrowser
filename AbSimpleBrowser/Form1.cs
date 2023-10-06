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
            ToolTip1.SetToolTip(this.button7, "Bulk Download.");
            ToolTip1.SetToolTip(this.button1, "Favorites");
            ToolTip1.SetToolTip(this.button2, "Click to go foward.");
            ToolTip1.SetToolTip(this.button6, "Settings");
            ToolTip1.SetToolTip(this.button4, "Home");
            ToolTip1.SetToolTip(this.button3, "Click to go back.");
            ToolTip1.SetToolTip(this.button5, "Refresh.");
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine($"searching for : {this.searchBox.Text }");
            // MessageBox.Show($"Something...");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
