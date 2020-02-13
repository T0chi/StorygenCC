using storygen.Elements;
using storygen.Util;
using StorygenCC.utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace storygen
{
    class Storyboard : Osb
    {
        private readonly List<StoryboardSection> sections = new List<StoryboardSection>();

        private FontManager fontManager;

        public Storyboard(String FolderPath, List<StoryboardSection> sections) : base(FolderPath)
        {
            this.sections = sections;
            this.fontManager = new FontManager(this);
            GenerateStoryboard();
        }
        private void GenerateStoryboard()
        {
            foreach(var section in sections)
            {
                fontManager.GenerateLine(section.title, section.startTime, section.endTime, 0, 400);
                fontManager.GenerateLine(section.subTitle, section.startTime, section.endTime, 0, 420);
            }
        }
    }
}
