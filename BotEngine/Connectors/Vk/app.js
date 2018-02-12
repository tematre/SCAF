#!/usr/bin/env node

const { Bot }  = require('node-vk-bot');
const RabbitMqReceiver  =  require('./RabbitMqMessageReceiver.js')
const RabbitMqSenderr =  require('./RabbitMqMessageSender.js')

const util = require('util');
const nconf = require('nconf');


nconf.file({ file: 'config.json' });


var sender = new RabbitMqSenderr(nconf.get('server:address'), nconf.get('server:inputQueue'));
var receiver = new RabbitMqReceiver(nconf.get('server:address'), nconf.get('server:outputQueue'));

var bot = new Bot({
  token: nconf.get('vk:token'),
  chats: []
})

bot.get(/.*/, message => {
  sender.send(JSON.stringify(message.body), { headers : {"VkUserId" : message.peer_id}});
})

receiver.consume(msg => {
  console.log(JSON.stringify(msg.connect.toString()))
  bot.send(msg.content.toString(), msg.properties.headers["VkUserId"])  
});

bot.start()
sender.connect();
receiver.connect();