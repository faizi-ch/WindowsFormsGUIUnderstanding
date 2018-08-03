namespace WindowsFormsGUIUnderstanding
{
    partial class MouseHandling
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
            this.buttonLabel = new System.Windows.Forms.Label();
            this.clicksLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLabel
            // 
            this.buttonLabel.AutoSize = true;
            this.buttonLabel.Location = new System.Drawing.Point(12, 239);
            this.buttonLabel.Name = "buttonLabel";
            this.buttonLabel.Size = new System.Drawing.Size(0, 13);
            this.buttonLabel.TabIndex = 0;
            // 
            // clicksLabel
            // 
            this.clicksLabel.AutoSize = true;
            this.clicksLabel.Location = new System.Drawing.Point(212, 236);
            this.clicksLabel.Name = "clicksLabel";
            this.clicksLabel.Size = new System.Drawing.Size(0, 13);
            this.clicksLabel.TabIndex = 1;
            // 
            // MouseHandling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.clicksLabel);
            this.Controls.Add(this.buttonLabel);
            this.Name = "MouseHandling";
            this.Text = "MouseHandling";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseHandling_MouseDown);
            this.MouseEnter += new System.EventHandler(this.MouseHandling_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MouseHandling_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label buttonLabel;
        private System.Windows.Forms.Label clicksLabel;
    }
}