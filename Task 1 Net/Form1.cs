namespace Task_1_Net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hour = timePickerControl1.SelectedHour;
            int minute = timePickerControl1.SelectedMinute;
            MessageBox.Show($"Обраний час: {hour:D2}:{minute:D2}");
        }
    }
}
