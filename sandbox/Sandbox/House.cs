public class House
{
    private List<Room> rooms;

    public House()
    {
        rooms = new List<Room>();
    }

    public void AddRoom(Room room)
    {
        rooms.Add(room);
    }

    public void TurnOnAllLights()
    {
        foreach (var room in rooms)
        {
            var lights = room.Devices.OfType<SmartLight>();
            foreach (var light in lights)
            {
                light.TurnOn();
            }
        }
    }

    public void TurnOffAllLights()
    {
        foreach (var room in rooms)
        {
            var lights = room.Devices.OfType<SmartLight>();
            foreach (var light in lights)
            {
                light.TurnOff();
            }
        }
    }
}