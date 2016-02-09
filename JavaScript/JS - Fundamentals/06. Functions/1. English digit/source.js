function LastDigit(number){
	var lastDigit,
		lastDigitAsString = '';
	lastDigit = +number%10;
	switch(lastDigit){
		case 0: lastDigitAsString = 'zero'; break;
		case 1:lastDigitAsString = 'one'; break;
		case 2:lastDigitAsString = 'two'; break;
		case 3:lastDigitAsString = 'three'; break;
		case 4:lastDigitAsString = 'four'; break;
		case 5:lastDigitAsString = 'five'; break;
		case 6:lastDigitAsString = 'six'; break;
		case 7:lastDigitAsString = 'seven'; break;
		case 8:lastDigitAsString = 'eight'; break;
		case 9:lastDigitAsString = 'nine'; break;
	}
	return lastDigitAsString;
}

console.log(LastDigit(512));
console.log(LastDigit(1024));
console.log(LastDigit(12309));