using System.Threading;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace Guessing_Buttons
{
    class Methods : Frm_GuessingButtons
    {
        public static void SetButtonDefaultBackgroundColor()
        {
            btnButton1.BackColor =
            btnButton2.BackColor =
            btnButton3.BackColor =
            btnButton4.BackColor =
            btnButton5.BackColor =
            btnButton6.BackColor =
            btnButton7.BackColor =
            btnButton8.BackColor =
            btnButton9.BackColor = default;
        }
        public static void DisableAllButtons()
        {
            btnButton1.Enabled =
            btnButton2.Enabled =
            btnButton3.Enabled =
            btnButton4.Enabled =
            btnButton5.Enabled =
            btnButton6.Enabled =
            btnButton7.Enabled =
            btnButton8.Enabled =
            btnButton9.Enabled =
            btnConfirm.Enabled = false;
        }
        public static void EnableAllButtons()
        {
            btnButton1.Invoke((MethodInvoker)(() => btnButton1.Enabled = true));
            btnButton2.Invoke((MethodInvoker)(() => btnButton2.Enabled = true));
            btnButton3.Invoke((MethodInvoker)(() => btnButton3.Enabled = true));
            btnButton4.Invoke((MethodInvoker)(() => btnButton4.Enabled = true));
            btnButton5.Invoke((MethodInvoker)(() => btnButton5.Enabled = true));
            btnButton6.Invoke((MethodInvoker)(() => btnButton6.Enabled = true));
            btnButton7.Invoke((MethodInvoker)(() => btnButton7.Enabled = true));
            btnButton8.Invoke((MethodInvoker)(() => btnButton8.Enabled = true));
            btnButton9.Invoke((MethodInvoker)(() => btnButton9.Enabled = true));
            btnConfirm.Invoke((MethodInvoker)(() => btnConfirm.Enabled = true));


            //btn_button1.Enabled =
            //btn_button2.Enabled =
            //btn_button3.Enabled =
            //btn_button4.Enabled =
            //btn_button5.Enabled =
            //btn_button6.Enabled =
            //btn_button7.Enabled =
            //btn_button8.Enabled =
            //btn_button9.Enabled = true;
            // btn_Confirm.Enabled = true;

        }

        public static void HideAllButtons()
        {
            btnButton1.Invoke((MethodInvoker)(() => btnButton1.Visible = false));
            btnButton2.Invoke((MethodInvoker)(() => btnButton2.Visible = false));
            btnButton3.Invoke((MethodInvoker)(() => btnButton3.Visible = false));
            btnButton4.Invoke((MethodInvoker)(() => btnButton4.Visible = false));
            btnButton5.Invoke((MethodInvoker)(() => btnButton5.Visible = false));
            btnButton6.Invoke((MethodInvoker)(() => btnButton6.Visible = false));
            btnButton7.Invoke((MethodInvoker)(() => btnButton7.Visible = false));
            btnButton8.Invoke((MethodInvoker)(() => btnButton8.Visible = false));
            btnButton9.Invoke((MethodInvoker)(() => btnButton9.Visible = false));
            btnConfirm.Invoke((MethodInvoker)(() => btnConfirm.Visible = false));

            //btnButton1.Visible =
            //btnButton2.Visible =
            //btnButton3.Visible =
            //btnButton4.Visible =
            //btnButton5.Visible =
            //btnButton6.Visible =
            //btnButton7.Visible =
            //btnButton8.Visible =
            //btnButton9.Visible =
            //btnConfirm.Visible = false;
        }
        public static void ShowAllButtons()
        {
            btnButton1.Invoke((MethodInvoker)(() => btnButton1.Visible = true));
            btnButton2.Invoke((MethodInvoker)(() => btnButton2.Visible = true));
            btnButton3.Invoke((MethodInvoker)(() => btnButton3.Visible = true));
            btnButton4.Invoke((MethodInvoker)(() => btnButton4.Visible = true));
            btnButton5.Invoke((MethodInvoker)(() => btnButton5.Visible = true));
            btnButton6.Invoke((MethodInvoker)(() => btnButton6.Visible = true));
            btnButton7.Invoke((MethodInvoker)(() => btnButton7.Visible = true));
            btnButton8.Invoke((MethodInvoker)(() => btnButton8.Visible = true));
            btnButton9.Invoke((MethodInvoker)(() => btnButton9.Visible = true));
            btnConfirm.Invoke((MethodInvoker)(() => btnConfirm.Visible = true));


            //btnButton1.Visible =
            //btnButton2.Visible =
            //btnButton3.Visible =
            //btnButton4.Visible =
            //btnButton5.Visible =
            //btnButton6.Visible =
            //btnButton7.Visible =
            //btnButton8.Visible =
            //btnButton9.Visible =
            //btnConfirm.Visible = true;
        }

        public static void UpdateButtonAndList(System.Windows.Forms.Button button, string order)
        {
            //lblDebugInfo.Invoke((MethodInvoker)(() => lblDebugInfo.Text = text));
            GlobalVariables.GeneratedOrder.Add(order);
            button.Invoke((MethodInvoker)(() => button.BackColor = Color.Red));
            button.Invoke((MethodInvoker)(() => button.Update())); //BackColor = Color.Red;
            Thread.Sleep(GlobalVariables.BlinkDuration);
            button.Invoke((MethodInvoker)(() => button.BackColor = default));
            button.Invoke((MethodInvoker)(() => button.Update()));
            Thread.Sleep(GlobalVariables.SwitchSpeed);
        }

        public static void UpdateClickedButtonAndPressedOrder(System.Windows.Forms.Button button, string order)
        {
            GlobalVariables.PressedOrder.Add(order);
            button.Invoke((MethodInvoker)(() => button.BackColor = Color.Red));
            button.Invoke((MethodInvoker)(() => button.Update()));
            Thread.Sleep(100);
            button.Invoke((MethodInvoker)(() => button.BackColor = default));
            button.Invoke((MethodInvoker)(() => button.Update()));
            Thread.Sleep(100);
        }

        public static void LightTheForm()
        {
            //to prevent graphical artifacts
            HideAllButtons();
            for (int i = 0; i < 100; i++)
            {
                

                ActiveForm.Invoke((MethodInvoker)(() 
                    => ActiveForm.BackColor = 
                    Color.FromArgb(GlobalVariables.FlashBackground.Next(0, 255), 
                    GlobalVariables.FlashBackground.Next(0, 255), 
                    GlobalVariables.FlashBackground.Next(0, 255))));

                Thread.Sleep(5);

                ActiveForm.Invoke((MethodInvoker)(() => ActiveForm.Update()));
            }
            ActiveForm.BackColor = DefaultBackColor;
            ShowAllButtons();
            btnStart.Invoke((MethodInvoker)(() => btnStart.Enabled = true));
            btnStart.Invoke((MethodInvoker)(() => btnStart.Focus()));
            GC.Collect();
        }

        public static void PlaySound(System.IO.Stream soundfile)
        {
            GlobalVariables.player.Stream = soundfile;
            //the waveheader will be corrupted when playing second time
            if (soundfile.CanSeek) soundfile.Seek(0, System.IO.SeekOrigin.Begin);
            GlobalVariables.player.Play();
        }
        public static void StopSound()
        {
            GlobalVariables.player.Stop();
        }
    }
}
