using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Delfino : Animale, INuotante
    {
        public override void Verso()
        {
            Console.WriteLine("Fischio");
        }
        public override void CosaMangi()
        {
            Console.WriteLine("Pesce");
        }

        void INuotante.Nuota() { Console.WriteLine("STO NUOTANDO"); }
    }
}
