using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Passerotto : Animale, IVolante
    {
        public override void Verso()
        {
            Console.WriteLine("Cri cri");
        }
        public override void CosaMangi()
        {
            Console.WriteLine("Vermi");
        }

        public void Vola()
        {
            Console.WriteLine("STO VOLANDO");
        }
    }
}
