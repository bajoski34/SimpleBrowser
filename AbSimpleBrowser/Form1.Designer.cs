namespace AbSimpleBrowser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.searchBox = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.isFavorite = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.settingsDrpDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.currentHomePageDisplay = new System.Windows.Forms.TextBox();
            this.chgHomeAddress = new System.Windows.Forms.Button();
            this.historyCta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.DetectUrls = false;
            this.searchBox.Location = new System.Drawing.Point(170, 30);
            this.searchBox.Margin = new System.Windows.Forms.Padding(5);
            this.searchBox.Multiline = false;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(537, 25);
            this.searchBox.TabIndex = 1;
            this.searchBox.Text = "";
            this.searchBox.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            this.searchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyUp);
            this.searchBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RichTextBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(56, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 23);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(16, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 23);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(131, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 27);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(93, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(32, 23);
            this.button5.TabIndex = 6;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // isFavorite
            // 
            this.isFavorite.Image = ((System.Drawing.Image)(resources.GetObject("isFavorite.Image")));
            this.isFavorite.Location = new System.Drawing.Point(713, 30);
            this.isFavorite.Name = "isFavorite";
            this.isFavorite.Size = new System.Drawing.Size(37, 25);
            this.isFavorite.TabIndex = 7;
            this.isFavorite.UseVisualStyleBackColor = true;
            this.isFavorite.Click += new System.EventHandler(this.isFavorite_Click);
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(752, 30);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 25);
            this.button6.TabIndex = 8;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.AccessibleName = "bulk download";
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(862, 30);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(37, 25);
            this.button7.TabIndex = 9;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(883, 468);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged_1);
            // 
            // settingsDrpDown
            // 
            this.settingsDrpDown.DisplayMember = "set home url";
            this.settingsDrpDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.settingsDrpDown.FormattingEnabled = true;
            this.settingsDrpDown.Items.AddRange(new object[] {
            "set home address",
            "change theme",
            "see history",
            "see downloads",
            "see favorites"});
            this.settingsDrpDown.Location = new System.Drawing.Point(673, 62);
            this.settingsDrpDown.Name = "settingsDrpDown";
            this.settingsDrpDown.Size = new System.Drawing.Size(116, 150);
            this.settingsDrpDown.TabIndex = 11;
            this.settingsDrpDown.Visible = false;
            this.settingsDrpDown.SelectionChangeCommitted += new System.EventHandler(this.settingsDrpDown_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "current homepage set to:";
            // 
            // currentHomePageDisplay
            // 
            this.currentHomePageDisplay.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.currentHomePageDisplay.CausesValidation = false;
            this.currentHomePageDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.currentHomePageDisplay.Location = new System.Drawing.Point(301, 3);
            this.currentHomePageDisplay.Name = "currentHomePageDisplay";
            this.currentHomePageDisplay.ReadOnly = true;
            this.currentHomePageDisplay.Size = new System.Drawing.Size(406, 20);
            this.currentHomePageDisplay.TabIndex = 13;
            // 
            // chgHomeAddress
            // 
            this.chgHomeAddress.Location = new System.Drawing.Point(713, 3);
            this.chgHomeAddress.Name = "chgHomeAddress";
            this.chgHomeAddress.Size = new System.Drawing.Size(76, 23);
            this.chgHomeAddress.TabIndex = 14;
            this.chgHomeAddress.Text = "change";
            this.chgHomeAddress.UseVisualStyleBackColor = true;
            this.chgHomeAddress.Click += new System.EventHandler(this.chgHomeAddress_Click);
            // 
            // historyCta
            // 
            this.historyCta.Image = global::AbSimpleBrowser.Properties.Resources.history_main_ico;
            this.historyCta.Location = new System.Drawing.Point(813, 28);
            this.historyCta.Name = "historyCta";
            this.historyCta.Size = new System.Drawing.Size(43, 27);
            this.historyCta.TabIndex = 15;
            this.historyCta.UseVisualStyleBackColor = true;
            this.historyCta.Click += new System.EventHandler(this.historyCta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 534);
            this.Controls.Add(this.historyCta);
            this.Controls.Add(this.chgHomeAddress);
            this.Controls.Add(this.currentHomePageDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.settingsDrpDown);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.isFavorite);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abraham\'s Browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox searchBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button isFavorite;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox settingsDrpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox currentHomePageDisplay;
        private System.Windows.Forms.Button chgHomeAddress;
        private System.Windows.Forms.Button historyCta;
    }
}

