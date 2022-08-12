using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Guessing_Buttons
{

    public partial class Frm_GuessingButtons : Form
    {
        public Frm_GuessingButtons()
        {
            InitializeComponent();
        }
        private void Frm_GuessingButtons_Load(object sender, EventArgs e)
        {
            
            Size = new Size(600,400);
            GlobalVariables.BlinkDuration = 500;
            GlobalVariables.SwitchSpeed = 250;
            Methods.SetButtonDefaultBackgroundColor();
            Methods.DisableAllButtons();
        }     
    }
}
