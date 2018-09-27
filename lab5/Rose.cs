using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Rose : Flower, IPlant
    {
        public bool HasSpikes { get; set; } = true;


        public Rose(string name = "Rose", string color = "Red", bool hasSpikes = true) : base(name, color)
        {
            HasSpikes = hasSpikes;
        }


        void IPlant.Grow()
        {
            Console.WriteLine("Расту как растение так скозатб");
        }

        public override void Grow()
        {
            Console.WriteLine("Расту как цветок так скозатб");
        }

        public override string ToString()
        {
            return String.Format("{0} \nШипы: {1}", base.ToString(), HasSpikes.ToString());
        }

        public override void Bloom()
        {
            Console.WriteLine("Rose is blooming");
        }

    }
}
