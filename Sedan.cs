//INTERFACE
//INHERITANCE
using System;

namespace sanam_maharjan
{
    //IMPLEMENTING INTERFACE
    /* class Sedan : IAutomobile
    {
        public string LicensePlate
        {get; }
        public double Speed
        {get; }
        public int Wheels
        {get; }
        public void Honk()
        {
        Console.WriteLine("HONK!");
        }
    } */

    //OTHER METHODS, FIELD, PROPERTIES CAN BE ADDED IN A CLASS WITH INTERFACE
    //INTERFACE SAYS WHAT A CLASS MUST HAVE, BUT DOESNOT SAY WHAT A CLASS MUST NOT HAVE
    /* class Sedan : IAutomobile
    {
        public string LicensePlate
        { get; }

        public double Speed
        { get;
        private set; }

        public int Wheels
        { get; }
        
        public void Honk()
        {
        Console.WriteLine("HONK!");
        }
        public Sedan(double speed)
        {
            Speed = speed;
            LicensePlate = Tools.GenerateLicensePlate();
            Wheels = 4;
        }
        public void SpeedUp()
        {
            Speed = Speed + 5;
        }
        public void SlowDown()
        {
            Speed = Speed - 5;
        }
    } */

    //ACCESS INHERITED MEMBERS WITH PROTECTED
    /* class Sedan : Vehicle, IAutomobile
    {
        public Sedan(double speed)
        {
            Speed = speed;
            LicensePlate = Tools.GenerateLicensePlate();
            Wheels = 4;
        }    
    } */

    //ACCESS INHERITED MEMBERS WITH base
    /* class Sedan : Vehicle, IAutomobile
    {
        public Sedan(double speed) : base(speed)
        {
        }
    } */

    //MAKE INHERITED MEMBERS ABSTRACT
    /* class Sedan : Vehicle, IAutomobile
    {
        public Sedan(double speed) : base(speed)
        {
            Wheels = 4;
        }
        
        public override string Describe()   //ABSTRACT IS FOLLOWED BY OVERRIDE
        {
            return $"This Sedan is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
        }

    } */
}