using System;

namespace HomeWork
{
    
class Car
    {
        public string carName;
        public int carSpeed;
         public void SayAbout()
        {
            Console.WriteLine($"{carName} is going {carSpeed} km/h");
        }
        public void speedIncrease(int increase)
        {
            carSpeed=carSpeed+increase;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("--------TEST SPEED--------");
            Car car1=new Car();
            car1.carName="MERCADES E-CLASS";
            car1.carSpeed=0;
             int i;
            for( i=0;i<=10;i++)
            {
                car1.speedIncrease(25);
                car1.SayAbout();
            }
            Console.WriteLine();
            Console.WriteLine("Max speed of this model is: "+(i*25)+" km/h.");
            Console.ReadKey();
        }
    }
}
