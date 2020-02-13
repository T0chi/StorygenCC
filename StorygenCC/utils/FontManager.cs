using storygen;
using storygen.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorygenCC.utils
{
    class FontManager
    {
        private Storyboard storyboard;
        Font font;

        public FontManager(Storyboard storyboard)
        {
            this.storyboard = storyboard;
            this.font = storyboard.Text.LoadFont("Arial", 40);
        }

        public void GenerateLine(string text, int startTime, int endTime, int positionX, int positionY)
        {
            var sentence = font.WriteSentence(
                text,
                startTime,
                new Vector2(positionX, positionY),
                storyboard.Centre,
                storyboard.Foreground,
                TextAlign.Left
                );

            foreach (var sprite in sentence.Sprites)
            {
                sprite.Fade(startTime, startTime + 500, 0, 1);
                sprite.Fade(endTime - 500, endTime + 500, 1, 0);
            }
        }
    }
}
