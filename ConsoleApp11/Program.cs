using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("Наземное");
            Car car = new Car("BMW","Легковое",2007 );
          Express express = new Express("Рельсовое", 160);
            Train train= new Train("Рельсовое", 54);


            Console.WriteLine(vehicle.ToString());
            Console.WriteLine(car.ToString());
            Console.WriteLine(express.ToString());
            Console.WriteLine(train.ToString());

            Console.ReadKey();
        }
    }
}