using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarAndChain
{
    class ConstructorChain
    {
        public ConstructorChain(string name) : this(name, "I don't eat food, I am a robot...")
        {

        }
        public ConstructorChain(string name, string food)
        {
            User = name; ;
            FavoriteFood = food;
        }
        

        public string User { get; set; }
        public string FavoriteFood { get; set; }
    }
}
