//INHERITANCE
/* using System;

namespace LearnInheritance
{
  class Bicycle : Vehicle
  { */
    /* public Bicycle(double Speed) : base(Speed)
    {
      Wheels = 2;
    }
    public override void SpeedUp()      //OVERRIDE => TELLS THIS CLASS IS MODIFIED EVEN THOUGH IT IS DEFINED IN PARENT CLASS
    {                                   //OVERRIDE IS PRESENT IN CHILD CLASS
      Speed += 5;                       //VIRTUAL IS PRESENT IN PARENT CLASS
      if(Speed > 15)                    //BOTH ARE REQUIRED AT THE SAME TIME
      {
        Speed = 15;
      }
    }
    public override void SlowDown()
    {
      Speed -= 5;
      if(Speed < 0)
      {
        Speed = 0;
      }
    } */

    //MAKE INHERITED MEMBER ABSTRACT
    /* public Bicycle(double speed) : base(speed)
    {
      Wheels = 2;
    }

    public override void SpeedUp()
    {
      Speed += 5;
      
      if (Speed > 15)
      {
        Speed = 15;
      }
    }

    public override void SlowDown()
    {
      Speed -= 5;

      if (Speed < 0)
      {
        Speed = 0;
      }
    }

    public override string Describe()       //ABSTRACT IS FOLLOWED BY OVERRIDE
    {
      return $"This Bicycle is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
    } */
 /*  }
} */