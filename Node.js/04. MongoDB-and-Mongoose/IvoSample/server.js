var mongoose = require('mongoose');

mongoose.connect('mongodb://localhost:27017/students');
var db = mongoose.connection;

db.once('open', function(err){
    if(err){
        console.log(err);
    }

    console.log('MongoDb database up and running...')
});

//console.log every error from database.
db.on('error', function(err){
    console.log(err);
});