function login() {

    let username = $("#username").val();
    let password = $("#password").val();

    let parametriMancanti = 0;

    if (username == "") {
        toastr.warning("Inserire username", "Attenzione!");
        parametriMancanti++;
    }

    if (password == "") {
        toastr.warning("Inserire password", "Attenzione!");
        parametriMancanti++;
    }

    if (parametriMancanti == 0) {

        $.ajax({
            url: "../Amministratore/Login",
            type: "post",
            data: {
                username: username,
                password: password
            },
            success: function (result) {
                toastr.success("stai per essere reindirizzato alla dashboard", "Accesso effettuato!");
                setTimeout(() => {
                    document.location.href = "../Dashboard";
                }, 3000);
            },
            error: function () {
                toastr.error("Username o password errati", "Attenzione!");
            }
        });

    }

}