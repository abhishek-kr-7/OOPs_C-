using System;

namespace OOPs
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike b1 = new Bike();
            b1.setcolor("Silver");
            b1.setFuelType("Petrol");
            b1.price = 76000f;
            b1.setModel("K10");

            //Calling parent class method creating reference variable
            MotorVehicle m1 = b1;
            m1.setModel("Sports");

            // b1.info();
            b1.modifySeat("Single");
            b1.modifyEngine(250);

            Car c1 = new Car();
            c1.setcolor("Blue");
            c1.setFuelType("Petrol", "Electricity");
            c1.price = 2500000f;

            Car c2 = new Car();
            c2.setModel("Nexon");
            c2.setcolor("Grey");
            c2.setFuelType("Diesel");
            c2.price = 1400000f;
            c2.info();
        }
    }
}