var min,
    max,
    len,
    arr = [1, 2, 3, 4, 12, 23, 43, 23, 2];

max = min = arr[0];

for (var i = 0, len = arr.length; i < len; i += 1) {
    if (arr[i] > max) {
        max = arr[i];
    }
    if (arr[i] < min) {
        min = arr[i];
    }
}

console.log("Min: " + min);
console.log("Max: " + max);
