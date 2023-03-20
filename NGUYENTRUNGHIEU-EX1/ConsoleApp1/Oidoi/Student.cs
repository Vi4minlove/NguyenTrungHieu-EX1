using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Oidoi
{
    internal class Student
    {
        //khai báo trường
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Class { get; set; }
        public double Mark1 { get; set; }
        public double Mark2 { get; set; }
        public double Mark3 { get; set; }
        public double Average { get; set; }
        public void Display()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Gender: " + Gender);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Date of birth: " + DateOfBirth);
            Console.WriteLine("Class: " + Class);
            Console.WriteLine("Mark1: " + Mark1);
            Console.WriteLine("Mark2: " + Mark2);
            Console.WriteLine("Mark3: " + Mark3);
            Console.WriteLine("Average: " + Average);
        }
    }
}
