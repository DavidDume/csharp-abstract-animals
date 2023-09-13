// See https://aka.ms/new-console-template for more information
using csharp_abstract_animals;

Cane cane = new Cane();

cane.CosaMangi();
cane.Dormi();   

Aquila aquila = new Aquila();
Delfino delfino = new Delfino();

void FaiNuotare(INuotante animale) {
    animale.Nuota();
}
void FaiVolare(IVolante animale)
{
    animale.Vola();
}

FaiVolare(aquila);
FaiNuotare(delfino);