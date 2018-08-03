namespace WindowsFormsGUIUnderstanding
{
    partial class DateTimePicker
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dropOffLabel = new System.Windows.Forms.Label();
            this.deliveryLabel = new System.Windows.Forms.Label();
            this.deliveryDateTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(34, 39);
            this.dateTimePicker1.MinDate = new System.DateTime(2015, 8, 13, 0, 58, 38, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2015, 8, 13, 0, 58, 38, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dropOffLabel
            // 
            this.dropOffLabel.AutoSize = true;
            this.dropOffLabel.Location = new System.Drawing.Point(31, 14);
            this.dropOffLabel.Name = "dropOffLabel";
            this.dropOffLabel.Size = new System.Drawing.Size(76, 13);
            this.dropOffLabel.TabIndex = 1;
            this.dropOffLabel.Text = "Drop Off Date:";
            // 
            // deliveryLabel
            // 
            this.deliveryLabel.AutoSize = true;
            this.deliveryLabel.Location = new System.Drawing.Point(31, 78);
            this.deliveryLabel.Name = "deliveryLabel";
            this.deliveryLabel.Size = new System.Drawing.Size(123, 13);
            this.deliveryLabel.TabIndex = 2;
            this.deliveryLabel.Text = "Estimated Delivery Date:";
            // 
            // deliveryDateTextBox
            // 
            this.deliveryDateTextBox.Location = new System.Drawing.Point(34, 103);
            this.deliveryDateTextBox.Name = "deliveryDateTextBox";
            this.deliveryDateTextBox.ReadOnly = true;
            this.deliveryDateTextBox.Size = new System.Drawing.Size(200, 20);
            this.deliveryDateTextBox.TabIndex = 3;
            // 
            // DateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 146);
            this.Controls.Add(this.deliveryDateTextBox);
            this.Controls.Add(this.deliveryLabel);
            this.Controls.Add(this.dropOffLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "DateTimePicker";
            this.Text = "DateTimePicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dropOffLabel;
        private System.Windows.Forms.Label deliveryLabel;
        private System.Windows.Forms.TextBox deliveryDateTextBox;
    }
}