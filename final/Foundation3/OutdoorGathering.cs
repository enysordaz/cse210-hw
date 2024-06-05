using System;

public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, string date, string time, Address addres, string weather) : base(title, description, date, time, addres)
    {
        _weather = weather;
    }

    public string GetWeather()
    { 
        return _weather;
    }

    public string GenerateWeatherStatement()
    {
        return "The weahter will be: " + _weather + ".";
    }

    public string ReturnEventType()
    {
        return "Outdoor Gathering";
    }

    public string GenerateDetailedOutdoorGathering()
    {
        string detailed = "";
        string weatherStatement = GenerateWeatherStatement();

        detailed += GenerateStandard() + "\n";
        detailed += "Statement of weather: " + weatherStatement;
        return detailed;
    }

    public string GenerateShortOutdoorGathering()
    {
        string shortOG = "";
        string eventType = ReturnEventType();

        shortOG += "Event Type: " + eventType + "\n";
        shortOG += GenerateShort();
        return shortOG;
    }
}