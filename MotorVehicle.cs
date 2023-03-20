namespace OOPs
{
    class MotorVehicle

    {

        private int wheel, gear;
        private string fuelType = "";
        public string clour = "",model="";
        public float price;

        public MotorVehicle()
        {
            System.Console.WriteLine("This is a template for motor vehicle");
        }

        //Encapsulation
        public void setWheel(int i)
        {
            this.wheel = i;
        }

        public int getWheel()
        {
            return wheel;
        }

        public void setgear(int i)
        {
            this.gear = i;
        }

        public int getgear()
        {
            return gear;
        }

        public void setFuelType(string f)
        {
            this.fuelType = f;
        }

        public string getFuelType()
        {
            return fuelType;
        }

        public virtual void setModel(string modelType){
            this.model=modelType;
        }
    }

    public interface customize{
        public void modifySeat(string seat);
        public void modifyEngine(int cc);
    }
}