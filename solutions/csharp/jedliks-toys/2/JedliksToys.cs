class RemoteControlCar
{
    public int battery = 100;
    public int distance = 0;
    public static RemoteControlCar Buy()
    {
        RemoteControlCar car = new RemoteControlCar();
        return car;
        
    }
    public string DistanceDisplay()
    {
        return $"Driven {distance} meters";
    }

    public string BatteryDisplay()
    {
        if(battery <= 0)
        {
            return "Battery empty";
        }
        else
        return $"Battery at {battery}%";
    }

    public void Drive()
    {
        
        if(battery > 0)
        {
            battery -= 1;
            distance += 20;
        }
        else
        {
            battery = 0;
            distance += 0;
        }
    }
}
