var array = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 10, 13, 14, 15, 16, 17, 18, 19],
    position = 11,
    isTrue = CheckTheNeighbours(array, position);
if (isTrue) {
    console.log('The number in position ' + position + ' is Larger than neighbours');
} else {
    console.log('The number in position ' + position + ' is NOT Larger than neighbours');
}



function CheckTheNeighbours(array, position) {
    if (position === 0) {
        if (array[position] > array[position + 1]) {
            return false;
        }
    } else if (position === array.Length) {
        if (array[position] > array[position - 1]) {
            return false;
        }
    } else {
        if (!(array[position] > array[position + 1] && (array[position] > array[position - 1]))) {
            return false;
        }
    }
    return true;
}
