using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorygenCC.utils
{
    public class StoryboardSection
    {
        public int startTime;
        public int endTime;
        public string title;
        public string subTitle;

        public StoryboardSection(int startTime, int endTime, string title, string subTitle)
        {
            this.startTime = startTime;
            this.endTime = endTime;
            this.title = title;
            this.subTitle = subTitle;
        }

        public string[] ConvertSectionToString()
        {
            return new string[]
            {
                startTime.ToString(),
                endTime.ToString(),
                title,
                subTitle
            };
        }
    }
}
