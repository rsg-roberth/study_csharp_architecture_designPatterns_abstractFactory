using abstractFactory.AbstractClass;
using abstractFactory.Enums;
using System;

namespace abstractFactory.ConcretClass
{
    public class GuinchoMedio : Guincho
    {
        public GuinchoMedio(Porte porte) : base(porte) { }

        public override void Socorrer(Veiculo veiculo) => Console.WriteLine("Socorrendo Carro Médio - Modelo " + veiculo.Modelo);        
    }
}
