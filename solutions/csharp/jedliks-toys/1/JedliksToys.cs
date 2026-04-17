class RemoteControlCar
{
    public int Distance { get; set; }
    public int Battery { get; set; } = 100;
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {Distance} meters";
    }

    public string BatteryDisplay()
    {
        return Battery == 0 ? "Battery empty" : $"Battery at {Battery}%";
    }

    public void Drive()
    {
        if (Battery != 0)
        {
            Distance += 20;
            Battery--;
        }
    }
}
