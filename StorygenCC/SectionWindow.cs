using System;
using StorygenCC.utils;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace StorygenCC
{
    public partial class SectionWindow : Form
    {
        public StoryboardSection section;
        public SectionWindow()
        {
            InitializeComponent();
        }

        private int ConvertTimeStamp(string time)
        {
            if (time == "")
                return 0;

            if (Regex.Matches(time, @"[a-zA-Z]").Count > 0)
            {
                MessageBox.Show("You must indicate a valid timestamp");
                return 0;
            }

            if (time.Contains(") -"))
            {
                string[] timeStamp = time.Split('(')[0].Split(':');

                int mm = int.Parse(timeStamp[0]) * 60000;
                int ss = int.Parse(timeStamp[1]) * 1000;
                int ms = int.Parse(timeStamp[2]);
                return mm + ss + ms;
            }
            else return int.Parse(time);
        }

        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            section = new StoryboardSection(ConvertTimeStamp(inputStartTime.Text), ConvertTimeStamp(inputEndTime.Text), inputTitle.Text, inputSubTitle.Text);
            ActiveForm.Close();
        }
    }
}
