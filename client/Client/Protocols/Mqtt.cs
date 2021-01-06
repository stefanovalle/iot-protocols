using System;
using MQTTnet;
using MQTTnet.Client.Options;
using System.Threading;

namespace Client.Protocols
{
    class Mqtt : ProtocolInterface
    {
        private string endpoint;
        private string topic;

        public Mqtt(string endpoint, string topic)
        {
            this.endpoint = endpoint;
            this.topic = topic;
        }

        /*
         * Possibili refactoring:
         * - riutilizzare la stessa connessione per ogni invio, quindi aprirla all'avvio dell'applicazione e chiuderla al termine
         * - gestire situazioni d'errore: cosa accade se il broker non è raggiungibile?
         */
        public void Send(string data)
        {
            // Create a new MQTT client.
            var factory = new MqttFactory();
            var mqttClient = factory.CreateMqttClient();

            var options = new MqttClientOptionsBuilder()
            .WithTcpServer(endpoint, 1883) // Port is optional
            .Build();

            mqttClient.ConnectAsync(options, CancellationToken.None).GetAwaiter().GetResult();

            var message = new MqttApplicationMessageBuilder()
            .WithTopic(topic)
            .WithPayload(data)
            .Build();

            var result = mqttClient.PublishAsync(message, CancellationToken.None).GetAwaiter().GetResult();

            Console.Out.WriteLine(result.ReasonString);

            mqttClient.Dispose();
        }
    }
}
