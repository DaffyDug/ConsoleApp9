using System;
using System.Drawing;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {

            CARS car = new CARS("Toyota_supra", 324, 502, transmition.mechanic, Color.Orange, Body_Type.Cupe);
            CARS car_1 = new CARS("NISSAN GT-R 12", 260, 190, transmition.automatic, Color.White, Body_Type.Cupe);
            CARS car_2 = new CARS("BMW-M5", 300, 222, transmition.automatic, Color.Blue, Body_Type.Sedan);
            car.print_info();
            car_1.print_info();
            car_2.print_info();

        }
    }
}

public enum transmition
{
    automatic,
    mechanic
}
public enum Body_Type
{
    Cupe,
    Sedan,
    Hatchback,
    Station_wagon,
    SUV
}
public class CARS
{
    public string _BRAND;
    public int _MAX_SPEED;
    public int _HORSE_POWER;
    public transmition _transmition;
    public Color _COLOR;
    public Body_Type _BODY_TYPE;

    public CARS(string Brand, int MAX_speed, int HORSE_power, transmition Transmition, Color color, Body_Type body_type)
    {
        _BRAND = Brand;
        _MAX_SPEED = MAX_speed;
        _HORSE_POWER = HORSE_power;
        _transmition = Transmition;
        _COLOR = color;
        _BODY_TYPE = body_type;
    }
    public void print_info()
    {
        Console.Write("марка машины: " + _BRAND + '\n');
        Console.Write("максимальная скорость: " + _MAX_SPEED + '\n');
        Console.Write("лошадиные силы: " + _HORSE_POWER + '\n');
        Console.Write("коробка передач: " + _transmition + '\n');
        Console.Write("цвет: " + _COLOR + '\n');
        Console.Write("тип кузова: " + _BODY_TYPE + '\n');
        Console.WriteLine("**************************************************************" +'\n');
    }
}