var arrayOfNumbers = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20],
    valueToBeFound = 12,
    index = 0,
    left = 0,
    right = arrayOfNumbers.Length,
    middle;

while (!!true) {
    middle = (left + right) / 2;
    if (arrayOfNumbers[middle] == valueToBeFound) {
        index = middle;
        break;
    } else if (arrayOfNumbers[middle] > valueToBeFound) {
        left -= 1;
    } else if (arrayOfNumbers[middle] < valueToBeFound) {
        right += 1;
    }
}

console.log('Element that you search is on ' + index + ' index.'); //The counting start from 0
