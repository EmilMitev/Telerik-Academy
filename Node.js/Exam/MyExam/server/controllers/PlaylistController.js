var playlists = require('../data/playlists'),
    constants = require('../common/constants');


var CONTROLLER_NAME = 'playlist';

module.exports = {
    getPlaylists: function (req, res, next) {
        var user = req.user;
        var page = req.query.page;
        var pageSize = req.query.pageSize;

        playlists.getAll(user, page, pageSize, function(err, data){
            res.render(CONTROLLER_NAME + '/playlists-all', {
                data: data
            });
        });
    },
    getCreateContribute: function (req, res, next) {
        res.render(CONTROLLER_NAME + '/playlist-contribute-create');
    },
    postCreateContribute: function (req, res, next) {
        var id = req.params.id;
        var data = req.body;
        var name = data.name;
        var user = req.user;

        playlists.addContributeToPlayList(id, user.username, name, function (err, playlist) {
            if (err) {
                req.session.error = 'Failed to add contribute to playlist: ' + err;
                res.redirect('/playlist/details/' + id);
            }
            else {
                playlists.getById(id, function (err, playlist) {
                    if (err) {
                        req.session.error = 'Failed to load playlist: ' + err;
                        res.redirect('/playlist');
                    }
                    else {
                        res.render(CONTROLLER_NAME + '/playlist-details', {data: playlist});
                    }
                });
            }
        });
    },
    getCreateVideo: function (req, res, next) {
        res.render(CONTROLLER_NAME + '/playlists-video-create');
    },
    postCreateVideo: function (req, res, next) {
        var id = req.params.id;
        var data = req.body;
        var url = data.url;

        playlists.addVideoToPlayList(id, url, function (err, playlist) {
            if (err) {
                req.session.error = 'Failed to add video to playlist: ' + err;
                res.redirect('/playlist/details/' + id);
            }
            else {
                playlists.getById(id, function (err, playlist) {
                    if (err) {
                        req.session.error = 'Failed to load playlist: ' + err;
                        res.redirect('/playlist');
                    }
                    else {
                        res.render(CONTROLLER_NAME + '/playlist-details', {data: playlist});
                    }
                });
            }
        });
    },
    getCreateComment: function (req, res, next) {
        res.render(CONTROLLER_NAME + '/playlist-comment-create');
    },
    postCreateComment: function (req, res, next) {
        var id = req.params.id;
        var data = req.body;
        var text = data.text;
        var user = req.user;

        playlists.addCommentToPlaylist(id, user.user, text, function (err, playlist) {
            if (err) {
                req.session.error = 'Failed to add comment to playlist: ' + err;
                res.redirect('/playlist/details/' + id);
            }
            else {
                playlists.getById(id, function (err, playlist) {
                    if (err) {
                        req.session.error = 'Failed to load playlist: ' + err;
                        res.redirect('/playlist');
                    }
                    else {
                        res.render(CONTROLLER_NAME + '/playlist-details', {data: playlist});
                    }
                });
            }
        });
    },
    getById: function (req, res, next) {
        var id = req.params.id;

        playlists.getById(id, function (err, playlist) {
            if (err) {
                req.session.error = 'Failed to load playlist: ' + err;
                res.redirect('/playlist');
            }
            else {
                res.render(CONTROLLER_NAME + '/playlist-details', {data: playlist});
            }
        });
    }
    ,
    getCreate: function (req, res, next) {
        res.render(CONTROLLER_NAME + '/playlist-create', {categories: constants.categories});
    }
    ,
    postCreate: function (req, res, next) {
        var newPlaylist = req.body;
        var user = req.user;
        playlists.create(newPlaylist,
            {
                username: user.username
            },
            function (err, playlist) {
                if (err) {
                    req.session.error = 'Failed to add new playlist: ' + err;
                    res.redirect('/playlist/create');
                }
                else {
                    res.redirect('/playlist/details/' + playlist._id);
                }
            }
        );
    }
}
;