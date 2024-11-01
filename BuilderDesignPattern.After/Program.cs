using BuilderDesignPattern.After;

//var car = new Car("Toyota", "Camry", 2023, "Blue", true, false);
var car = new CarBuilder()
            .SetMake("Toyota")
            .SetYear(2023)
            .SetColor("Blue")
            .SetGPS(false)
            .SetSunroof(true)
            .SetModel("Camry")
            .Build();
                          
Console.WriteLine(car);

