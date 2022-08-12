using System.Threading;

namespace Guessing_Buttons
{
    public class MyThreads
    {
        static Thread startThread;
        static ThreadStart initiateThread;

        private delegate void MyDelegateClass();

        public static void MyDelegateBuffer()
        {

        }

        public static void UseThread()
        {
            initiateThread = new ThreadStart(CreateGuessingOrder.GenerateGuessingOrderAndRunAnimation);
            startThread = new Thread(initiateThread)
            {
                IsBackground = true
            };
            startThread.Start();                        
        }

        static Thread startLightning;
        static ThreadStart initiateLightning;

        public static void LightningThread()
        {
            initiateLightning = new ThreadStart(Methods.LightTheForm);
            startLightning = new Thread(initiateLightning)
            {
                IsBackground = true
            };
            startLightning.Start();
        }
    }
}
