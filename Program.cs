using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoalSatuConsoleApp_SERA
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Value Type");
            ValueType.Point point1 = new ValueType.Point(1, 2);
            ValueType.Point point2 = point1;

            Console.WriteLine($"point1: ({point1.X}, {point1.Y})");
            Console.WriteLine($"point2: ({point2.X}, {point2.Y})");

            point1.X = 10;
            point1.Y = 20;
            Console.WriteLine($"point1: ({point1.X}, {point1.Y})");
            Console.WriteLine($"point2: ({point2.X}, {point2.Y})");



            Console.WriteLine("Reference Type");
            ReferenceType.Person person1 = new ReferenceType.Person("John", 25);
            ReferenceType.Person person2 = person1;

            Console.WriteLine($"person1: {person1.Name}, {person1.Age} years old");
            Console.WriteLine($"person2: {person2.Name}, {person2.Age} years old");

            person1.Name = "Rudi";
            person1.Age = 30;

            Console.WriteLine($"person1: {person1.Name}, {person1.Age} years old");
            Console.WriteLine($"person2: {person2.Name}, {person2.Age} years old");
        }
    }
}
