using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    sealed class Paper : IPlant
    {
        public void Grow()
        {
            Console.WriteLine("I'm already dead");
        }

        public override string ToString()
        {
            return String.Format("I'm fucking dead! Get off!");
        }
    }
    
}
