using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.VeryEasyCodeChallenges
{
    internal class FramesPerSecond
    {
        public static int framesPerSecond(int min, int fps)
        {
            int frames = 60 * min * fps;
            return frames;
        }
    }
}
