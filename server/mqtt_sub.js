var mqtt = require('mqtt')
var client  = mqtt.connect('mqtt://localhost')

client.on('connect', function () {
  console.log('connected');

  // subscribe to topic
  client.subscribe('monopattino/#');
})

client.on('message', function (topic, message) {
  // message is Buffer
  console.log(message.toString())
})