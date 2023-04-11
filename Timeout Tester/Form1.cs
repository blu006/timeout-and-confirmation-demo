using System;
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
        private MAGLabCL.Timeout timeout_inst = new MAGLabCL.Timeout();
        private MAGLabCL.ConfirmationThreshold<value_t> ct_inst = new MAGLabCL.ConfirmationThreshold<value_t>(value_t.eUnknown);
        public value_t confirmedValue = value_t.eUnknown;
        private value_t newValue = value_t.eOff;
        private UInt16 secondsCounter = 0;
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
            timeout = timeout_inst.update(received, secondsCounter, Convert.ToUInt16(numericUpDownTimeout.Value));

            // confirmation state machine
            confirmedValue = ct_inst.update(
                received,
                newValue,
                secondsCounter,
                Convert.ToUInt16(numericUpDownCnfTime.Value),
                Convert.ToUInt16(numericUpDownCnfNum.Value)
            );
            

            // output code
            if (timeout == true)
            {
                textBoxConfirmedValue.Text = "Timeout";
            }
            else if (confirmationCounter == 0)
            {
                // display value
                if (confirmedValue == value_t.eOn)
                {
                    textBoxConfirmedValue.Text = "On";
                }
                else if (confirmedValue == value_t.eOff)
                {
                    textBoxConfirmedValue.Text = "Off";
                }
                else
                {
                    textBoxConfirmedValue.Text = "Unknown";
                }
            }

            textBoxConfirmationTime.Text = (secondsCounter - ct_inst.lastConfTime).ToString();
            textBoxTimeout.Text = (secondsCounter - timeout_inst.lastRecTime).ToString();
            textBoxConfirmationCount.Text = ct_inst.confNumCounter.ToString();

            // display counters
            received = false;
        }
    }
}
