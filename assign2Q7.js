/* 7)write a Student class in type script in following data member constructor
roll-no
name
marks[]//number
Percentage
Grade
write a method to display info and calculate  result and assign grade as per percentage*/
var Student = /** @class */ (function () {
    function Student(no, sname, marks) {
        this.rollno = no;
        this.sname = sname;
        this.marks = marks;
    }
    Student.prototype.display = function () {
        console.log("Student roll no is: " + this.rollno);
        console.log("Student name no is: " + this.sname);
        console.log("Student marks are:");
        for (var m in this.marks) {
            console.log(this.marks[m]);
        }
    };
    Student.prototype.Percentage = function () {
        var sum = 0;
        var l = this.marks.length;
        for (var i = 0; i < l; i++) {
            sum += this.marks[i];
        }
        var per = sum / l;
        return per;
    };
    Student.prototype.grade = function () {
        var percentage = this.Percentage();
        var grade;
        if (percentage < 100 && percentage >= 80) {
            grade = "A";
        }
        else if (percentage < 80 && percentage >= 60) {
            grade = "B";
        }
        else if (percentage < 60 && percentage >= 35) {
            grade = "c";
        }
        else {
            grade = "Fail";
        }
        return grade;
    };
    return Student;
}());
var ma = new Array(60, 90, 67, 68);
var s = new Student(1, "priya", ma);
console.log("Student Details are");
s.display();
console.log("Student obtained Percentage is: " + s.Percentage());
console.log("Student obtained grade is: " + s.grade());
