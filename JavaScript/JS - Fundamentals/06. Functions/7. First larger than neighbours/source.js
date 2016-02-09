var array = [
        0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20
    ],
    find = CheckTheNeighbours(array);

if (find > 0) {
    console.log('The number in position ' + find + ' is Larger than neighbours');
} else {
    console.log("There’s no such element");
}

function CheckTheNeighbours(array) {
    var i,
        len = array.length;

    for (i = 0; i < len; i += 1) {
        if (i === 0) {
            if (array[i] > array[i + 1]) {
                return i;
            }
        } else if (i == array.Length) {
            if (array[i] > array[i - 1]) {
                return i;
            }
        } else {
            if ((array[i] > array[i + 1]) && (array[i] > array[i - 1])) {
                return i;
            }
        }
    }
    return -1;
}
