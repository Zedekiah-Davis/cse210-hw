public class Room
{
    public string Name { get; private set; }
    private List<SmartDevice> devices;

    public Room(string name)
    {
        Name = name;
        devices = new List<SmartDevice>();
    }

    public void AddDevice(SmartDevice device)
    {
        devices.Add(device);
    }

    public void TurnOnAllDevices()
    {
        foreach (var device in devices)
        {
            device.TurnOn();
        }
    }

    public void TurnOffAllDevices()
    {
        foreach (var device in devices)
        {
            device.TurnOff();
        }
    }

    public void ReportAllItemsAndStatus()
    {
        Console.WriteLine($"Items in {Name}:");
        foreach (var device in devices)
        {
            Console.WriteLine($"{device.Name} - {(device.IsOn ? "On" : "Off")}");
        }
    }

    public void ReportAllItemsOn()
    {
        var onDevices = devices.Where(device => device.IsOn);
        Console.WriteLine($"Items on in {Name}:");
        foreach (var device in onDevices)
        {
            Console.WriteLine(device.Name);
        }
    }

    public void ReportLongestOnDevice()
    {
        var longestOnDevice = devices.OrderByDescending(device => (DateTime.Now - device.StartTime).TotalMinutes).FirstOrDefault();
        if (longestOnDevice != null)
        {
            Console.WriteLine($"Longest on device in {Name}: {longestOnDevice.Name}");
        }
        else
        {
            Console.WriteLine($"No devices in {Name}");
        }
    }
}