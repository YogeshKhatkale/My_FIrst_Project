using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_FIrst_Project
{
    internal interface IPlayable
    {
        void play(string action);
    }

    public class VideoPlayer : IPlayable
    {
        public void play(string action)
        {
            Console.WriteLine($"{action} videos ");
        }
    }

    public class MusicPlayer : IPlayable
    {
        public void play(string action)
        {
            Console.WriteLine($"{action} Music.");
        }
    }

    internal interface AssignmentInterface
    {
        static void Main()
        {
            // test1
            IPlayable play1 = new VideoPlayer();
            play1.play("playing");

            // test2

            IPlayable play2 = new MusicPlayer();
            play2.play("playing");
        }
    }
}
