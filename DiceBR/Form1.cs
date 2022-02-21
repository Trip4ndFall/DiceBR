using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace DiceBR
{
    public partial class Form1 : Form
    {
        private TextBox[] options;
        private int optionsLeft;
        Random random;
        int val;

        public Form1()
        {
            InitializeComponent();
            options = new TextBox[6];
            options[0] = txtOption1;
            options[1] = txtOption2;
            options[2] = txtOption3;
            options[3] = txtOption4;
            options[4] = txtOption5;
            options[5] = txtOption6;
            optionsLeft = 6;
            val = 1;
        }

        private void lblCloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (TextBox option in options)
            {
                option.Enabled = true;
                option.Clear(); 
                option.BackColor = Color.White;
            }
            optionsLeft = 6;
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            tmrTimer.Start();
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            prgProgress.Increment(5);
            random = new Random();

            if (prgProgress.Value == 100)
            {
                tmrTimer.Stop();
                prgProgress.Value = 0;
                if (options[val - 1].Enabled)
                {
                    options[val - 1].Enabled = false;
                    options[val - 1].BackColor = System.Drawing.SystemColors.GrayText;
                    optionsLeft -= 1;
                }
                if (optionsLeft == 1)
                {
                    foreach (TextBox option in options)
                    {
                        if (option.Enabled)
                        {
                            MessageBox.Show(option.Text + " has won!"); 
                        }
                    }
                }
            }
            else
            {
                val = random.Next(1, 7);
                switch (val)
                {
                    case 1:
                        picDice.Image = Properties.Resources.Alea_1;
                        break;
                    case 2:
                        picDice.Image = Properties.Resources.Alea_2;
                        break;
                    case 3:
                        picDice.Image = Properties.Resources.Alea_3;
                        break;
                    case 4:
                        picDice.Image = Properties.Resources.Alea_4;
                        break;
                    case 5:
                        picDice.Image = Properties.Resources.Alea_5;
                        break;
                    case 6:
                        picDice.Image = Properties.Resources.Alea_6;
                        break;
                }
            }
        }
    }
}
