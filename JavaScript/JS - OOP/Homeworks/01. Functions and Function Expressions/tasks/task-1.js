/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function sum(numbers) {
    var i,
        len = numbers.length,
        sumNumbers = 0,
        number;
    if (len === 0) {
        return null;
    }
    for (i = 0; i < len; i += 1) {
        number = +numbers[i];
        if (isNaN(number)) {
            throw new Error();
        }
        sumNumbers += number;
    }

    return sumNumbers;
}

module.exports = sum;
