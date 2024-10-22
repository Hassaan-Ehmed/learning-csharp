using System;

namespace HospitalManagementCLI
{

    class Program
    {
        static void Main(string[] args) {

            Person person1 = new Person();
            
            Console.WriteLine("Before Aleez > "+person1.Name);

            person1.Name = "Aleez";

            Console.WriteLine("Hello HMS!!!"+person1.Name);
        }
    }

}