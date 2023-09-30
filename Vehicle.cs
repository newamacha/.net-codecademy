//INHERITANCE
//SUPERCLASS
using System;

namespace sanam_maharjan
{
  /* class Vehicle
  { */
    /* public double Weight
    {get; set;}
    public string LicensePlate
    { get; private set; }

    public double Speed
    { get; private set; }

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
    public Vehicle(double speed)
    {
      Speed = speed;
      LicensePlate = Tools.GenerateLicensePlate();
      Wheels = 4;
    }

    public Vehicle(double speed, double weight)
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
    } */

    //OVERRIDE INHERITED MEMBERS
    /* public string LicensePlate
    { get; private set; }
    public double Speed
    { get; protected set; }
    public int Wheels
    { get; protected set; }
    public Vehicle(double speed)
    {
      Speed = speed;
      LicensePlate = Tools.GenerateLicensePlate();
    }
    public virtual void SpeedUp()       VIRTUAL => TELLS THAT THIS CLASS IS MODIFIED IN SUBCLASS
    {
      Speed += 5;
    }
    public virtual void SlowDown()
    {
      Speed -= 5;
    }  
    public void Honk()
    {
      Console.WriteLine("HONK!");
    } */

  /* } */

    //MAKING INHERITED MEMBERS ABSTRACT => ABSTRACT IS USED SO THAT EACH SUBCLASS HAVE DIFFERENT DEFINITION BUT IT MUST EXIST IN EACH SUBCLASS
  /* abstract class Vehicle        //CLASS SHOULD BE MADE ABSTRACT
  {
    public string LicensePlate
    { get; private set; }

    public double Speed
    { get; protected set; }

    public int Wheels
    { get; protected set; }

    public Vehicle(double speed)
    {
      Speed = speed;
      LicensePlate = Tools.GenerateLicensePlate();
    }

    public virtual void SpeedUp()
    {
      Speed += 5;
    }

    public virtual void SlowDown()
    {
      Speed -= 5;
    }
    
    public void Honk()
    {
      Console.WriteLine("HONK!");
    }

    public abstract string Describe();      //METHOD SHOULD BE ADDED IN SUPERCLASS

  } */
}