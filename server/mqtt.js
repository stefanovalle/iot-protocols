const mqtt = require('mqtt')
const client  = mqtt.connect('mqtt://test.mosquitto.org')

client.on('connect', function () {
    console.log("Connesso");
    client.subscribe('amaro2022test/#');
})

client.on('message', function (topic, message) {
  console.log('TOPIC: ' + topic + "\nMESSAGE: " + message.toString());
})