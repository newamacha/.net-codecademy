using System;

namespace sanam_maharjan
{
    //IMPLEMENTING INTERFACE
    /* class Truck : IAutomobile
    {
        public string LicensePlate
        { get; }

        public double Speed
        { get; private set; }

        public int Wheels
        { get; }
        
        public double Weight
        { get; }

        public Truck(double speed, double weight)
        {
            Speed = speed;
            LicensePlate = Tools.GenerateLicensePlate();
            Weight = weight;

            if (weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }
        
        public void Honk()
        {
            Console.WriteLine("HONK!");
        }

        public void SpeedUp()
        {
            Speed += 5;
        }

        public void SlowDown()
        {
            Speed -= 5;
        }

    } */

    //ACCESS INHERITED MEMBER WITH PROTECTED
    /* class Vehicle
    {
        public string LicensePlate
        { get; protected set;}
        public double Speed
        { get; protected set; }
        public int Wheels
        { get; protected set; }
        public void SpeedUp()
        {
            Speed += 5;
        }
        public void SlowDown()
        {
            Speed -= 5;
        }  
        public void Honk()
        {
            Console.WriteLine("HONK!");
        }
    } */


    //ABOVE CODE IS SIMPLIFIED BY USING INHERITANCE
    /* class Truck : Vehicle, IAutomobile
    {
        public double Weight
        { get; }

        public Truck(double speed, double weight)
        {
            Speed = speed;
            LicensePlate = Tools.GenerateLicensePlate();
            Weight = weight;

            if (weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }
    } */

    //ACCESS INHERITED MEMBER WITH base
    /* class Truck : Vehicle, IAutomobile
    { 
        public double Weight
        { get; }
        public Truck(double speed, double weight) : base(speed)
        {     
        }
    } */

    //MAKE INHERITED MEMBERS ABSTRACT
    /* class Truck : Vehicle, IAutomobile
    { 
        public double Weight
        { get; }

        public Truck(double speed, double weight) : base(speed)
        {
            Weight = weight;

            if (weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }

        public override string Describe()
        {
            return $"This Truck is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
        }

    } */
}