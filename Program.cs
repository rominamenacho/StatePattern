using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Switch _s = new Switch();

            _s.Presionar();
            _s.Presionar();
            _s.Presionar();
            _s.Presionar();
            _s.Presionar();
            _s.Presionar();

            Console.ReadKey();
        }
    }
}
