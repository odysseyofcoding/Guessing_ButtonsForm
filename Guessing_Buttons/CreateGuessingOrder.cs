using System;
using System.Windows.Forms;

namespace Guessing_Buttons
{
    partial class CreateGuessingOrder : ButtonListner
    {
        public static void GenerateGuessingOrderAndRunAnimation()
        {
            GlobalVariables.EnableKeyPress = false;
            _ = btnStart.Invoke((MethodInvoker)(() => btnStart.Enabled = false));
            Random rnd = new Random();
            int currentGeneratedNumber;
            // Speed up after a won round
            if (GlobalVariables.Win)
            {
                GlobalVariables.BlinkDuration -= 50;
                GlobalVariables.SwitchSpeed -= 25;
            }
            for (int i = 1; i < 5; i++)
            {

                currentGeneratedNumber = rnd.Next(1, 9);
                switch (currentGeneratedNumber)
                {
                    case 1:
                        Methods.UpdateButtonAndList(btnButton1, "1");
                        break;
                    case 2:
                        Methods.UpdateButtonAndList(btnButton2, "2");
                        break;
                    case 3:
                        Methods.UpdateButtonAndList(btnButton3, "3");
                        break;
                    case 4:
                        Methods.UpdateButtonAndList(btnButton4, "4");
                        break;
                    case 5:
                        Methods.UpdateButtonAndList(btnButton5, "5");
                        break;
                    case 6:
                        Methods.UpdateButtonAndList(btnButton6, "6");
                        break;
                    case 7:
                        Methods.UpdateButtonAndList(btnButton7, "7");
                        break;
                    case 8:
                        Methods.UpdateButtonAndList(btnButton8, "8");
                        break;
                    case 9:
                        Methods.UpdateButtonAndList(btnButton9, "9");
                        break;
                }

            }

            Methods.EnableAllButtons();
            try
            {
                // Focus to get the Keystrokes accepted else they won't be accepeted until btn_confirm is focused
                ActiveForm.Invoke((MethodInvoker)(() => ActiveForm.Focus()));

            }
            catch
            {
                //in case the user has focused an other window
            }
            GlobalVariables.EnableKeyPress = true;
        }
    }
}
