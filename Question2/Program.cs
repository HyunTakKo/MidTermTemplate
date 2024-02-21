using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Car object with initial quantity as 0
            Car car = new Car("BMW", 25000, 0);

            // Create two Customer objects and make them subscribe to the car
            Customer customer1 = new Customer("John", "Doe");
            Customer customer2 = new Customer("Jane", "Smith");

            car.StatusChanged += customer1.DisplayNotification;
            car.StatusChanged += customer2.DisplayNotification;

            // Set a new price for the car and notify the customers
            car.SetPrice(28000);

            // Set a new quantity for the car and notify the customers only when quantity is more than 0
            car.UpdateQty(5);

            // Remove one customer from the waiting list (unsubscribe)
            car.StatusChanged -= customer1.DisplayNotification;

            // Set a new price for the car and notify the customers
            car.SetPrice(30000);

            Console.ReadLine();
        }
    }
}
