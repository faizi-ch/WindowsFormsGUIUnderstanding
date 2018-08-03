using System;

namespace WindowsFormsGUIUnderstanding
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.chechBoxesGoupBox = new System.Windows.Forms.GroupBox();
            this.underlineCheckBox = new System.Windows.Forms.CheckBox();
            this.strikeoutCheckBox = new System.Windows.Forms.CheckBox();
            this.fontStyleLabel = new System.Windows.Forms.Label();
            this.italicCheckBox = new System.Windows.Forms.CheckBox();
            this.boldCheckBox = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.msgBxsTypesGroupBox = new System.Windows.Forms.GroupBox();
            this.msgBxTextBox = new System.Windows.Forms.TextBox();
            this.msgBoxDisplayButton = new System.Windows.Forms.Button();
            this.buttonTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.retCanRadioButton = new System.Windows.Forms.RadioButton();
            this.yesNoRadioButton = new System.Windows.Forms.RadioButton();
            this.yesNoCanRadioButton = new System.Windows.Forms.RadioButton();
            this.abRtIgRadioButton = new System.Windows.Forms.RadioButton();
            this.okCanRadioButton = new System.Windows.Forms.RadioButton();
            this.okRadioButton = new System.Windows.Forms.RadioButton();
            this.iconTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.warningRadioButton = new System.Windows.Forms.RadioButton();
            this.stopRadioButton = new System.Windows.Forms.RadioButton();
            this.quesRadioButton = new System.Windows.Forms.RadioButton();
            this.infoRadioButton = new System.Windows.Forms.RadioButton();
            this.handRadioButton = new System.Windows.Forms.RadioButton();
            this.exclamRadioButton = new System.Windows.Forms.RadioButton();
            this.errorRadioButton = new System.Windows.Forms.RadioButton();
            this.asteriskRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.chechBoxesGoupBox.SuspendLayout();
            this.msgBxsTypesGroupBox.SuspendLayout();
            this.buttonTypeGroupBox.SuspendLayout();
            this.iconTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.textBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Simple TextBox";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(15, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password TextBox";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(15, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 94);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buttons";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(88, 62);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 62);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(88, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Location = new System.Drawing.Point(257, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 6;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(168, 52);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 5;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(168, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 4;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(86, 52);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 3;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(4, 52);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 2;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(86, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 1;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // chechBoxesGoupBox
            // 
            this.chechBoxesGoupBox.Controls.Add(this.underlineCheckBox);
            this.chechBoxesGoupBox.Controls.Add(this.strikeoutCheckBox);
            this.chechBoxesGoupBox.Controls.Add(this.fontStyleLabel);
            this.chechBoxesGoupBox.Controls.Add(this.italicCheckBox);
            this.chechBoxesGoupBox.Controls.Add(this.boldCheckBox);
            this.chechBoxesGoupBox.Location = new System.Drawing.Point(13, 191);
            this.chechBoxesGoupBox.Name = "chechBoxesGoupBox";
            this.chechBoxesGoupBox.Size = new System.Drawing.Size(200, 100);
            this.chechBoxesGoupBox.TabIndex = 7;
            this.chechBoxesGoupBox.TabStop = false;
            this.chechBoxesGoupBox.Text = "CheckBoxes";
            // 
            // underlineCheckBox
            // 
            this.underlineCheckBox.AutoSize = true;
            this.underlineCheckBox.Location = new System.Drawing.Point(102, 67);
            this.underlineCheckBox.Name = "underlineCheckBox";
            this.underlineCheckBox.Size = new System.Drawing.Size(71, 17);
            this.underlineCheckBox.TabIndex = 12;
            this.underlineCheckBox.Text = "Underline";
            this.underlineCheckBox.UseVisualStyleBackColor = true;
            this.underlineCheckBox.CheckedChanged += new System.EventHandler(this.underlineCheckBox_CheckedChanged);
            // 
            // strikeoutCheckBox
            // 
            this.strikeoutCheckBox.AutoSize = true;
            this.strikeoutCheckBox.Location = new System.Drawing.Point(19, 67);
            this.strikeoutCheckBox.Name = "strikeoutCheckBox";
            this.strikeoutCheckBox.Size = new System.Drawing.Size(68, 17);
            this.strikeoutCheckBox.TabIndex = 11;
            this.strikeoutCheckBox.Text = "Strikeout";
            this.strikeoutCheckBox.UseVisualStyleBackColor = true;
            this.strikeoutCheckBox.CheckedChanged += new System.EventHandler(this.strikeoutCheckBox_CheckedChanged);
            // 
            // fontStyleLabel
            // 
            this.fontStyleLabel.AutoSize = true;
            this.fontStyleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontStyleLabel.Location = new System.Drawing.Point(16, 16);
            this.fontStyleLabel.Name = "fontStyleLabel";
            this.fontStyleLabel.Size = new System.Drawing.Size(155, 15);
            this.fontStyleLabel.TabIndex = 10;
            this.fontStyleLabel.Text = "Watch the font style change";
            // 
            // italicCheckBox
            // 
            this.italicCheckBox.AutoSize = true;
            this.italicCheckBox.Location = new System.Drawing.Point(102, 44);
            this.italicCheckBox.Name = "italicCheckBox";
            this.italicCheckBox.Size = new System.Drawing.Size(48, 17);
            this.italicCheckBox.TabIndex = 9;
            this.italicCheckBox.Text = "Italic";
            this.italicCheckBox.UseVisualStyleBackColor = true;
            this.italicCheckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // boldCheckBox
            // 
            this.boldCheckBox.AutoSize = true;
            this.boldCheckBox.Location = new System.Drawing.Point(19, 44);
            this.boldCheckBox.Name = "boldCheckBox";
            this.boldCheckBox.Size = new System.Drawing.Size(47, 17);
            this.boldCheckBox.TabIndex = 8;
            this.boldCheckBox.Text = "Bold";
            this.boldCheckBox.UseVisualStyleBackColor = true;
            this.boldCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // msgBxsTypesGroupBox
            // 
            this.msgBxsTypesGroupBox.Controls.Add(this.msgBxTextBox);
            this.msgBxsTypesGroupBox.Controls.Add(this.msgBoxDisplayButton);
            this.msgBxsTypesGroupBox.Controls.Add(this.buttonTypeGroupBox);
            this.msgBxsTypesGroupBox.Controls.Add(this.iconTypeGroupBox);
            this.msgBxsTypesGroupBox.Location = new System.Drawing.Point(237, 114);
            this.msgBxsTypesGroupBox.Name = "msgBxsTypesGroupBox";
            this.msgBxsTypesGroupBox.Size = new System.Drawing.Size(298, 254);
            this.msgBxsTypesGroupBox.TabIndex = 14;
            this.msgBxsTypesGroupBox.TabStop = false;
            this.msgBxsTypesGroupBox.Text = "Message Boxes Types";
            // 
            // msgBxTextBox
            // 
            this.msgBxTextBox.Enabled = false;
            this.msgBxTextBox.Location = new System.Drawing.Point(7, 229);
            this.msgBxTextBox.Name = "msgBxTextBox";
            this.msgBxTextBox.Size = new System.Drawing.Size(286, 20);
            this.msgBxTextBox.TabIndex = 11;
            this.msgBxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // msgBoxDisplayButton
            // 
            this.msgBoxDisplayButton.Location = new System.Drawing.Point(6, 184);
            this.msgBoxDisplayButton.Name = "msgBoxDisplayButton";
            this.msgBoxDisplayButton.Size = new System.Drawing.Size(144, 38);
            this.msgBoxDisplayButton.TabIndex = 10;
            this.msgBoxDisplayButton.Text = "Display";
            this.msgBoxDisplayButton.UseVisualStyleBackColor = true;
            // 
            // buttonTypeGroupBox
            // 
            this.buttonTypeGroupBox.Controls.Add(this.retCanRadioButton);
            this.buttonTypeGroupBox.Controls.Add(this.yesNoRadioButton);
            this.buttonTypeGroupBox.Controls.Add(this.yesNoCanRadioButton);
            this.buttonTypeGroupBox.Controls.Add(this.abRtIgRadioButton);
            this.buttonTypeGroupBox.Controls.Add(this.okCanRadioButton);
            this.buttonTypeGroupBox.Controls.Add(this.okRadioButton);
            this.buttonTypeGroupBox.Location = new System.Drawing.Point(6, 19);
            this.buttonTypeGroupBox.Name = "buttonTypeGroupBox";
            this.buttonTypeGroupBox.Size = new System.Drawing.Size(144, 159);
            this.buttonTypeGroupBox.TabIndex = 8;
            this.buttonTypeGroupBox.TabStop = false;
            this.buttonTypeGroupBox.Text = "Button Type MessageBox";
            // 
            // retCanRadioButton
            // 
            this.retCanRadioButton.AutoSize = true;
            this.retCanRadioButton.Location = new System.Drawing.Point(7, 139);
            this.retCanRadioButton.Name = "retCanRadioButton";
            this.retCanRadioButton.Size = new System.Drawing.Size(86, 17);
            this.retCanRadioButton.TabIndex = 5;
            this.retCanRadioButton.TabStop = true;
            this.retCanRadioButton.Text = "Retry-Cancel";
            this.retCanRadioButton.UseVisualStyleBackColor = true;
            // 
            // yesNoRadioButton
            // 
            this.yesNoRadioButton.AutoSize = true;
            this.yesNoRadioButton.Location = new System.Drawing.Point(7, 115);
            this.yesNoRadioButton.Name = "yesNoRadioButton";
            this.yesNoRadioButton.Size = new System.Drawing.Size(60, 17);
            this.yesNoRadioButton.TabIndex = 4;
            this.yesNoRadioButton.TabStop = true;
            this.yesNoRadioButton.Text = "Yes-No";
            this.yesNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // yesNoCanRadioButton
            // 
            this.yesNoCanRadioButton.AutoSize = true;
            this.yesNoCanRadioButton.Location = new System.Drawing.Point(7, 91);
            this.yesNoCanRadioButton.Name = "yesNoCanRadioButton";
            this.yesNoCanRadioButton.Size = new System.Drawing.Size(96, 17);
            this.yesNoCanRadioButton.TabIndex = 3;
            this.yesNoCanRadioButton.TabStop = true;
            this.yesNoCanRadioButton.Text = "Yes-No-Cancel";
            this.yesNoCanRadioButton.UseVisualStyleBackColor = true;
            // 
            // abRtIgRadioButton
            // 
            this.abRtIgRadioButton.AutoSize = true;
            this.abRtIgRadioButton.Location = new System.Drawing.Point(7, 67);
            this.abRtIgRadioButton.Name = "abRtIgRadioButton";
            this.abRtIgRadioButton.Size = new System.Drawing.Size(111, 17);
            this.abRtIgRadioButton.TabIndex = 2;
            this.abRtIgRadioButton.TabStop = true;
            this.abRtIgRadioButton.Text = "Abort-Retry-Ignore";
            this.abRtIgRadioButton.UseVisualStyleBackColor = true;
            // 
            // okCanRadioButton
            // 
            this.okCanRadioButton.AutoSize = true;
            this.okCanRadioButton.Location = new System.Drawing.Point(7, 44);
            this.okCanRadioButton.Name = "okCanRadioButton";
            this.okCanRadioButton.Size = new System.Drawing.Size(76, 17);
            this.okCanRadioButton.TabIndex = 1;
            this.okCanRadioButton.TabStop = true;
            this.okCanRadioButton.Text = "OK-Cancel";
            this.okCanRadioButton.UseVisualStyleBackColor = true;
            // 
            // okRadioButton
            // 
            this.okRadioButton.AutoSize = true;
            this.okRadioButton.Location = new System.Drawing.Point(7, 20);
            this.okRadioButton.Name = "okRadioButton";
            this.okRadioButton.Size = new System.Drawing.Size(40, 17);
            this.okRadioButton.TabIndex = 0;
            this.okRadioButton.TabStop = true;
            this.okRadioButton.Text = "OK";
            this.okRadioButton.UseVisualStyleBackColor = true;
            // 
            // iconTypeGroupBox
            // 
            this.iconTypeGroupBox.Controls.Add(this.warningRadioButton);
            this.iconTypeGroupBox.Controls.Add(this.stopRadioButton);
            this.iconTypeGroupBox.Controls.Add(this.quesRadioButton);
            this.iconTypeGroupBox.Controls.Add(this.infoRadioButton);
            this.iconTypeGroupBox.Controls.Add(this.handRadioButton);
            this.iconTypeGroupBox.Controls.Add(this.exclamRadioButton);
            this.iconTypeGroupBox.Controls.Add(this.errorRadioButton);
            this.iconTypeGroupBox.Controls.Add(this.asteriskRadioButton);
            this.iconTypeGroupBox.Location = new System.Drawing.Point(156, 19);
            this.iconTypeGroupBox.Name = "iconTypeGroupBox";
            this.iconTypeGroupBox.Size = new System.Drawing.Size(137, 203);
            this.iconTypeGroupBox.TabIndex = 9;
            this.iconTypeGroupBox.TabStop = false;
            this.iconTypeGroupBox.Text = "Icon Type MessageBox";
            // 
            // warningRadioButton
            // 
            this.warningRadioButton.AutoSize = true;
            this.warningRadioButton.Location = new System.Drawing.Point(7, 180);
            this.warningRadioButton.Name = "warningRadioButton";
            this.warningRadioButton.Size = new System.Drawing.Size(65, 17);
            this.warningRadioButton.TabIndex = 7;
            this.warningRadioButton.TabStop = true;
            this.warningRadioButton.Text = "Warning";
            this.warningRadioButton.UseVisualStyleBackColor = true;
            // 
            // stopRadioButton
            // 
            this.stopRadioButton.AutoSize = true;
            this.stopRadioButton.Location = new System.Drawing.Point(6, 158);
            this.stopRadioButton.Name = "stopRadioButton";
            this.stopRadioButton.Size = new System.Drawing.Size(47, 17);
            this.stopRadioButton.TabIndex = 6;
            this.stopRadioButton.TabStop = true;
            this.stopRadioButton.Text = "Stop";
            this.stopRadioButton.UseVisualStyleBackColor = true;
            // 
            // quesRadioButton
            // 
            this.quesRadioButton.AutoSize = true;
            this.quesRadioButton.Location = new System.Drawing.Point(7, 135);
            this.quesRadioButton.Name = "quesRadioButton";
            this.quesRadioButton.Size = new System.Drawing.Size(67, 17);
            this.quesRadioButton.TabIndex = 5;
            this.quesRadioButton.TabStop = true;
            this.quesRadioButton.Text = "Question";
            this.quesRadioButton.UseVisualStyleBackColor = true;
            // 
            // infoRadioButton
            // 
            this.infoRadioButton.AutoSize = true;
            this.infoRadioButton.Location = new System.Drawing.Point(6, 112);
            this.infoRadioButton.Name = "infoRadioButton";
            this.infoRadioButton.Size = new System.Drawing.Size(77, 17);
            this.infoRadioButton.TabIndex = 4;
            this.infoRadioButton.TabStop = true;
            this.infoRadioButton.Text = "Information";
            this.infoRadioButton.UseVisualStyleBackColor = true;
            // 
            // handRadioButton
            // 
            this.handRadioButton.AutoSize = true;
            this.handRadioButton.Location = new System.Drawing.Point(7, 89);
            this.handRadioButton.Name = "handRadioButton";
            this.handRadioButton.Size = new System.Drawing.Size(51, 17);
            this.handRadioButton.TabIndex = 3;
            this.handRadioButton.TabStop = true;
            this.handRadioButton.Text = "Hand";
            this.handRadioButton.UseVisualStyleBackColor = true;
            // 
            // exclamRadioButton
            // 
            this.exclamRadioButton.AutoSize = true;
            this.exclamRadioButton.Location = new System.Drawing.Point(7, 66);
            this.exclamRadioButton.Name = "exclamRadioButton";
            this.exclamRadioButton.Size = new System.Drawing.Size(82, 17);
            this.exclamRadioButton.TabIndex = 2;
            this.exclamRadioButton.TabStop = true;
            this.exclamRadioButton.Text = "Exclamation";
            this.exclamRadioButton.UseVisualStyleBackColor = true;
            // 
            // errorRadioButton
            // 
            this.errorRadioButton.AutoSize = true;
            this.errorRadioButton.Location = new System.Drawing.Point(7, 43);
            this.errorRadioButton.Name = "errorRadioButton";
            this.errorRadioButton.Size = new System.Drawing.Size(47, 17);
            this.errorRadioButton.TabIndex = 1;
            this.errorRadioButton.TabStop = true;
            this.errorRadioButton.Text = "Error";
            this.errorRadioButton.UseVisualStyleBackColor = true;
            // 
            // asteriskRadioButton
            // 
            this.asteriskRadioButton.AutoSize = true;
            this.asteriskRadioButton.Location = new System.Drawing.Point(7, 20);
            this.asteriskRadioButton.Name = "asteriskRadioButton";
            this.asteriskRadioButton.Size = new System.Drawing.Size(62, 17);
            this.asteriskRadioButton.TabIndex = 0;
            this.asteriskRadioButton.TabStop = true;
            this.asteriskRadioButton.Text = "Asterisk";
            this.asteriskRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 693);
            this.Controls.Add(this.msgBxsTypesGroupBox);
            this.Controls.Add(this.chechBoxesGoupBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.chechBoxesGoupBox.ResumeLayout(false);
            this.chechBoxesGoupBox.PerformLayout();
            this.msgBxsTypesGroupBox.ResumeLayout(false);
            this.msgBxsTypesGroupBox.PerformLayout();
            this.buttonTypeGroupBox.ResumeLayout(false);
            this.buttonTypeGroupBox.PerformLayout();
            this.iconTypeGroupBox.ResumeLayout(false);
            this.iconTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox chechBoxesGoupBox;
        private System.Windows.Forms.CheckBox italicCheckBox;
        private System.Windows.Forms.CheckBox boldCheckBox;
        private System.Windows.Forms.Label fontStyleLabel;
        private System.Windows.Forms.CheckBox underlineCheckBox;
        private System.Windows.Forms.CheckBox strikeoutCheckBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox msgBxsTypesGroupBox;
        private System.Windows.Forms.TextBox msgBxTextBox;
        private System.Windows.Forms.Button msgBoxDisplayButton;
        private System.Windows.Forms.GroupBox buttonTypeGroupBox;
        private System.Windows.Forms.RadioButton retCanRadioButton;
        private System.Windows.Forms.RadioButton yesNoRadioButton;
        private System.Windows.Forms.RadioButton yesNoCanRadioButton;
        private System.Windows.Forms.RadioButton abRtIgRadioButton;
        private System.Windows.Forms.RadioButton okCanRadioButton;
        private System.Windows.Forms.RadioButton okRadioButton;
        private System.Windows.Forms.GroupBox iconTypeGroupBox;
        private System.Windows.Forms.RadioButton warningRadioButton;
        private System.Windows.Forms.RadioButton stopRadioButton;
        private System.Windows.Forms.RadioButton quesRadioButton;
        private System.Windows.Forms.RadioButton infoRadioButton;
        private System.Windows.Forms.RadioButton handRadioButton;
        private System.Windows.Forms.RadioButton exclamRadioButton;
        private System.Windows.Forms.RadioButton errorRadioButton;
        private System.Windows.Forms.RadioButton asteriskRadioButton;
    }
}

