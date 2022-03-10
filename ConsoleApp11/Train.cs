using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle
{
    internal class Train:Vehicle
    {
        public Train(  string type, int carriagecapacity) : base( type)
        {
            Сarriagecapacity = carriagecapacity;
        }

        public Train() { }

        
        public int Сarriagecapacity { get; set; }
        public override string ToString()
        {
            return $"Группа - Поезд\n" +
                $"Тип - {Type} \n" +
                $"Вместимость вагона - {Сarriagecapacity} человек\n";
        }
    }
}
