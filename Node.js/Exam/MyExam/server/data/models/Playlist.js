var mongoose = require('mongoose');

var requiredMessage = '{PATH} is required';

module.exports.init = function () {
    var playListSchema = mongoose.Schema({
        title: {
            type: String,
            required: requiredMessage
        },
        description: {
            type: String,
            required: requiredMessage
        },
        videoURLs: [String],
        category: {
            type: String,
            required: requiredMessage
        },
        creator: {
            type: String,
            required: requiredMessage
        },
        creationDate: {
            type: Date,
            required: requiredMessage
        },
        isPublic: {
            type: Boolean,
            required: requiredMessage
        },
        comments: [{
            creator: String,
            text: String
        }],
        contributes: [String]
    });

    var Playlist = mongoose.model('Playlist', playListSchema);
};


