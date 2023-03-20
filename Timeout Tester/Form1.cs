using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timeout_Tester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public enum value_t
        {
            eOff = 0,
            eOn,
            eUnknown
        };

        private bool received = false;
        public value_t confirmedValue = value_t.eUnknown;
        private value_t newValue = value_t.eOff;
        private UInt16 secondsCounter = 0;
        private UInt16 lastReceivedCounter = 0;
        private UInt16 lastConfirmedCounter = 0;
        private bool timeout = true;
        private UInt16 confirmationCounter = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            received = true;
            if (radioButtonOn.Checked == true)
            {
                newValue = value_t.eOn;
            }
            else
            {
                newValue = value_t.eOff;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            secondsCounter++;
            // timeout / received state machine
            if (received)
            {
                lastReceivedCounter = secondsCounter;
                timeout = false;
            }

            if (secondsCounter - lastReceivedCounter >= numericUpDownTimeout.Value)
            {
                timeout = true;
            }

            if (secondsCounter - lastReceivedCounter > numericUpDownTimeout.Value)
            {
                lastReceivedCounter += 1;
            }

            // confirmation state machine
            if (received)
            {
                // received counter processing
                if (confirmationCounter <= numericUpDownCnfNum.Value)
                {
                    confirmationCounter += 1;
                }

                // new value processing
                if (newValue != confirmedValue)
                {
                    // if both the numeric value and the counter are above the ratio, we have a new value
                    if (confirmationCounter >= numericUpDownCnfNum.Value)
                    {
                        if (secondsCounter - lastConfirmedCounter > numericUpDownCnfTime.Value)
                        {
                            confirmedValue = newValue;
                        }
                    }
                }

                // confirmed value processing
                if (newValue == confirmedValue)
                {
                    confirmationCounter = 0;
                    lastConfirmedCounter = secondsCounter;
                }
            }

            if (secondsCounter - lastConfirmedCounter > numericUpDownCnfTime.Value)
            {
                lastConfirmedCounter += 1;
            }

            // output code
            if (timeout == true)
            {
                confirmedValue = value_t.eUnknown;
                // display value
                textBoxConfirmedValue.Text = "Unknown";
            }
            else if (confirmationCounter == 0)
            {
                // display value
                if (confirmedValue == value_t.eOn)
                {
                    textBoxConfirmedValue.Text = "On";
                }
                else
                {
                    textBoxConfirmedValue.Text = "Off";
                }
            }

            textBoxConfirmationTime.Text = (secondsCounter - lastConfirmedCounter).ToString();

            textBoxTimeout.Text = (secondsCounter - lastReceivedCounter).ToString();

            textBoxConfirmationCount.Text = confirmationCounter.ToString();

            // display counters
            received = false;
        }
    }
}
