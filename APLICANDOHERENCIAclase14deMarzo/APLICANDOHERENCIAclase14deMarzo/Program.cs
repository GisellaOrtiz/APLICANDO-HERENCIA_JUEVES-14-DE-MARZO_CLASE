using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APLICANDOHERENCIAclase14deMarzo
{
    class Program
    {
       static SUMA clsi;
        RESTA clr;

        static void Main(string[] args)
        {
            clsi.ValorA1 = 5;
            clsi.ValorB = 3;
            clsi.sumOP();
            Console.ReadKey();
        }

        public Program()
        {
            clsi = new SUMA();
            clr = new RESTA();
        }
    }
}
