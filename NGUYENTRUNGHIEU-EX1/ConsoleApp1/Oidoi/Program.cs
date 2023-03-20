using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oidoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestStudent go = new TestStudent();
            while (true)
            {
                Console.WriteLine("     Please select an option:");
                Console.WriteLine("     =======================================================");
                Console.WriteLine("       1. Input information <input details for a student>.");
                Console.WriteLine("       2. Sorting student ascending by average mark.");
                Console.WriteLine("       3. Display all the student list.");
                Console.WriteLine("       4. Search Student by Name.");
                Console.WriteLine("       5. Delete Student by student ID.");
                Console.WriteLine("       6. Exit program.");
                Console.WriteLine("     =======================================================");
                Console.Write("     Option: ");
                int key = System.Int32.Parse(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("\n Add Student.");
                        go.Nhap();
                        Console.WriteLine("\nDone!");
                        break;
                    //case 2:
                    //    Console.WriteLine("\n Shoting by Average");
                    //    go.SortByAverage();
                    //    go.ShowStudent(TestStudent.)
                    case 6:
                        Console.WriteLine("\n Exit!");
                        return;
                }
            }
        }
    }
}
