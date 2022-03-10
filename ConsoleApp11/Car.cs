using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle
{
    internal class Car : Vehicle
    {
        public Car( string company, string type, int year) : base( type)
        {
            Company = company;
            Year = year;
        }

        public Car() { }

        public int Year { get; set; }
        public string Company { get; set; }
        public override string ToString()
        {
            return $"Группа - Машина\n" +
                
                $"Марка - {Company}\n" +
                $"Тип  - {Type} \n" +
                $"Год  - {Year} г.\n";
        }
    }
}
