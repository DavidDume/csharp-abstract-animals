using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public abstract class Animale
    {

        public abstract void Verso();
        public abstract void CosaMangi();
        public void Dormi()
        {
            Console.WriteLine("ZZZZZZZ");
        }
    }
}
