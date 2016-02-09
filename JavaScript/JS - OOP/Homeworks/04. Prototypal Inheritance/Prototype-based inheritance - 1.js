var animal = (function() {
    var animal = {
        init: function(name, age) {
            this.name = name;
            this.age = age;
            return this;
        },
        get name() {
            return this._name;
        },
        set name(value) {
            if (value.length < 3) {
                throw new Error();
            }
            this._name = value;
        },
        toString: function() {
            return this.name + ' ' + this.age;
        }
    };

    return animal;
}());

var cat = (function(parent) {
    var cat = Object.create(parent);

    Object.defineProperty(cat, 'init', {
        value: function(name, age, sleep) {
            parent.init.call(this, name, age);
            this.sleep = sleep;
            return this;
        }
    });
    // cat.init = function(name, age, sleep) {
    //     parent.init.call(this, name, age);
    //     this.sleep = sleep;
    //     return this;
    // };

    Object.defineProperty(cat, 'toString', {
        value: function() {
            var baseResult = parent.toString.call(this);
            return baseResult + ' ' + this.sleep;
        }
    });
    
    // cat.toString = function() {
    //     var baseResult = parent.toString.call(this);
    //     return baseResult + ' ' + this.sleep;
    // };

    return cat;
}(animal));

var someAnimal = Object.create(animal).init('pesho', 5);
console.log(someAnimal);
console.log(someAnimal.toString());

var someCat = Object.create(cat).init('Gosho', 20, true);
console.log(someCat);
console.log(someAnimal.toString());
console.log(someCat.toString());
