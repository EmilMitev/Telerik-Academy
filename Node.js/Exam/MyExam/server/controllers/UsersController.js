var encryption = require('../utilities/encryption');
var users = require('../data/users');

var CONTROLLER_NAME = 'users';

module.exports = {
    getRegister: function (req, res, next) {
        res.render(CONTROLLER_NAME + '/register')
    },
    postRegister: function (req, res, next) {
        var newUserData = req.body;

        if (newUserData.password != newUserData.confirmPassword) {
            req.session.error = 'Passwords do not match!';
            res.redirect('/register');
        }
        else {
            newUserData.salt = encryption.generateSalt();
            newUserData.hashPass = encryption.generateHashedPassword(newUserData.salt, newUserData.password);

            users.create(newUserData, function (err, user) {
                if (err) {
                    req.session.error = 'Failed to register new user: ' + err;
                    res.redirect('/register');
                }
                else {
                    req.logIn(user, function (err) {
                        if (err) {
                            res.status(400);
                            return res.send({reason: err.toString()}); // TODO:
                        }
                        else {
                            res.redirect('/');
                        }
                    })
                }
            });
        }
    },
    getLogin: function (req, res, next) {
        res.render(CONTROLLER_NAME + '/login');
    },
    getProfile: function (req, res, next) {
        var userInfo = req.user;
        res.render(CONTROLLER_NAME + '/userProfile', userInfo);
    },
    updateProfile: function (req, res, next) {
        var newUserData = req.body;
        var user = req.user;
        newUserData._id = user._id;

        if (!newUserData.password) { // if he don't change password
            newUserData.salt = user.salt;
            newUserData.hashPass = user.hashPass;

            users.update(newUserData, function (err, user) {
                if (err) {
                    req.session.error = 'Failed to update user data: ' + err;
                    res.redirect('/profile');
                }
                else {
                    req.session.success = 'Your profile is updated!';
                    res.redirect('/profile');
                }
            });
        }
        else {
            if (newUserData.password != newUserData.confirmPassword) {
                req.session.error = 'Passwords do not match!';
                res.redirect('/profile');
            }
            else {
                newUserData.salt = encryption.generateSalt();
                newUserData.hashPass = encryption.generateHashedPassword(newUserData.salt, newUserData.password);

                users.update(newUserData, function (err, user) {
                    if (err) {
                        req.session.error = 'Failed to update user data: ' + err;
                        res.redirect('/profile');
                    }
                    else {
                        req.session.success = 'Your profile is updated!';
                        res.redirect('/profile');
                    }
                });
            }
        }
    }
};