using abstractFactory.AbstractClass;
using abstractFactory.Enums;
using System;

namespace abstractFactory.ConcretClass
{
    public class VeiculoCriador
    {
        public static Veiculo Criar(string modelo, Porte porte)
        {
            switch (porte)
            {
                case Porte.Pequeno: return new VeiculoPequeno(modelo, porte);                    
                case Porte.Medio: return new VeiculoMedio(modelo, porte);                    
                case Porte.Grande: return new VeiculoGrande(modelo, porte);                    
                default: throw new ApplicationException("Porte de veiculo desconhecido");
            }
        }
    }
}
