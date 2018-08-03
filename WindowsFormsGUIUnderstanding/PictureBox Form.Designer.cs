using System;

namespace WindowsFormsGUIUnderstanding
{
    partial class PictureBox_Form
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
            this.picBoxGroupBox = new System.Windows.Forms.GroupBox();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBoxGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxGroupBox
            // 
            this.picBoxGroupBox.Controls.Add(this.pictureBox1);
            this.picBoxGroupBox.Location = new System.Drawing.Point(12, 12);
            this.picBoxGroupBox.Name = "picBoxGroupBox";
            this.picBoxGroupBox.Size = new System.Drawing.Size(637, 333);
            this.picBoxGroupBox.TabIndex = 14;
            this.picBoxGroupBox.TabStop = false;
            this.picBoxGroupBox.Text = "Picture Box";
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(249, 351);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 23);
            this.previousButton.TabIndex = 2;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            previousButton.Click+=new EventHandler(previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(348, 351);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            nextButton.Click+=new EventHandler(nextButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsGUIUnderstanding.Properties.Resources.image1;
            this.pictureBox1.Location = new System.Drawing.Point(7, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(616, 303);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PictureBox_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 386);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.picBoxGroupBox);
            this.Controls.Add(this.nextButton);
            this.Name = "PictureBox_Form";
            this.Text = "PictureBox_Form";
            this.picBoxGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox picBoxGroupBox;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}