#!/usr/bin/env node

const amqp = require('amqplib');


function RabbitMqMessageSender(serverUri, queueName) {
    
     var _serverUri = serverUri;
     var _queueName = queueName;
     var _chanel = null;
     var _connection = null;
 
     this.connect = function() {
         return amqp.connect(_serverUri)
             .then(function(conn) {
                 _connection = conn;
                 return conn.createChannel();
             }).then(function(ch) {
                 _chanel = ch;
                 return ch.assertQueue(_queueName);
             });
     };

     this.send = function(message, properties) {
        return _chanel.sendToQueue(_queueName, new Buffer(message), properties);
     };

     this.disconnect = function() {
         return _connection.close();
     }
 
 }

// export the class
module.exports = RabbitMqMessageSender;
