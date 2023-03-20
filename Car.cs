namespace OOPs
{
    class Car : MotorVehicle
    {
        public Car()
        {
            System.Console.WriteLine("This is a car template");
            setWheel(4);
            setgear(6);
        }

        public void modifySeat(string seat)
        {
            System.Console.WriteLine("This car's seat is " + seat);
        }

        public void modifyEngine(int cc)
        {
            System.Console.WriteLine("This car's engine is " + cc + " " + "cc");
        }

        public void setcolor(string col)
        {
            this.clour = col;
        }

        //Method Overloading
        public void setFuelType(string f1, string f2)
        {
            System.Console.WriteLine("This car can run on both {0} and {1}", f1, f2);
        }

       //Method Overriding
        public override void setModel(string modName)
        {
            this.model = modName;
        }

        internal void info()
        {
            System.Console.WriteLine("*******Details of your car*******");
            System.Console.WriteLine("Model of this car is " +model);
            System.Console.WriteLine("Colour of car is " + clour);
            System.Console.WriteLine("Price of car is " + price);
            System.Console.WriteLine("This car can run on " + getFuelType());
            System.Console.WriteLine("It has {0} wheels",getWheel());
            System.Console.WriteLine("It has {0} gears",getgear());
        }
    }
}
