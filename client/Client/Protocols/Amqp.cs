using System;
using RabbitMQ.Client;
using System.Threading;
using System.Text;

namespace Client.Protocols
{
    class Amqp : ProtocolInterface
    {
        private string endpoint;
        private string queueName;

        // Parametri di configurazione, da isolare in file esterno
        private readonly string username = "vnfibwln";
        private readonly string password = "***";
        private readonly string virtualhost = "vnfibwln";

        /**
         * Compatibile con vers. 0.9.1 (RabbitMQ)
         */
        public Amqp(string endpoint, string queue)
        {
            this.endpoint = endpoint;
            this.queueName = queue;
        }

        /*
         * Possibili refactoring:
         * - riutilizzare la stessa connessione per ogni invio, quindi aprirla all'avvio dell'applicazione e chiuderla al termine
         * - gestire situazioni d'errore: cosa accade se il broker non è raggiungibile?
         */
        public void Send(string message)
        {
            var factory = new ConnectionFactory() { 
                HostName = endpoint,
                UserName = username,
                Password = password,
                VirtualHost = virtualhost
            };
            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: queueName,
                                         durable: false,
                                         exclusive: false,
                                         autoDelete: false,
                                         arguments: null);

                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(exchange: "",
                                         routingKey: queueName,
                                         basicProperties: null,
                                         body: body);
                    Console.WriteLine("Sent {0}", message);
                }
            }

        }
    }
}
