using System;

class Program
{
    static void Main(string[] args) {
        SmartLight light1 = new SmartLight("Living Room Light");
        SmartLight light2 = new SmartLight("Bedroom Light");
        SmartHeater heater = new SmartHeater("Living Room Heater");
        SmartTV tv = new SmartTV("Living Room TV");

        Room livingRoom = new Room("Living Room");
        livingRoom.AddDevice(light1);
        livingRoom.AddDevice(heater);
        livingRoom.AddDevice(tv);

        Room bedroom = new Room("Bedroom");
        bedroom.AddDevice(light2);

        House house = new House();
        house.AddRoom(livingRoom);
        house.AddRoom(bedroom);

        livingRoom.TurnOnAllDevices();
        livingRoom.ReportAllItemsAndStatus();
        livingRoom.ReportAllItemsOn();
        livingRoom.ReportLongestOnDevice();

        livingRoom.TurnOffAllDevices();
    }
}