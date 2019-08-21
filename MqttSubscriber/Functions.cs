using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Connecting;
using MQTTnet.Client.Disconnecting;
using MQTTnet.Client.Options;
using MQTTnet.Client.Receiving;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MqttSubscriber
{
    class Functions
    {
        IMqttClient mqttClient;
        public Action resetIteration;

        public String[] splitText(string topic, char splitChar)
        {
            string[] text = topic.Split(splitChar);
            return text;
        }

        public async void mqttConnect(string tcpServer, int port)
        {
            if (mqttClient == null)
            {
                var factory = new MqttFactory();
                mqttClient = factory.CreateMqttClient();
                var options = new MqttClientOptionsBuilder()
                    .WithTcpServer(tcpServer, port)
                    .Build();
                await mqttClient.ConnectAsync(options);
            }
        }

        public void subscribe(string topic, int qosLevel)
        {
            mqttClient.SubscribeAsync(topic, (MQTTnet.Protocol.MqttQualityOfServiceLevel)qosLevel);
        }

        public void unSubscribe(string topic)
        {
            mqttClient.UnsubscribeAsync(topic).Wait();
        }


        public void getMessages(Action<string> messages, Action<string> messageTotal)
        {
            var stopwatch = new Stopwatch();
            var total = 0;
            var sentMessagesCount = 0;
            var iteration = 1;

            mqttClient.UseApplicationMessageReceivedHandler(e =>
            {
                Console.WriteLine(iteration);
                if (sentMessagesCount == 0)
                {
                    stopwatch.Restart();
                }
                if (stopwatch.ElapsedMilliseconds < 1000)
                {
                    sentMessagesCount++;
                }
                else
                {
                    total += sentMessagesCount;
                    messageTotal.Invoke(String.Format("{0}", total));
                    messages.Invoke(String.Format("{0}. Loop Incoming Persecond Message Count = {1}", iteration, sentMessagesCount));
                    sentMessagesCount = 0;
                    iteration++;

                    resetIteration = () =>
                    {
                        iteration = 0;
                        total = 0;
                    };
                }
            });
        }
    }
}
