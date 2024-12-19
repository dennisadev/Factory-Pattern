using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class NA : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Invladi selection, your not dirving.");
        }
    }
}
