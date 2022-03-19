"use strict";
exports.__esModule = true;
var dividers_1 = require("./dividers");
(function () {
    var stdin = process.openStdin();
    var number = 0;
    stdin.addListener("data", function (number) {
        number = parseInt(number.toString().trim());
        (0, dividers_1["default"])(number);
        process.stdin.destroy();
    });
})();
