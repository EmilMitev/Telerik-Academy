function Person(fname, lname, age, gender) {
    this.firstName = fname;
    this.lastName = lname;
    this.age = age;
    this.gender = !!gender;
}

var array = [
    new Person('Emko', 'Peshkov', 25, false),
    new Person('Pesho', 'Shmatkata', 15, false),
    new Person('Igor', 'Dimitrov', 18, false),
    new Person('John', 'Kolev', 25, false),
    new Person('Teodor', 'Georgiev', 13, false),
    new Person('Blagovest', 'Chavdarov', 15, false),
    new Person('Anna', 'Ivanova', 29, true),
    new Person('Iliana', 'Simeonova', 45, true),
    new Person('Svetlana', 'Dragoeva', 56, true),
    new Person('Elica', 'Traykova', 8, true)
];

var females = array.filter(function(item) {
    return item.gender === true;
});

var avgFemaleAge = females.reduce(function (previousValue,currentValue) {
    return previousValue + currentValue.age;
},0) / females.length;

console.log(avgFemaleAge);