var Playlist = require('mongoose').model('Playlist');

module.exports = {
    create: function (playlist, user, callback) {
        playlist.creator = user.username;
        playlist.creationDate = new Date();
        if (playlist.isPublic) {
            playlist.isPublic = true;
        }
        else {
            playlist.isPublic = false;
        }

        Playlist.create(playlist, callback);
    },
    getById: function (id, callback) {
        Playlist.findOne({_id: id}, callback);
    },
    addVideoToPlayList: function (id, url, callback) {
        var match = /^(?:https?:\/\/)?(?:www\.)?(?:youtu\.be\/|youtube\.com\/(?:embed\/|v\/|watch\?v=|watch\?.+&v=))((?:\w|-){11})(?:&list=(\S+))?$/.test(url);

        if (match) {
            Playlist
                .update(
                    {_id: id},
                    {$push: {videoURLs: url}},
                    {},
                    callback);
        }
    },
    addContributeToPlayList: function (id, user, name, callback) {
        Playlist.findOne({_id: id}, function (err, playlist) {
            if (playlist.creator == user) {
                Playlist
                    .update(
                        {_id: id},
                        {$push: {contributes: name}},
                        {},
                        callback);
            }
        });

    },
    addCommentToPlaylist: function (id, username, text, callback) {
        Playlist
            .update(
                {_id: id},
                {
                    $push: {
                        comments: {
                            creator: username,
                            text: text
                        }
                    }
                },
                {},
                callback);
    },
    getAll: function (user, page, pageSize, callback) {
        page = page || 1;
        pageSize = pageSize || 10;

        if (user) {
            Playlist
                .find({creator:user.username})
                .sort({
                    date: 'desc'
                })
                .limit(pageSize)
                .skip((page - 1) * pageSize)
                .exec(function (err, foundEvents) {
                    if (err) {
                        callback(err);
                        return;
                    }

                    Playlist.count().exec(function (err, numberOfEvents) {
                        var data = {
                            playlists: foundEvents,
                            currentPage: page,
                            pageSize: pageSize,
                            total: numberOfEvents
                        };

                        callback(err, data);
                    });
                })
        }
        else {
            Playlist
                .find({isPublic: true})
                .sort({
                    date: 'desc'
                })
                .limit(pageSize)
                .skip((page - 1) * pageSize)
                .exec(function (err, foundEvents) {
                    if (err) {
                        callback(err);
                        return;
                    }

                    Playlist.count({isPublic: true}).exec(function (err, numberOfEvents) {
                        var data = {
                            playlists: foundEvents,
                            currentPage: page,
                            pageSize: pageSize,
                            total: numberOfEvents
                        };

                        callback(err, data);
                    });
                })
        }
    }
};