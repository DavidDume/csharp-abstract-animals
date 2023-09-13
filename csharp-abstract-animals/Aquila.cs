using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Aquila : Animale, IVolante
    {
        public override void Verso()
        {
            Console.WriteLine("Strido");
        }
        public override void CosaMangi()
        {
            Console.WriteLine("Carne");
        }
        public void FaiVolare()
        {
            Console.WriteLine("STO VOLANDO");
        }
    }
}
