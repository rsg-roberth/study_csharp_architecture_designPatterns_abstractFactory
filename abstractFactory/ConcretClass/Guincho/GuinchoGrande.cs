using abstractFactory.AbstractClass;
using abstractFactory.Enums;
using System;

namespace abstractFactory.ConcretClass
{
    public class GuinchoGrande : Guincho
    {
        public GuinchoGrande(Porte porte) : base(porte) { }

        public override void Socorrer(Veiculo veiculo) => Console.WriteLine("Socorrendo Carro Grande - Modelo " + veiculo.Modelo);        
    }
}
