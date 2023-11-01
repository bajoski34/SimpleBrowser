
namespace AbSimpleBrowser
{
    partial class Favorite
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.removeSite = new System.Windows.Forms.Button();
            this.addSite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ListId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListDateAdded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ListId,
            this.ListUrl,
            this.ListDateAdded});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 91);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 347);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // removeSite
            // 
            this.removeSite.Location = new System.Drawing.Point(704, 62);
            this.removeSite.Name = "removeSite";
            this.removeSite.Size = new System.Drawing.Size(75, 23);
            this.removeSite.TabIndex = 1;
            this.removeSite.Text = "Remove";
            this.removeSite.UseVisualStyleBackColor = true;
            // 
            // addSite
            // 
            this.addSite.Location = new System.Drawing.Point(623, 62);
            this.addSite.Name = "addSite";
            this.addSite.Size = new System.Drawing.Size(75, 23);
            this.addSite.TabIndex = 2;
            this.addSite.Text = "Add";
            this.addSite.UseVisualStyleBackColor = true;
            this.addSite.Click += new System.EventHandler(this.addSite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add or remove sites from you favorite list";
            // 
            // ListId
            // 
            this.ListId.Text = "ID";
            // 
            // ListUrl
            // 
            this.ListUrl.Text = "Url";
            this.ListUrl.Width = 255;
            // 
            // ListDateAdded
            // 
            this.ListDateAdded.Text = "Date Added";
            this.ListDateAdded.Width = 80;
            // 
            // Favorite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addSite);
            this.Controls.Add(this.removeSite);
            this.Controls.Add(this.listView1);
            this.Name = "Favorite";
            this.Text = "Favorite";
            this.Load += new System.EventHandler(this.Favorite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ListId;
        private System.Windows.Forms.ColumnHeader ListUrl;
        private System.Windows.Forms.ColumnHeader ListDateAdded;
        private System.Windows.Forms.Button removeSite;
        private System.Windows.Forms.Button addSite;
        private System.Windows.Forms.Label label1;
    }
}