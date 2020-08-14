using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    class ArmorSuite
    {
        public virtual void Initialize()
        {
            Console.WriteLine("Armored");
        }

    }

    class IronMan : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Repulsor Rays Armed");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArmorSuite armorsuite = new ArmorSuite();
            armorsuite.Initialize();
            IronMan ironman = new IronMan();
            ironman.Initialize();
        }
    }
}
