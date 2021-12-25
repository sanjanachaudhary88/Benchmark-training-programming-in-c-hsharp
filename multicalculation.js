"use strict";
exports.__esModule = true;
exports.Circle = exports.Square = exports.Rectangle = void 0;
var Rectangle = /** @class */ (function () {
    function Rectangle() {
    }
    Rectangle.prototype.rectangle = function (length1, bredth) {
        var ar = length1 * bredth;
        console.log("Area of rectangle is " + ar);
    };
    return Rectangle;
}());
exports.Rectangle = Rectangle;
var Square = /** @class */ (function () {
    function Square() {
    }
    Square.prototype.square = function (side) {
        var ar = side * side;
        console.log("Area of square is " + ar);
    };
    return Square;
}());
exports.Square = Square;
var Circle = /** @class */ (function () {
    function Circle() {
    }
    Circle.prototype.circle = function (radius) {
        var ar = 3.14 * radius * radius;
        console.log("Area of circle is " + ar);
    };
    return Circle;
}());
exports.Circle = Circle;
