var mongoose = require('mongoose'),
    encryption = require('../../utilities/encryption');

var requiredMessage = '{PATH} is required';

module.exports.init = function () {
    var userSchema = mongoose.Schema({
        username: {
            type: String,
            required: requiredMessage,
            unique: true,
            validate: {
                validator: function (v) {
                    return /^[a-zA-Z_.]{3,7}$/.test(v);
                },
                message: '{VALUE} is not a valid userName! username should be between 6 and 20 characters long and can contain Latin letters, digits and the symbols "_" (underscore), and "." (dot)'
            }
        },
        salt: String,
        hashPass: String,
        firstName: {
            type: String,
            required: requiredMessage
        },
        lastName: {
            type: String,
            required: requiredMessage
        },
        email: {
            type: String,
            required: requiredMessage
        },
        avatar: String,
        facebookLink: String,
        youtubeLink: String
    });

    userSchema.method({
        authenticate: function (password) {
            if (encryption.generateHashedPassword(this.salt, password) === this.hashPass) {
                return true;
            }
            else {
                return false;
            }
        }
    });

    var User = mongoose.model('User', userSchema);
};


