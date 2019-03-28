using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Employee<T> : Person
    {
        public int ID { get; set; }

        public List<T> Things { get; set; }

    }
}
