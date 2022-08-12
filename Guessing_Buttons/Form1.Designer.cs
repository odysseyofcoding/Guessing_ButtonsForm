
namespace Guessing_Buttons
{
    public class NonFocusButton : System.Windows.Forms.Button
    {
        public NonFocusButton()
        {
            SetStyle(System.Windows.Forms.ControlStyles.Selectable, false);
        }
    }
    partial class Frm_GuessingButtons
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        #endregion
        private void InitializeComponent()
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            DoubleBuffered = true;
            //
            // btn_Start
            //
            ButtonListner.btnStart = new System.Windows.Forms.Button()
            {
                Location = new System.Drawing.Point(219, 239),
                Name = "btn_Start",
                Size = new System.Drawing.Size(157, 23),
                TabIndex = 0,
                Text = "Start",
                UseVisualStyleBackColor = true,
            };
            
            //
            // button1
            //
            ButtonListner.btnButton1 = new NonFocusButton()
            {
                Location = new System.Drawing.Point(178, 85),
                Name = "button1",
                Size = new System.Drawing.Size(75, 23),
                TabIndex = 1,
                Text = "button1",
                UseVisualStyleBackColor = true,
            };
            //
            // button2
            //
            ButtonListner.btnButton2 = new NonFocusButton()
            {
                Location = new System.Drawing.Point(260, 85),
                Name = "button2",
                Size = new System.Drawing.Size(75, 23),
                TabIndex = 2,
                Text = "button2",
                UseVisualStyleBackColor = true
            };
            //
            // button3
            //
            ButtonListner.btnButton3 = new NonFocusButton()
            {
                Location = new System.Drawing.Point(342, 85),
                Name = "button3",
                Size = new System.Drawing.Size(75, 23),
                TabIndex = 3,
                Text = "button3",
                UseVisualStyleBackColor = true
            };
            //
            // button4
            //
            ButtonListner.btnButton4 = new NonFocusButton()
            {
                Location = new System.Drawing.Point(178, 115),
                Name = "button4",
                Size = new System.Drawing.Size(75, 23),
                TabIndex = 4,
                Text = "button4",
                UseVisualStyleBackColor = true,
            };
            //
            // button5
            //
            ButtonListner.btnButton5 = new NonFocusButton()
            {
                Location = new System.Drawing.Point(260, 115),
                Name = "button5",
                Size = new System.Drawing.Size(75, 23),
                TabIndex = 5,
                Text = "button5",
                UseVisualStyleBackColor = true
            };
            //
            // button6
            //
            ButtonListner.btnButton6 = new NonFocusButton()
            {
                Location = new System.Drawing.Point(342, 115),
                Name = "button6",
                Size = new System.Drawing.Size(75, 23),
                TabIndex = 6,
                Text = "button6",
                UseVisualStyleBackColor = true
            };
            //
            // button7
            //
            ButtonListner.btnButton7 = new NonFocusButton()
            {
                Location = new System.Drawing.Point(178, 145),
                Name = "button7",
                Size = new System.Drawing.Size(75, 23),
                TabIndex = 7,
                Text = "button7",
                UseVisualStyleBackColor = true
            };
            //
            // button8
            //
            ButtonListner.btnButton8 = new NonFocusButton()
            {
                Location = new System.Drawing.Point(260, 145),
                Name = "button8",
                Size = new System.Drawing.Size(75, 23),
                TabIndex = 8,
                Text = "button8",
                UseVisualStyleBackColor = true
            };
            //
            // button9
            //
            ButtonListner.btnButton9 = new NonFocusButton()
            {
                Location = new System.Drawing.Point(342, 145),
                Name = "button9",
                Size = new System.Drawing.Size(75, 23),
                TabIndex = 9,
                Text = "button9",
                UseVisualStyleBackColor = true
            };
            //
            // btn_Confirm
            //
            ButtonListner.btnConfirm = new System.Windows.Forms.Button()
            {
                Location = new System.Drawing.Point(260, 196),
                Name = "btn_Confirm",
                Size = new System.Drawing.Size(75, 23),
                TabIndex = 10,
                Text = "confirm",
                UseVisualStyleBackColor = true
            };
            this.SuspendLayout();
            //
            // CLick Event Handler
            //
            ButtonListner.btnStart.Click += new System.EventHandler(ButtonListner.BtnStart_Click);
            ButtonListner.btnButton1.Click += new System.EventHandler(ButtonListner.BtnButton1_Click);
            ButtonListner.btnButton2.Click += new System.EventHandler(ButtonListner.BtnButton2_Click);
            ButtonListner.btnButton3.Click += new System.EventHandler(ButtonListner.BtnButton3_Click);
            ButtonListner.btnButton4.Click += new System.EventHandler(ButtonListner.BtnButton4_Click);
            ButtonListner.btnButton5.Click += new System.EventHandler(ButtonListner.BtnButton5_Click);
            ButtonListner.btnButton6.Click += new System.EventHandler(ButtonListner.BtnButton6_Click);
            ButtonListner.btnButton7.Click += new System.EventHandler(ButtonListner.BtnButton7_Click);
            ButtonListner.btnButton8.Click += new System.EventHandler(ButtonListner.BtnButton8_Click);
            ButtonListner.btnButton9.Click += new System.EventHandler(ButtonListner.BtnButton9_Click);
            ButtonListner.btnConfirm.Click += new System.EventHandler(ButtonListner.BtnConfirm_Click);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(ButtonListner.number_OnKeypress);
            ButtonListner.btnConfirm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(ButtonListner.number_OnKeypress);
            //
            // Control    
            //
            
            this.Controls.AddRange
                (new System.Windows.Forms.Control[]
                {
                    ButtonListner.btnStart,
                    ButtonListner.btnConfirm,
                    ButtonListner.btnButton1,
                    ButtonListner.btnButton2,
                    ButtonListner.btnButton3,
                    ButtonListner.btnButton4,
                    ButtonListner.btnButton5,
                    ButtonListner.btnButton6,
                    ButtonListner.btnButton7,
                    ButtonListner.btnButton8,
                    ButtonListner.btnButton9,
                });
            //
            // Form Header
            //
            this.Name = "Frm_GuessingButtons";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_GuessingButtons_Load);
            this.ResumeLayout(false);
            //
            // Form Layout
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);

        }
        //
        // Frm_GuessingButtons
        //
        public static System.Windows.Forms.Button btnStart;
        public static NonFocusButton btnButton1;
        public static NonFocusButton btnButton2;
        public static NonFocusButton btnButton3;
        public static NonFocusButton btnButton4;
        public static NonFocusButton btnButton5;
        public static NonFocusButton btnButton6;
        public static NonFocusButton btnButton7;
        public static NonFocusButton btnButton8;
        public static NonFocusButton btnButton9;
        public static System.Windows.Forms.Button btnConfirm;
        //private System.Windows.Forms.Button btn_Start;
    }
}

