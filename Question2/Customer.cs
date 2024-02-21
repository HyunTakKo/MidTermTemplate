using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    internal class Customer
    {
        private string _firstName;
        private string _lastName;

        public Customer(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }

        public void DisplayNotification(string message)
        {
            Console.WriteLine($"Notification to {_firstName} {_lastName}: {message}");
        }
    }
}
