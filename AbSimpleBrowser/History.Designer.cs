
namespace AbSimpleBrowser
{
    partial class History
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
            this.clearAllCta = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(30, 68);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(741, 339);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // clearAllCta
            // 
            this.clearAllCta.Location = new System.Drawing.Point(695, 31);
            this.clearAllCta.Name = "clearAllCta";
            this.clearAllCta.Size = new System.Drawing.Size(75, 23);
            this.clearAllCta.TabIndex = 1;
            this.clearAllCta.Text = "Clear all";
            this.clearAllCta.UseVisualStyleBackColor = true;
            // 
            // nextBtn
            // 
            this.nextBtn.Enabled = false;
            this.nextBtn.Location = new System.Drawing.Point(694, 415);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 2;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.clearAllCta);
            this.Controls.Add(this.listView1);
            this.Name = "History";
            this.Text = "History";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button clearAllCta;
        private System.Windows.Forms.Button nextBtn;
    }
}