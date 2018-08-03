namespace WindowsFormsGUIUnderstanding
{
    partial class ListView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListView));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.browserListView = new System.Windows.Forms.ListView();
            this.displayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1439649684_Windows_8_Folder.png");
            this.imageList1.Images.SetKeyName(1, "settings_file.png");
            // 
            // browserListView
            // 
            this.browserListView.Location = new System.Drawing.Point(13, 29);
            this.browserListView.Name = "browserListView";
            this.browserListView.Size = new System.Drawing.Size(259, 220);
            this.browserListView.SmallImageList = this.imageList1;
            this.browserListView.TabIndex = 0;
            this.browserListView.UseCompatibleStateImageBehavior = false;
            this.browserListView.Click += new System.EventHandler(this.listView1_Click);
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Location = new System.Drawing.Point(13, 13);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(65, 13);
            this.displayLabel.TabIndex = 1;
            this.displayLabel.Text = "displayLabel";
            // 
            // ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.browserListView);
            this.Name = "ListView";
            this.Text = "ListView";
            this.Load += new System.EventHandler(this.ListView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView browserListView;
        private System.Windows.Forms.Label displayLabel;
    }
}