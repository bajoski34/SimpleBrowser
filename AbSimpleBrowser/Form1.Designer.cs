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
            this.label2 = new System.Windows.Forms.Label();
            this.requestStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.DetectUrls = false;
            this.searchBox.Location = new System.Drawing.Point(227, 37);
            this.searchBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.searchBox.Multiline = false;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(715, 30);
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
            this.button2.Location = new System.Drawing.Point(75, 37);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 28);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(21, 37);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 28);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(175, 34);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 33);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(124, 37);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(43, 28);
            this.button5.TabIndex = 6;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // isFavorite
            // 
            this.isFavorite.Image = ((System.Drawing.Image)(resources.GetObject("isFavorite.Image")));
            this.isFavorite.Location = new System.Drawing.Point(951, 37);
            this.isFavorite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isFavorite.Name = "isFavorite";
            this.isFavorite.Size = new System.Drawing.Size(49, 31);
            this.isFavorite.TabIndex = 7;
            this.isFavorite.UseVisualStyleBackColor = true;
            this.isFavorite.Click += new System.EventHandler(this.isFavorite_Click);
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(1003, 37);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(49, 31);
            this.button6.TabIndex = 8;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.AccessibleName = "bulk download";
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(1149, 37);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 31);
            this.button7.TabIndex = 9;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(21, 74);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1176, 575);
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
            this.settingsDrpDown.Location = new System.Drawing.Point(897, 76);
            this.settingsDrpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.settingsDrpDown.Name = "settingsDrpDown";
            this.settingsDrpDown.Size = new System.Drawing.Size(153, 184);
            this.settingsDrpDown.TabIndex = 11;
            this.settingsDrpDown.Visible = false;
            this.settingsDrpDown.SelectionChangeCommitted += new System.EventHandler(this.settingsDrpDown_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "current homepage set to:";
            // 
            // currentHomePageDisplay
            // 
            this.currentHomePageDisplay.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.currentHomePageDisplay.CausesValidation = false;
            this.currentHomePageDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.currentHomePageDisplay.Location = new System.Drawing.Point(401, 4);
            this.currentHomePageDisplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.currentHomePageDisplay.Name = "currentHomePageDisplay";
            this.currentHomePageDisplay.ReadOnly = true;
            this.currentHomePageDisplay.Size = new System.Drawing.Size(540, 22);
            this.currentHomePageDisplay.TabIndex = 13;
            // 
            // chgHomeAddress
            // 
            this.chgHomeAddress.Location = new System.Drawing.Point(951, 4);
            this.chgHomeAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chgHomeAddress.Name = "chgHomeAddress";
            this.chgHomeAddress.Size = new System.Drawing.Size(101, 28);
            this.chgHomeAddress.TabIndex = 14;
            this.chgHomeAddress.Text = "change";
            this.chgHomeAddress.UseVisualStyleBackColor = true;
            this.chgHomeAddress.Click += new System.EventHandler(this.chgHomeAddress_Click);
            // 
            // historyCta
            // 
            this.historyCta.Image = global::AbSimpleBrowser.Properties.Resources.history_main_ico;
            this.historyCta.Location = new System.Drawing.Point(1084, 34);
            this.historyCta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.historyCta.Name = "historyCta";
            this.historyCta.Size = new System.Drawing.Size(57, 33);
            this.historyCta.TabIndex = 15;
            this.historyCta.UseVisualStyleBackColor = true;
            this.historyCta.Click += new System.EventHandler(this.historyCta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "status:";
            // 
            // requestStatus
            // 
            this.requestStatus.AutoSize = true;
            this.requestStatus.Location = new System.Drawing.Point(73, 6);
            this.requestStatus.Name = "requestStatus";
            this.requestStatus.Size = new System.Drawing.Size(28, 16);
            this.requestStatus.TabIndex = 17;
            this.requestStatus.Text = "200";
            this.requestStatus.Click += new System.EventHandler(this.requestStatus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 657);
            this.Controls.Add(this.requestStatus);
            this.Controls.Add(this.label2);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abraham\'s Browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label requestStatus;
    }
}

