
internal class Car
{
    public string Make { get; private set; }
    public string Model { get; private set; }
    public int Year { get; private set; }
    public string Color { get; private set; }
    public bool Sunroof { get; private set; }
    public bool GPS { get; private set; }

    public Car(string make, string model, int year, string color, bool sunroof, bool gps)
    {
        Make = make;
        Model = model;
        Year = year;
        Color = color;
        Sunroof = sunroof;
        GPS = gps;
    }


    public override string ToString()
    {
        return $"{Year} {Make} {Model} - Color: {Color}, Sunroof: {Sunroof}, GPS: {GPS}";
    }
}

// Usage
