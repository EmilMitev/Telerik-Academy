var User = require('mongoose').model('User');

module.exports = {
    create: function(user, callback) {
        User.create(user, callback);
    },
    update: function(updatedUser, callback) {
        User.findOne({_id: updatedUser._id}, function(err, user){
            if(!err) {
                User.update(user, updatedUser, {}, callback);
            }
        });
    }
};