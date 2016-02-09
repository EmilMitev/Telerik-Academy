var number = 273,
	numberWithWords = '';

if (number < 0 || number > 999) {
    console.log("Invalid number!");
} else if (number < 10) {
    switch (number) {
        case 0: numberWithWords = 'Zero'; break;
        case 1: numberWithWords = 'One'; break;
        case 2: numberWithWords = 'Two'; break;
        case 3: numberWithWords = 'Three'; break;
        case 4: numberWithWords = 'Four'; break;
        case 5: numberWithWords = 'Five'; break;
        case 6: numberWithWords = 'Six'; break;
        case 7: numberWithWords = 'Seven'; break;
        case 8: numberWithWords = 'Eight'; break;
        case 9: numberWithWords = 'Nine'; break;
    }

} else if (number < 20) {
    switch (number) {
        case 10: numberWithWords = 'Ten'; break;
        case 11: numberWithWords = 'Eleven'; break;
        case 12: numberWithWords = 'Twelve'; break;
        case 13: numberWithWords = 'Thirteen'; break;
        case 14: numberWithWords = 'Fourteen'; break;
        case 15: numberWithWords = 'Fifteen'; break;
        case 16: numberWithWords = 'Sixteen'; break;
        case 17: numberWithWords = 'Seventeen'; break;
        case 18: numberWithWords = 'Eighteen'; break;
        case 19: numberWithWords = 'Nineteen'; break;
    }

} else if (number < 100) {
    switch (number / 10|0) {
        case 2: numberWithWords = 'Twenty '; break;
        case 3: numberWithWords = 'Thirty '; break;
        case 4: numberWithWords = 'Fourty '; break;
        case 5: numberWithWords = 'Fifty '; break;
        case 6: numberWithWords = 'Sixty '; break;
        case 7: numberWithWords = 'Seventy '; break;
        case 8: numberWithWords = 'Eighty '; break;
        case 9: numberWithWords = 'Ninety '; break;
    }
    switch (number % 10) {
        case 1: numberWithWords = numberWithWords + 'one'; break;
        case 2: numberWithWords = numberWithWords + 'two'; break;
        case 3: numberWithWords = numberWithWords + 'three'; break;
        case 4: numberWithWords = numberWithWords + 'four'; break;
        case 5: numberWithWords = numberWithWords + 'five'; break;
        case 6: numberWithWords = numberWithWords + 'six'; break;
        case 7: numberWithWords = numberWithWords + 'seven'; break;
        case 8: numberWithWords = numberWithWords + 'eight'; break;
        case 9: numberWithWords = numberWithWords + 'nine'; break;
    }
} else if (number < 1000) {
    switch (number / 100|0) {
        case 1: numberWithWords = 'One hundred '; break;
        case 2: numberWithWords = 'Two hundred '; break;
        case 3: numberWithWords = 'Tree hundred '; break;
        case 4: numberWithWords = 'Four hundred '; break;
        case 5: numberWithWords = 'Five hundred '; break;
        case 6: numberWithWords = 'Six hundred '; break;
        case 7: numberWithWords = 'Seven hundred '; break;
        case 8: numberWithWords = 'Eight hundred '; break;
        case 9: numberWithWords = 'Nine hundred '; break;
    }
    if (number % 100 < 20) {
        switch (number % 100) {
            case 01:  numberWithWords = numberWithWords + 'and one'; break;
            case 02:  numberWithWords = numberWithWords + 'and two'; break;
            case 03:  numberWithWords = numberWithWords + 'and three'; break;
            case 04:  numberWithWords = numberWithWords + 'and four'; break;
            case 05:  numberWithWords = numberWithWords + 'and five'; break;
            case 06:  numberWithWords = numberWithWords + 'and six'; break;
            case 07:  numberWithWords = numberWithWords + 'and seven'; break;
            case 08:  numberWithWords = numberWithWords + 'and eight'; break;
            case 09:  numberWithWords = numberWithWords + 'and nine'; break;
            case 10:  numberWithWords = numberWithWords + 'and ten'; break;
            case 11:  numberWithWords = numberWithWords + 'and eleven'; break;
            case 12:  numberWithWords = numberWithWords + 'and twelve'; break;
            case 13:  numberWithWords = numberWithWords + 'and thirteen'; break;
            case 14:  numberWithWords = numberWithWords + 'and fourteen'; break;
            case 15:  numberWithWords = numberWithWords + 'and fifteen'; break;
            case 16:  numberWithWords = numberWithWords + 'and sixteen'; break;
            case 17:  numberWithWords = numberWithWords + 'and seventeen'; break;
            case 18:  numberWithWords = numberWithWords + 'and eighteen'; break;
            case 19:  numberWithWords = numberWithWords + 'and nineteen'; break;
        }
    } else {
        switch (number / 10 % 10|0) {
            case 2: numberWithWords = numberWithWords + 'and twenty '; break;
            case 3: numberWithWords = numberWithWords + 'and thirty '; break;
            case 4: numberWithWords = numberWithWords + 'and fourty '; break;
            case 5: numberWithWords = numberWithWords + 'and fifty '; break;
            case 6: numberWithWords = numberWithWords + 'and sixty '; break;
            case 7: numberWithWords = numberWithWords + 'and seventy '; break;
            case 8: numberWithWords = numberWithWords + 'and eighty '; break;
            case 9: numberWithWords = numberWithWords + 'and ninety '; break;
        }
        if (number / 10 % 10|0) {
            switch (number % 10) {
                case 1:  numberWithWords = numberWithWords + 'one'; break;
                case 2:  numberWithWords = numberWithWords + 'two'; break;
                case 3:  numberWithWords = numberWithWords + 'three'; break;
                case 4:  numberWithWords = numberWithWords + 'four'; break;
                case 5:  numberWithWords = numberWithWords + 'five'; break;
                case 6:  numberWithWords = numberWithWords + 'six'; break;
                case 7:  numberWithWords = numberWithWords + 'seven'; break;
                case 8:  numberWithWords = numberWithWords + 'eight'; break;
                case 9:  numberWithWords = numberWithWords + 'nine'; break;
            }
        }
    }
}

console.log(numberWithWords);
