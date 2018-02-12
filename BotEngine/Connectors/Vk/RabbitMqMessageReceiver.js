#!/usr/bin/env node

const amqp = require('amqplib');

function RabbitMqMessageReceiver(serverUri, queueName) {
   
    var _serverUri = serverUri;
    var _queueName = queueName;
    var _chanel = null;
    var _connection = null;
    var _consumers = [];

    this.connect = function() {
        
        amqp.connect(_serverUri)
            .then(function(conn) {
                _connection = conn;
                return conn.createChannel();
            }).then(function(ch) {
                _chanel = ch;

                _consumers.forEach(function(currentValue, index, array) {
                    _chanel.consume(_queueName, currentValue);
                });
                _consumers = [];

                return ch.assertQueue(_queueName);
            })
        .catch(console.warn);
    }

    this.receive = function() {
        return _chanel.get()
    }

    this.consume = function(callback) {
        if(_chanel == null){
            _consumers.push(callback);
            return;
        }

        _chanel.consume(_queueName, callback);
    }

    this.disconnect = function() {
        return _connection.close();
    }
}


// export the class
module.exports = RabbitMqMessageReceiver;

