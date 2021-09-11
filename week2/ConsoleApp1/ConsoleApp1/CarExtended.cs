using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class Car
    {
        public void Drive(ref double km)
        {
            double usedFuel = km * 0.01;
            AddFuel(-usedFuel);
        }
    }
}
