namespace WindowsFormsGUIUnderstanding
{
    partial class TabControl
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
            this.Color = new System.Windows.Forms.TabControl();
            this.colorTab = new System.Windows.Forms.TabPage();
            this.redRadioButton = new System.Windows.Forms.RadioButton();
            this.greenRadioButton = new System.Windows.Forms.RadioButton();
            this.blueRadioButton = new System.Windows.Forms.RadioButton();
            this.blackRadioButton = new System.Windows.Forms.RadioButton();
            this.sizeTab = new System.Windows.Forms.TabPage();
            this.size20RadioButton = new System.Windows.Forms.RadioButton();
            this.size16RadioButton = new System.Windows.Forms.RadioButton();
            this.size12RadioButton = new System.Windows.Forms.RadioButton();
            this.messageTab = new System.Windows.Forms.TabPage();
            this.showTextButton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.aboutTab = new System.Windows.Forms.TabPage();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.displayLabel = new System.Windows.Forms.Label();
            this.Color.SuspendLayout();
            this.colorTab.SuspendLayout();
            this.sizeTab.SuspendLayout();
            this.messageTab.SuspendLayout();
            this.aboutTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Color
            // 
            this.Color.Controls.Add(this.colorTab);
            this.Color.Controls.Add(this.sizeTab);
            this.Color.Controls.Add(this.messageTab);
            this.Color.Controls.Add(this.aboutTab);
            this.Color.Location = new System.Drawing.Point(0, 0);
            this.Color.Name = "Color";
            this.Color.SelectedIndex = 0;
            this.Color.Size = new System.Drawing.Size(399, 210);
            this.Color.TabIndex = 0;
            // 
            // colorTab
            // 
            this.colorTab.Controls.Add(this.redRadioButton);
            this.colorTab.Controls.Add(this.greenRadioButton);
            this.colorTab.Controls.Add(this.blueRadioButton);
            this.colorTab.Controls.Add(this.blackRadioButton);
            this.colorTab.Location = new System.Drawing.Point(4, 22);
            this.colorTab.Name = "colorTab";
            this.colorTab.Padding = new System.Windows.Forms.Padding(3);
            this.colorTab.Size = new System.Drawing.Size(391, 184);
            this.colorTab.TabIndex = 0;
            this.colorTab.Text = "Color";
            this.colorTab.UseVisualStyleBackColor = true;
            // 
            // redRadioButton
            // 
            this.redRadioButton.AutoSize = true;
            this.redRadioButton.Location = new System.Drawing.Point(35, 97);
            this.redRadioButton.Name = "redRadioButton";
            this.redRadioButton.Size = new System.Drawing.Size(45, 17);
            this.redRadioButton.TabIndex = 3;
            this.redRadioButton.Text = "Red";
            this.redRadioButton.UseVisualStyleBackColor = true;
            this.redRadioButton.CheckedChanged += new System.EventHandler(this.redRadioButton_CheckedChanged);
            // 
            // greenRadioButton
            // 
            this.greenRadioButton.AutoSize = true;
            this.greenRadioButton.Location = new System.Drawing.Point(35, 74);
            this.greenRadioButton.Name = "greenRadioButton";
            this.greenRadioButton.Size = new System.Drawing.Size(54, 17);
            this.greenRadioButton.TabIndex = 2;
            this.greenRadioButton.Text = "Green";
            this.greenRadioButton.UseVisualStyleBackColor = true;
            this.greenRadioButton.CheckedChanged += new System.EventHandler(this.greenRadioButton_CheckedChanged);
            // 
            // blueRadioButton
            // 
            this.blueRadioButton.AutoSize = true;
            this.blueRadioButton.Location = new System.Drawing.Point(35, 51);
            this.blueRadioButton.Name = "blueRadioButton";
            this.blueRadioButton.Size = new System.Drawing.Size(46, 17);
            this.blueRadioButton.TabIndex = 1;
            this.blueRadioButton.Text = "Blue";
            this.blueRadioButton.UseVisualStyleBackColor = true;
            this.blueRadioButton.CheckedChanged += new System.EventHandler(this.blueRadioButton_CheckedChanged);
            // 
            // blackRadioButton
            // 
            this.blackRadioButton.AutoSize = true;
            this.blackRadioButton.Checked = true;
            this.blackRadioButton.Location = new System.Drawing.Point(35, 28);
            this.blackRadioButton.Name = "blackRadioButton";
            this.blackRadioButton.Size = new System.Drawing.Size(52, 17);
            this.blackRadioButton.TabIndex = 0;
            this.blackRadioButton.TabStop = true;
            this.blackRadioButton.Text = "Black";
            this.blackRadioButton.UseVisualStyleBackColor = true;
            this.blackRadioButton.CheckedChanged += new System.EventHandler(this.blackRadioButton_CheckedChanged);
            // 
            // sizeTab
            // 
            this.sizeTab.Controls.Add(this.size20RadioButton);
            this.sizeTab.Controls.Add(this.size16RadioButton);
            this.sizeTab.Controls.Add(this.size12RadioButton);
            this.sizeTab.Location = new System.Drawing.Point(4, 22);
            this.sizeTab.Name = "sizeTab";
            this.sizeTab.Padding = new System.Windows.Forms.Padding(3);
            this.sizeTab.Size = new System.Drawing.Size(391, 184);
            this.sizeTab.TabIndex = 1;
            this.sizeTab.Text = "Size";
            this.sizeTab.UseVisualStyleBackColor = true;
            // 
            // size20RadioButton
            // 
            this.size20RadioButton.AutoSize = true;
            this.size20RadioButton.Location = new System.Drawing.Point(31, 88);
            this.size20RadioButton.Name = "size20RadioButton";
            this.size20RadioButton.Size = new System.Drawing.Size(69, 17);
            this.size20RadioButton.TabIndex = 2;
            this.size20RadioButton.TabStop = true;
            this.size20RadioButton.Text = "20 Points";
            this.size20RadioButton.UseVisualStyleBackColor = true;
            this.size20RadioButton.CheckedChanged += new System.EventHandler(this.size20RadioButton_CheckedChanged);
            // 
            // size16RadioButton
            // 
            this.size16RadioButton.AutoSize = true;
            this.size16RadioButton.Location = new System.Drawing.Point(31, 57);
            this.size16RadioButton.Name = "size16RadioButton";
            this.size16RadioButton.Size = new System.Drawing.Size(69, 17);
            this.size16RadioButton.TabIndex = 1;
            this.size16RadioButton.TabStop = true;
            this.size16RadioButton.Text = "16 Points";
            this.size16RadioButton.UseVisualStyleBackColor = true;
            this.size16RadioButton.CheckedChanged += new System.EventHandler(this.size16RadioButton_CheckedChanged);
            // 
            // size12RadioButton
            // 
            this.size12RadioButton.AutoSize = true;
            this.size12RadioButton.Checked = true;
            this.size12RadioButton.Location = new System.Drawing.Point(31, 26);
            this.size12RadioButton.Name = "size12RadioButton";
            this.size12RadioButton.Size = new System.Drawing.Size(69, 17);
            this.size12RadioButton.TabIndex = 0;
            this.size12RadioButton.TabStop = true;
            this.size12RadioButton.Text = "12 Points";
            this.size12RadioButton.UseVisualStyleBackColor = true;
            this.size12RadioButton.CheckedChanged += new System.EventHandler(this.size12RadioButton_CheckedChanged);
            // 
            // messageTab
            // 
            this.messageTab.Controls.Add(this.showTextButton);
            this.messageTab.Controls.Add(this.messageTextBox);
            this.messageTab.Controls.Add(this.messageLabel);
            this.messageTab.Location = new System.Drawing.Point(4, 22);
            this.messageTab.Name = "messageTab";
            this.messageTab.Size = new System.Drawing.Size(391, 184);
            this.messageTab.TabIndex = 2;
            this.messageTab.Text = "Message";
            this.messageTab.UseVisualStyleBackColor = true;
            // 
            // showTextButton
            // 
            this.showTextButton.Location = new System.Drawing.Point(166, 75);
            this.showTextButton.Name = "showTextButton";
            this.showTextButton.Size = new System.Drawing.Size(75, 23);
            this.showTextButton.TabIndex = 2;
            this.showTextButton.Text = "Show Text";
            this.showTextButton.UseVisualStyleBackColor = true;
            this.showTextButton.Click += new System.EventHandler(this.showTextButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(23, 37);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(218, 20);
            this.messageTextBox.TabIndex = 1;
            this.messageTextBox.TextChanged += new System.EventHandler(this.messageTextBox_TextChanged);
            this.messageTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messageTextBox_KeyDown);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(20, 21);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(102, 13);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "Type your message:";
            // 
            // aboutTab
            // 
            this.aboutTab.Controls.Add(this.aboutLabel);
            this.aboutTab.Location = new System.Drawing.Point(4, 22);
            this.aboutTab.Name = "aboutTab";
            this.aboutTab.Size = new System.Drawing.Size(391, 184);
            this.aboutTab.TabIndex = 3;
            this.aboutTab.Text = "About";
            this.aboutTab.UseVisualStyleBackColor = true;
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLabel.Location = new System.Drawing.Point(8, 9);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(288, 80);
            this.aboutLabel.TabIndex = 0;
            this.aboutLabel.Text = "Tabs are used to organize controls and \r\nconserve screen space.\r\n\r\nMade by Faizi." +
    "";
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(36, 213);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(122, 20);
            this.displayLabel.TabIndex = 1;
            this.displayLabel.Text = "Write your text...";
            // 
            // TabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 239);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.Color);
            this.Name = "TabControl";
            this.Text = "TabControl";
            this.Color.ResumeLayout(false);
            this.colorTab.ResumeLayout(false);
            this.colorTab.PerformLayout();
            this.sizeTab.ResumeLayout(false);
            this.sizeTab.PerformLayout();
            this.messageTab.ResumeLayout(false);
            this.messageTab.PerformLayout();
            this.aboutTab.ResumeLayout(false);
            this.aboutTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Color;
        private System.Windows.Forms.TabPage colorTab;
        private System.Windows.Forms.TabPage sizeTab;
        private System.Windows.Forms.RadioButton redRadioButton;
        private System.Windows.Forms.RadioButton greenRadioButton;
        private System.Windows.Forms.RadioButton blueRadioButton;
        private System.Windows.Forms.RadioButton blackRadioButton;
        private System.Windows.Forms.RadioButton size20RadioButton;
        private System.Windows.Forms.RadioButton size16RadioButton;
        private System.Windows.Forms.RadioButton size12RadioButton;
        private System.Windows.Forms.TabPage messageTab;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TabPage aboutTab;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Button showTextButton;
    }
}