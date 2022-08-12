using System;
using System.Collections.Generic;

namespace Guessing_Buttons
{
    class GlobalVariables //: Frm_GuessingButtons
    {
        public static List<string> PressedOrder = new List<string>();
        public static List<string> GeneratedOrder = new List<string>();
        public static Random FlashBackground = new Random();
        public static int Round = 1;
        public static bool Win = false;
        public static bool EnableKeyPress = false;

        public static System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        // Storing it resources as a Stream because otherwise it occupies the process memory with each play with the soundplayer
        public static System.IO.Stream WinSound = Properties.Resources.WinSound;
        public static System.IO.Stream StrikeSound = Properties.Resources.StrikeSound;

        // button light up
        private static int blinkDuration;
        public static int BlinkDuration
        {
            get { return blinkDuration; }
            set { if (value > 50) blinkDuration = value; }
        }
        // wait between button light ups
        private static int switchSpeed;
        public static int SwitchSpeed
        {
            get { return switchSpeed; }
            set { if (value > 25) switchSpeed = value; }
        }
    }
}
