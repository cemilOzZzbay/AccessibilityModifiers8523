using AccessibilityModifiers8523;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicAccessibilityModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dog dog = new Dog();
            Car car = new Car() 
            { 
                id1_puclic = 1, 
                Id1_public = 1 
            };
            car.DriveTheCar(); 
        }
    }
}
