using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            List<Vehicle> vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Car car1 = new Car() { HasTrunk = true, Make = "Toyota", Model = "Highlander", Year = 2018 };
            Motorcycle motorcycle1 = new Motorcycle() { HasCart = true, Year = 2006, Model = "Cruiser", Make = "Harley Davidson" };
            Vehicle vehicle1 = new Car() { Year = 2010, Make = "Honda", Model = "Civic", HasTrunk = true };
            Vehicle vehicle2 = new Car() { Year = 1998, Make = "Subaru", Model = "Outback", HasTrunk = true };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(car1);
            vehicles.Add(motorcycle1);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Year}");
                Console.WriteLine($"{vehicle.Make}");
                Console.WriteLine($"{vehicle.Model}");
                Console.WriteLine();
            }

            // Call each of the drive methods for one car and one motorcycle
            
            #endregion            
            Console.ReadLine();
        }
    }
}
