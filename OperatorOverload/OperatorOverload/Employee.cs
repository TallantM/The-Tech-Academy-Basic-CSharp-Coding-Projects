using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    public class Employee : Person
    {
        public int ID { get; set; }
    }

    public static Employee operator== (Employee employee)
    {
        
    }
}
