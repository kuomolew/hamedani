const EventEmitter = require("events");

const url = "http://mylog.io";

class Logger extends EventEmitter {
  log(message) {
    // Send an HTTP request
    console.log(message);

    // Raise an event
    this.emit("messageLogged", { id: 1, url: url });
  }
}

module.exports = Logger;
