/*In this exercise you'll be playing around with a remote controlled car, which you've finally saved enough money for to buy.
Cars start with full (100%) batteries. Each time you drive the car using the remote control, it covers "x" meters and drains "x/10" percent of the battery.
The remote controlled car has a fancy LED display that shows two bits of information:
The total distance it has driven, displayed as: "Driven {METERS} meters".
The remaining battery charge, displayed as: "Battery at {PERCENTAGE}%".
If the battery is at 0%, you can't drive the car anymore and the battery display will show "Battery empty".
You have six tasks, each of which will work with remote controlled car instances.
1. Buy a brand-new remote controlled car
Implement the (static) RemoteControlCar.Buy() method to return a brand-new remote controlled car instance:
RemoteControlCar car = RemoteControlCar.Buy();
2.Display the distance driven
Implement the RemoteControlCar.DistanceDisplay() method to return the distance as displayed on the LED display:
var car = RemoteControlCar.Buy();
car.DistanceDisplay();
3.Display the battery percentage
Implement the RemoteControlCar.BatteryDisplay() method to return the battery percentage as displayed on the LED display:
var car = RemoteControlCar.Buy();
car.BatteryDisplay();
4.Update the number of meters driven when driving
Implement the RemoteControlCar.Drive() method that updates the number of meters driven:
var car = RemoteControlCar.Buy();
car.Drive(20);
car.Drive(10);
car.DistanceDisplay();
5.Update the battery percentage when driving
Update the RemoteControlCar.Drive() method to update the battery percentage:
var car = RemoteControlCar.Buy();
car.Drive(25);
car.Drive(15);
car.BatteryDisplay();
6.Prevent driving when the battery is drained
Update the RemoteControlCar.Drive() method to not increase the distance driven nor decrease the battery percentage when the battery is drained (at 0%):
car.BatteryDisplay();
// => "Battery empty"*/

namespace Advanc.Featu.Extra.Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}