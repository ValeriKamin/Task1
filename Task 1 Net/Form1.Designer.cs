﻿namespace Task_1_Net
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timePickerControl1 = new ControlLib.TimePickerControl();
            button1 = new Button();
            SuspendLayout();
            // 
            // timePickerControl1
            // 
            timePickerControl1.Location = new Point(12, 12);
            timePickerControl1.Name = "timePickerControl1";
            timePickerControl1.SelectedHour = 0;
            timePickerControl1.SelectedMinute = 0;
            timePickerControl1.Size = new Size(344, 69);
            timePickerControl1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(131, 115);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(timePickerControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ControlLib.TimePickerControl timePickerControl1;
        private Button button1;
    }
}
