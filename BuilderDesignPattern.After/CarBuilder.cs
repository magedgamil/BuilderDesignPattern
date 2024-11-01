

namespace BuilderDesignPattern.After;
internal class CarBuilder
{
    private string? _make;
    private string? _model;
    private int _year;
    private string? _color;
    private bool _sunroof;
    private bool _gps;

    public CarBuilder SetMake(string make)
    {
        _make = make;
        return this;
    }
    public CarBuilder SetModel(string model)
    {
        _model = model;
        return this;
    }
    public CarBuilder SetYear(int year)
    {
        _year = year;
        return this;
    }
    public CarBuilder SetColor(string color)
    {
        _color = color;
        return this;
    }
    public CarBuilder SetSunroof(bool sunroof)
    {
        _sunroof = sunroof;
        return this;
    }
    public CarBuilder SetGPS(bool gps)
    {
        _gps = gps;
        return this;
    }
    public Car Build()
    {
        return new Car(_make, _model, _year, _color, _sunroof, _gps);
    }

}
