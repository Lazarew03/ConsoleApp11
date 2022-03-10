using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle
{
    internal class Express : Vehicle
    {
        public Express(string type, int speed) : base( type)
        {
            Speed = speed;
        }

        public Express() { }

        
        public int Speed { get; set; }
        public override string ToString()
        {
            return $"Группа -Экспресс \n" +
                $"Тип - {Type} \n" +
                $"Скорость - {Speed} км/ч\n";
        }
    }
}
