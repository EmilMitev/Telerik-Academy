var vehicle = (function() {
    var vehicle = {};

    Object.defineProperties(vehicle, {
        init: {
            value: function(brand) {
                this.brand = brand;
                return this;
            }
        },
        move: {
            value: function() {
                return this.brand + ' is moving...';
            }
        }
    });

    // vehicle.init = function(brand) {
    //     this.brand = brand;
    //     return this;
    // };

    // vehicle.move = function() {
    //     return this.brand + ' is moving...';
    // };

    return vehicle;
}());

var car = (function(parent) {
    var car = Object.create(parent);

    Object.defineProperty(car, 'wheels', {
        get: function() {
            return this._wheels;
        },
        set: function(value) {
            if (value > 4) {
                throw new Error();
            }
            this._wheels = value;
        }
    });

    Object.defineProperty(car, 'init', {
        value: function(brand, wheels) {
            parent.init.call(this, brand);
            this.wheels = wheels;
            return this;
        }
    });

    //car.init = function(brand, wheels){
    //    parent.init.call(this, brand);
    //    this.wheels = wheels;
    //    return this;
    //};

    Object.defineProperty(car, 'move', {
        value: function() {
            return parent.move.call(this) + ' With ' + this.wheels + ' wheels!';
        }
    });

    //car.move = function(){
    //    return parent.move.call(this) + ' With ' + this.wheels + ' wheels!';
    //};

    return car;
}(vehicle));

var someVehicle = Object.create(vehicle).init('BMW');
console.log(someVehicle);
console.log(someVehicle.move());

var someCar = Object.create(car).init('Audi', 4);
console.log(someCar);
console.log(someCar.move());
