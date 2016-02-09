document.getElementById("results").innerHTML += getProperties(window) +
    getProperties(navigator) +
    getProperties(document);

function getProperties(obj) {
    var min = 0,
        max = 0;

    for (var property in obj) {
        if (!min) {
            min = property;
        }
        if (!max) {
            max = property;
        }

        if (property < min) {
            min = property;
        }

        if (property > max) {
            max = property;
        }
    }

    return '<h1>' + obj + '</h1>' +
        '<p>Min Property: ' + min + '</p>' +
        '<p>Max Property: ' + max + '</p>';
}