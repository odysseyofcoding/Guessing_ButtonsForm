using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Guessing_Buttons
{
    public class ButtonListner : Frm_GuessingButtons
    {

        public static void BtnConfirm_Click(object sender, EventArgs e)
        {
            //Prevent player to falsify the order
            Methods.DisableAllButtons();
            // Compare Guessing
            if (Enumerable.SequenceEqual(GlobalVariables.PressedOrder, GlobalVariables.GeneratedOrder) == true)
            {
                GlobalVariables.Win = true;

                //Visible Winning sequence
                Methods.PlaySound(GlobalVariables.WinSound);

                // Prevent player from creating an artifact
                btnStart.Enabled = false;

                MyThreads.LightningThread();

                Methods.ShowAllButtons();
                //ActiveForm.Update();

                GlobalVariables.Round += 1;
                btnStart.Text = $"Start round {GlobalVariables.Round}";
                GC.Collect();
            }
            else
            {
                GlobalVariables.Win = false;
                Methods.PlaySound(GlobalVariables.StrikeSound);
                btnStart.Enabled = true;
            }

            GlobalVariables.GeneratedOrder.Clear();
            GlobalVariables.PressedOrder.Clear();

        }
        // Only Focus the confirm Button if Player has pressed at least one SoundButton to prevent the game from starting to loop becuase it queues rounds 
        public static void BtnButton1_Click(object sender, EventArgs e)
        {
            //GlobalVariables.PressedOrder.Add("1");
            Methods.UpdateClickedButtonAndPressedOrder(btnButton1, "1");
            btnConfirm.Focus();
        }
        public static void BtnButton2_Click(object sender, EventArgs e)
        {
            Methods.UpdateClickedButtonAndPressedOrder(btnButton2, "2");
            btnConfirm.Focus();
        }
        public static void BtnButton3_Click(object sender, EventArgs e)
        {
            Methods.UpdateClickedButtonAndPressedOrder(btnButton3, "3");
            btnConfirm.Focus();
        }
        public static void BtnButton4_Click(object sender, EventArgs e)
        {
            Methods.UpdateClickedButtonAndPressedOrder(btnButton4, "4");
            btnConfirm.Focus();
        }
        public static void BtnButton5_Click(object sender, EventArgs e)
        {
            Methods.UpdateClickedButtonAndPressedOrder(btnButton5, "5");
            btnConfirm.Focus();
        }
        public static void BtnButton6_Click(object sender, EventArgs e)
        {
            Methods.UpdateClickedButtonAndPressedOrder(btnButton6, "6");
            btnConfirm.Focus();
        }
        public static void BtnButton7_Click(object sender, EventArgs e)
        {
            Methods.UpdateClickedButtonAndPressedOrder(btnButton7, "7");
            btnConfirm.Focus();
        }
        public static void BtnButton8_Click(object sender, EventArgs e)
        {
            Methods.UpdateClickedButtonAndPressedOrder(btnButton8, "8");
            btnConfirm.Focus();
        }
        public static void BtnButton9_Click(object sender, EventArgs e)
        {
            Methods.UpdateClickedButtonAndPressedOrder(btnButton9, "9");
            btnConfirm.Focus();
        }
        public static void BtnStart_Click(object sender, EventArgs e)
        {
            // Dont overlap winnning sound with Button sounds
            Methods.StopSound();
            GlobalVariables.EnableKeyPress = false;
            //CreateGuessingOrder.GenerateGuessingOrderAndRunAnimation();
            MyThreads.UseThread();
        }
        #region AssignButtonsToKeyPress
        public static void number_OnKeypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
            if (GlobalVariables.EnableKeyPress == true)
            {
                e.Handled = true;
                switch (e.KeyChar)
                {
                    case (char)Keys.D1:
                    case (char)Keys.NumPad1:
                        e.Handled = true;
                        BtnButton1_Click(sender, e);
                        break;
                    case (char)Keys.D2:
                    case (char)Keys.NumPad2:
                        e.Handled = true;
                        BtnButton2_Click(sender, e);
                        break;
                    case (char)Keys.D3:
                    case (char)Keys.NumPad3:
                        e.Handled = true;
                        BtnButton3_Click(sender, e);
                        break;
                    case (char)Keys.D4:
                    case (char)Keys.NumPad4:
                        e.Handled = true;
                        BtnButton4_Click(sender, e);
                        break;
                    case (char)Keys.D5:
                    case (char)Keys.NumPad5:
                        e.Handled = true;
                        BtnButton5_Click(sender, e);
                        break;
                    case (char)Keys.D6:
                    case (char)Keys.NumPad6:
                        e.Handled = true;
                        BtnButton6_Click(sender, e);
                        break;
                    case (char)Keys.D7:
                    case (char)Keys.NumPad7:
                        e.Handled = true;
                        BtnButton7_Click(sender, e);
                        break;
                    case (char)Keys.D8:
                    case (char)Keys.NumPad8:
                        e.Handled = true;
                        BtnButton8_Click(sender, e);
                        break;
                    case (char)Keys.D9:
                    case (char)Keys.NumPad9:
                        e.Handled = true;
                        BtnButton9_Click(sender, e);
                        break;
                }

            }
        }
        #endregion AssignButtonsToKeyPress
    }
}
