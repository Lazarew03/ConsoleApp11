using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle
{
    internal class Vehicle
    {
        public Vehicle( string type )
        {
            
           
            Type = type;
           
        }

        public Vehicle() { }

         
        public string Type { get; set; }
       


        public override string ToString()
        {
            return $"Группа - Транспортное средство\n"+
                
             $"Тип - {Type}\n";
                
        }
    }
}
