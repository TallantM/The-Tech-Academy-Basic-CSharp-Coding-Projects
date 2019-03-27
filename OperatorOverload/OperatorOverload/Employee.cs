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


        public static bool operator== (Employee employeeA, Employee employeeB)
        {
            if (employeeA.ID == employeeB.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator!= (Employee employeeA, Employee employeeB)
        {
            if (employeeA.ID != employeeB.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
