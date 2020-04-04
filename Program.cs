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
            
        }
    }
}
