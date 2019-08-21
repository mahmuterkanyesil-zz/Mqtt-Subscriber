using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MqttSubscriber
{
    public partial class Form1 : Form
    {
        Functions functions;

        public Form1()
        {
            InitializeComponent();
            functions = new Functions();
            CheckForIllegalCrossThreadCalls = false;
        } 

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            string ipAdress = txtGetIpAddress.Text;
            int portNumber = Convert.ToInt32(txtGetPortNumber.Text);
            functions.mqttConnect(ipAdress, portNumber);
            btnConnect.BackColor = Color.PowderBlue;
        }

        private void BtnSubscribe_Click(object sender, EventArgs e)
        {
            string topic = txtGetTopic.Text;
            string[] topics = functions.splitText(topic, ';');

            for(int i = 0; i<topics.Length; i++)
            {
                functions.subscribe(topics[i], cmBoxGetQosLevel.SelectedIndex);
                functions.getMessages(writeMessage, getTotalCount);
            }
            btnSubscribe.BackColor = Color.PowderBlue;
            btnUnSubscribe.BackColor = default;
        }

        private void writeMessage(string mesaj)
        {
            richTbIncomingMessages.Text += Environment.NewLine + mesaj;
        }
        private void getTotalCount(string count)
        {
            lblIncomingTotalMessage.Text = count; 
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            richTbIncomingMessages.Clear();
            lblIncomingTotalMessage.Text = "0";
            functions.resetIteration.Invoke();
        }
        
        private void BtnUnSubscribe_Click(object sender, EventArgs e)
        {
            string getTopic = txtGetTopic.Text;
            string[] topics = functions.splitText(getTopic, ';');

            if (topics.Length == 0)
            {
                functions.unSubscribe(topics[0]);
                btnUnSubscribe.BackColor = Color.PowderBlue;
                btnSubscribe.BackColor = default;
            }

            else
            {
                for (int i = 0; i < topics.Length; i++)
                {
                    functions.unSubscribe(topics[i]);
                    btnUnSubscribe.BackColor = Color.PowderBlue;
                    btnSubscribe.BackColor = default;
                }
            }
        }
    }
}