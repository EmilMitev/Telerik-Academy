function Person(fname, lname, age, gender) {
    this.firstName = fname;
    this.lastName = lname;
    this.age = age;
    this.gender = !!gender;
}

var array = [
    new Person('Emko', 'Peshkov', 25, false),
    new Person('Pesho', 'Shmatkata', 15, false),
    new Person('Igor', 'Dimitrov', 8, false),
    new Person('John', 'Kolev', 25, false),
    new Person('Teodor', 'Georgiev', 13, false),
    new Person('Blagovest', 'Chavdarov', 15, false),
    new Person('Anna', 'Ivanova', 29, true),
    new Person('Iliana', 'Simeonova', 45, true),
    new Person('Svetlana', 'Dragoeva', 56, true),
    new Person('Elica', 'Traykova', 81, true)
];

if (!Array.prototype.find) {
    Array.prototype.find = function(func) {
        var i, len = this.length;
        for (i = 0; i < len; i += 1) {
            if (func(this[i], i, this)) {
                return this[i];
            }
        }
    };
}

var youngster =
    array.sort(function(max, min) {
        return max.age - min.age;
    }).find(function(person) {
        return !person.gender;
    });

console.log('Youngest male person: ' + youngster.firstName, youngster.lastName, youngster.age);
