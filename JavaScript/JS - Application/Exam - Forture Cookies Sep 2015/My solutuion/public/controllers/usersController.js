var usersController = function () {

    //function all(context) {
    //    var users;
    //    data.users.get()
    //        .then(function (resUsers) {
    //            users = resUsers;
    //            return templates.get('users');
    //        })
    //        .then(function (template) {
    //            context.$element().html(template(users));
    //            $('.btn-add-friend').on('click', function () {
    //                var id = $(this).parents('.user-box').attr('data-id');
    //                //data.friends.sentRequest(id);
    //            });
    //        });
    //}

    function isValidUsername(username) {
        var regex = /^[a-zA-Z0-9_.]+$/;


        if (username.length < 6 || username.length > 30) {
            toastr.error('Username has length between 6 and 30 symbols!');
            return false;
        }

        if (!regex.test(username)) {
            toastr.error("Can contain only Latin letters, digits and the characters '_' and '.'");
            return false;
        }

        return true;
    }

    function register(context) {
        templates.get('register')
            .then(function (template) {
                context.$element().html(template());

                $('#btn-register').on('click', function () {
                    var user = {
                        username: $('#tb-reg-username').val(),
                        password: $('#tb-reg-pass').val()
                    };


                    if (isValidUsername(user.username)) {
                        data.users.register(user)
                            .then(function () {
                                toastr.success('User is registered!');
                                context.redirect('#/');
                                document.location.reload(true);
                            })
                    }
                });
            });
    }

    return {
        //all: all,
        register: register
    };
}();