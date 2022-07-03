using System;

public class Car_Parking_Calculator
{
    public static void Main(string[] args)
    {
        Vehicle veh = new Vehicle();

        Console.WriteLine("For Bike Customer ");
        Bike bike = new Bike();
        bike.Calculator();

        Console.WriteLine();

        Console.WriteLine("For Car Customer ");
        Car car = new Car();
        car.Calculator();

        Console.WriteLine();

        Console.WriteLine("For Bus Customer");
        Bus bus = new Bus();
        bus.Calculator();
    }
}
public class Vehicle
{
    public string vehicleName;
    public void Calculator()
    {
        double x;
        double charge = 0;
        Console.WriteLine("Enter hours to calculate charges");
        Console.WriteLine();
        x = Convert.ToDouble(Console.ReadLine());
        if (x > 0 && x <= 24)
        {
            if (x <= 3)
            {
                charge = 2;

            }
            else if (x > 19)
            {
                charge = 10;

            }
            else if (x > 3)
            {
                charge = 2 + (x - 3) * (0.5);

            }
            Console.WriteLine("Total charge for " + x + " hour" + ": " + "$" + charge);
        }
        else
        {
            Console.WriteLine("Vehicle cannot be parked more for more than 24 hours, Sorry");
        }
    }
}
public class Bike : Vehicle
{
    public void Calculator()
    {
        double charge = 0;
        double x;
        Console.Write("Enter hours to calculate charges");
        Console.WriteLine();
        x = Convert.ToDouble(Console.ReadLine());
        if (x > 0 && x <= 24)
        {
            if (x <= 3)
            {
                charge = 2;

            }
            else if (x > 19)
            {
                charge = 10;

            }
            else if (x > 3)
            {
                charge = 2 + (x - 3) * (0.5);

            }
            Console.WriteLine("Total charge for " + x + " hour" + ": " + "$" + charge);
        }
        else
        {
            Console.WriteLine("Vehicle cannot be parked more for more than 24 hours, Sorry");
        }
    }
}
public class Car : Vehicle
{
    public void Calculator()
    {
        double charge = 0;
        double x;
        Console.Write("Enter hours to calculate charges");
        Console.WriteLine();
        x = Convert.ToDouble(Console.ReadLine());
        if (x > 0 && x <= 24)
        {
            if (x <= 3)
            {
                charge = 4;

            }
            else if (x > 19)
            {
                charge = 20;

            }
            else if (x > 3)
            {
                charge = 4 + (x - 3) * (1);

            }
            Console.WriteLine("Total charge for " + x + " hour" + ": " + "$" + charge);
        }
        else
        {
            Console.WriteLine("Vehicle cannot be parked more for more than 24 hours, Sorry");
        }
    }
}
public class Bus : Vehicle
{
    public void Calculator()
    {
        double charge = 0;
        double x;
        Console.Write("Enter hours to calculate charges");
        Console.WriteLine();
        x = Convert.ToDouble(Console.ReadLine());
        if (x > 0 && x <= 24)
        {
            if (x <= 3)
            {
                charge = 6;

            }
            else if (x > 19)
            {
                charge = 30;

            }
            else if (x > 3)
            {
                charge = 6 + (x - 3) * (1.5);

            }
            Console.WriteLine("Total charge for " + x + " hour" + ": " + "$" + charge);
        }
        else
        {
            Console.WriteLine("Vehicle cannot be parked more for more than 24 hours, Sorry");
        }
    }
}