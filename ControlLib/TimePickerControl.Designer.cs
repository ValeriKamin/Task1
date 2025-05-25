namespace ControlLib
{
    partial class TimePickerControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxHour = new ComboBox();
            comboBoxMinute = new ComboBox();
            SuspendLayout();
            // 
            // comboBoxHour
            // 
            comboBoxHour.FormattingEnabled = true;
            comboBoxHour.Location = new Point(33, 21);
            comboBoxHour.Name = "comboBoxHour";
            comboBoxHour.Size = new Size(121, 23);
            comboBoxHour.TabIndex = 0;
            // 
            // comboBoxMinute
            // 
            comboBoxMinute.FormattingEnabled = true;
            comboBoxMinute.Location = new Point(187, 21);
            comboBoxMinute.Name = "comboBoxMinute";
            comboBoxMinute.Size = new Size(121, 23);
            comboBoxMinute.TabIndex = 1;
            // 
            // TimePickerControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBoxMinute);
            Controls.Add(comboBoxHour);
            Name = "TimePickerControl";
            Size = new Size(413, 64);
            Load += TimePickerControl_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxHour;
        private ComboBox comboBoxMinute;
    }
}
