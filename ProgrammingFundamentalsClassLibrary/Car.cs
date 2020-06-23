using System;

namespace ProgrammingFundamentalsClassLibrary
{
    public class Car
    {
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Car()
        {
            Model = "nothing yet";
            Price = 0;
        }

        public Car(string model, decimal price)
        {
            Model = model;
            Price = price;
        }
    }
}
