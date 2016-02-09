var auth = require('./auth'),
    controllers = require('../controllers');

module.exports = function (app) {
    app.get('/register', controllers.users.getRegister);
    app.post('/register', controllers.users.postRegister);

    app.get('/login', controllers.users.getLogin);
    app.post('/login', auth.login);
    app.get('/logout', auth.logout);
    app.get('/profile', auth.isAuthenticated, controllers.users.getProfile);
    app.post('/profile', auth.isAuthenticated, controllers.users.updateProfile);

    app.get('/playlist', controllers.playlists.getPlaylists);
    app.get('/playlist/create', auth.isAuthenticated, controllers.playlists.getCreate);
    app.get('/playlist/video/add/:id', auth.isAuthenticated, controllers.playlists.getCreateVideo);
    app.post('/playlist/video/add/:id', auth.isAuthenticated, controllers.playlists.postCreateVideo);
    app.get('/playlist/comment/add/:id', auth.isAuthenticated, controllers.playlists.getCreateComment);
    app.post('/playlist/comment/add/:id', auth.isAuthenticated, controllers.playlists.postCreateComment);
    app.get('/playlist/contribute/add/:id', auth.isAuthenticated, controllers.playlists.getCreateContribute);
    app.post('/playlist/contribute/add/:id', auth.isAuthenticated, controllers.playlists.postCreateContribute);
    app.get('/playlist/details/:id', controllers.playlists.getById);
    app.post('/playlist/create', auth.isAuthenticated, controllers.playlists.postCreate);

    app.get('/', function (req, res) {
        res.render('index');
    });

    app.get('*', function (req, res) {
        res.render('index');
    });
};