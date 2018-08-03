namespace WindowsFormsGUIUnderstanding
{
    partial class KeysHandling
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
            this.keyCharLabel = new System.Windows.Forms.Label();
            this.altLabel = new System.Windows.Forms.Label();
            this.ctrlLabel = new System.Windows.Forms.Label();
            this.shiftLabel = new System.Windows.Forms.Label();
            this.keyCodeLabel = new System.Windows.Forms.Label();
            this.keyDataLabel = new System.Windows.Forms.Label();
            this.keyValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // keyCharLabel
            // 
            this.keyCharLabel.AutoSize = true;
            this.keyCharLabel.Location = new System.Drawing.Point(28, 24);
            this.keyCharLabel.Name = "keyCharLabel";
            this.keyCharLabel.Size = new System.Drawing.Size(72, 13);
            this.keyCharLabel.TabIndex = 0;
            this.keyCharLabel.Text = "Key Pressed: ";
            // 
            // altLabel
            // 
            this.altLabel.AutoSize = true;
            this.altLabel.Location = new System.Drawing.Point(28, 64);
            this.altLabel.Name = "altLabel";
            this.altLabel.Size = new System.Drawing.Size(25, 13);
            this.altLabel.TabIndex = 1;
            this.altLabel.Text = "Alt: ";
            // 
            // ctrlLabel
            // 
            this.ctrlLabel.AutoSize = true;
            this.ctrlLabel.Location = new System.Drawing.Point(28, 87);
            this.ctrlLabel.Name = "ctrlLabel";
            this.ctrlLabel.Size = new System.Drawing.Size(25, 13);
            this.ctrlLabel.TabIndex = 2;
            this.ctrlLabel.Text = "Ctrl:";
            // 
            // shiftLabel
            // 
            this.shiftLabel.AutoSize = true;
            this.shiftLabel.Location = new System.Drawing.Point(28, 110);
            this.shiftLabel.Name = "shiftLabel";
            this.shiftLabel.Size = new System.Drawing.Size(28, 13);
            this.shiftLabel.TabIndex = 3;
            this.shiftLabel.Text = "Shift";
            // 
            // keyCodeLabel
            // 
            this.keyCodeLabel.AutoSize = true;
            this.keyCodeLabel.Location = new System.Drawing.Point(28, 133);
            this.keyCodeLabel.Name = "keyCodeLabel";
            this.keyCodeLabel.Size = new System.Drawing.Size(53, 13);
            this.keyCodeLabel.TabIndex = 4;
            this.keyCodeLabel.Text = "KeyCode:";
            // 
            // keyDataLabel
            // 
            this.keyDataLabel.AutoSize = true;
            this.keyDataLabel.Location = new System.Drawing.Point(28, 156);
            this.keyDataLabel.Name = "keyDataLabel";
            this.keyDataLabel.Size = new System.Drawing.Size(51, 13);
            this.keyDataLabel.TabIndex = 5;
            this.keyDataLabel.Text = "KeyData:";
            // 
            // keyValueLabel
            // 
            this.keyValueLabel.AutoSize = true;
            this.keyValueLabel.Location = new System.Drawing.Point(28, 179);
            this.keyValueLabel.Name = "keyValueLabel";
            this.keyValueLabel.Size = new System.Drawing.Size(55, 13);
            this.keyValueLabel.TabIndex = 6;
            this.keyValueLabel.Text = "KeyValue:";
            // 
            // KeysHandling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.keyValueLabel);
            this.Controls.Add(this.keyDataLabel);
            this.Controls.Add(this.keyCodeLabel);
            this.Controls.Add(this.shiftLabel);
            this.Controls.Add(this.ctrlLabel);
            this.Controls.Add(this.altLabel);
            this.Controls.Add(this.keyCharLabel);
            this.Name = "KeysHandling";
            this.Text = "KeysHandling";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeysHandling_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeysHandling_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label keyCharLabel;
        private System.Windows.Forms.Label altLabel;
        private System.Windows.Forms.Label ctrlLabel;
        private System.Windows.Forms.Label shiftLabel;
        private System.Windows.Forms.Label keyCodeLabel;
        private System.Windows.Forms.Label keyDataLabel;
        private System.Windows.Forms.Label keyValueLabel;
    }
}