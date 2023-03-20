namespace OOPs
{
    class Bike : MotorVehicle, customize
    {
        public Bike()
        {
            System.Console.WriteLine("It is a bike");
            setWheel(2);
            setgear(4);
        }

        public void modifySeat(string seat)
        {
            System.Console.WriteLine("This bike's seat is " + seat);
        }

        public void modifyEngine(int cc)
        {
            System.Console.WriteLine("This bike's engine is " + cc + " " + "cc");
        }

        public void setcolor(string col)
        {
            this.clour = col;
        }

        //Method Overriding
        public override void setModel(string modName)
        {
            this.model = modName;
        }

        internal void info(){
            System.Console.WriteLine("*******Details of your bike*******");
            System.Console.WriteLine("Model of this bike is " +model);
            System.Console.WriteLine("Colour of bike is " + clour);
            System.Console.WriteLine("Price of bike is " + price);
            System.Console.WriteLine("This bike can run on " + getFuelType());
            System.Console.WriteLine("It has {0} wheels",getWheel());
            System.Console.WriteLine("It has {0} gears",getgear());
        }
    }
}