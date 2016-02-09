var Animal = (function() {
    function Animal(name, age) {
        this.name = name;
        this.age = age;
    }

    Animal.prototype.toString = function() {
        return this.name + ' ' + this.age;
    };

    Animal.prototype.eat = function() {
        return 'Eats...';
    };

    return Animal;
}());

var Cat = (function(parent) {
    function Cat(name, age, sleep) {
        parent.call(this, name, age);
        this.sleep = sleep;
    }

    Cat.prototype = parent.prototype;

    Cat.prototype.toString = function() {
        var baseResult = parent.prototype.toString.call(this);
        return baseResult + ' ' + this.sleep;
    };

    return Cat;
}(Animal));

var animal = new Animal('Gosho', 15);
console.log(animal);
console.log(animal.toString());

var cat = new Cat('Pesho', 10, true);
console.log(cat);
console.log(cat.toString());
console.log(cat.eat());
