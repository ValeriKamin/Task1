using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ControlLib
{
    [ToolboxBitmap(typeof(TimePickerControl), "TimePickerControl.ico")]
    public partial class TimePickerControl : UserControl
    {
        public TimePickerControl()
        {
            InitializeComponent();
            InitTimePickers();
        }

        private void InitTimePickers()
        {
            for (int i = 0; i < 24; i++)
                comboBoxHour.Items.Add(i);

            for (int i = 0; i < 60; i++)
                comboBoxMinute.Items.Add(i);

            comboBoxHour.SelectedIndex = 0;
            comboBoxMinute.SelectedIndex = 0;

            comboBoxHour.SelectedIndexChanged += OnSelectedTimeChanged;
            comboBoxMinute.SelectedIndexChanged += OnSelectedTimeChanged;
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int SelectedHour
        {
            get => (int)comboBoxHour.SelectedItem;
            set => comboBoxHour.SelectedItem = value;
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int SelectedMinute
        {
            get => (int)comboBoxMinute.SelectedItem;
            set => comboBoxMinute.SelectedItem = value;
        }

        public event EventHandler SelectedTimeChanged;

        private void OnSelectedTimeChanged(object sender, EventArgs e)
        {
            SelectedTimeChanged?.Invoke(this, EventArgs.Empty);
        }


        private void TimePickerControl_Load(object sender, EventArgs e)
        {

        }
    }
}
