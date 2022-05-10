using abstractFactory.AbstractClass;
using abstractFactory.Enums;
using System;

namespace abstractFactory.ConcretClass
{
    public class GuinchoPequeno : Guincho
    {
        public GuinchoPequeno(Porte porte) : base(porte) { }

        public override void Socorrer(Veiculo veiculo) => Console.WriteLine("Socorrendo Carro Pequeno - Modelo " + veiculo.Modelo);        
    }
}
