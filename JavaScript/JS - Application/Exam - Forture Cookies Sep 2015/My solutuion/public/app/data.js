var data = (function () {
    const LOCAL_STORAGE_USERNAME_KEY = 'signed-in-user-username',
        LOCAL_STORAGE_AUTHKEY_KEY = 'signed-in-user-auth-key';

    /* Users */
    function register(user) {
        var reqUser = {
            username: user.username,
            passHash: CryptoJS.SHA1(user.username + user.password).toString()
        };

        return jsonRequester.post('api/users', {
            data: reqUser
        }).then(function (resp) {
            var user = resp.result;
            return {
                username: resp.result.username
            };
        });
    }

    function signIn(user) {
        var reqUser = {
            username: user.username,
            passHash: CryptoJS.SHA1(user.username + user.password).toString()
        };

        var options = {
            data: reqUser
        };

        return jsonRequester.put('api/auth', options)
            .then(function (resp) {
                var user = resp.result;
                localStorage.setItem(LOCAL_STORAGE_USERNAME_KEY, user.username);
                localStorage.setItem(LOCAL_STORAGE_AUTHKEY_KEY, user.authKey);
                return user;
            });
    }

    function signOut() {
        var promise = new Promise(function (resolve, reject) {
            localStorage.removeItem(LOCAL_STORAGE_USERNAME_KEY);
            localStorage.removeItem(LOCAL_STORAGE_AUTHKEY_KEY);
            resolve();
        });
        return promise;
    }

    function hasUser() {
        return !!localStorage.getItem(LOCAL_STORAGE_USERNAME_KEY) && !!localStorage.getItem(LOCAL_STORAGE_AUTHKEY_KEY);
    }

    function usersGet() {
        return jsonRequester.get('api/users')
            .then(function (res) {
                return res.result;
            });
    }

    // Cookies
    function getAllCookie() {
        return jsonRequester.get('api/cookies')
            .then(function (res) {
                return res.result;
            });
    }

    function getMyCookies() {
        var options = {
            headers: {
                'x-auth-key': localStorage.getItem(LOCAL_STORAGE_AUTHKEY_KEY)
            }
        };

        return jsonRequester.get('api/my-cookie', options)
            .then(function(res) {
                return res.result;
            });
    }

    return {
        users: {
            signIn,
            signOut,
            register,
            hasUser,
            get: usersGet
        },
        cookies: {
            get: getAllCookie,
            getMyCookies: getMyCookies
        }
    };
}());