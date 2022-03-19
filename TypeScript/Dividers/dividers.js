"use strict";
exports.__esModule = true;
function dividers(number) {
    var numCount, numDiv = 0;
    numDiv = number;
    while (numDiv > 0) {
        numCount = number % numDiv;
        if (numCount == 0) {
            console.log(numDiv);
        }
        numDiv--;
    }
    return;
}
exports["default"] = dividers;
