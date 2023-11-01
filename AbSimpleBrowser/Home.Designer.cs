
namespace AbSimpleBrowser
{
    partial class Home
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
            this.setHomeBtn = new System.Windows.Forms.Button();
            this.homeUrl = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // setHomeBtn
            // 
            this.setHomeBtn.Location = new System.Drawing.Point(583, 42);
            this.setHomeBtn.Name = "setHomeBtn";
            this.setHomeBtn.Size = new System.Drawing.Size(105, 23);
            this.setHomeBtn.TabIndex = 1;
            this.setHomeBtn.Text = "set as home ";
            this.setHomeBtn.UseVisualStyleBackColor = true;
            this.setHomeBtn.Click += new System.EventHandler(this.setHomeBtn_Click);
            // 
            // homeUrl
            // 
            this.homeUrl.FormattingEnabled = true;
            this.homeUrl.Location = new System.Drawing.Point(86, 44);
            this.homeUrl.Name = "homeUrl";
            this.homeUrl.Size = new System.Drawing.Size(491, 21);
            this.homeUrl.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.homeUrl);
            this.Controls.Add(this.setHomeBtn);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button setHomeBtn;
        private System.Windows.Forms.ComboBox homeUrl;
    }
}