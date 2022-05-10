using abstractFactory.AbstractClass;
using abstractFactory.Enums;
using System;

namespace abstractFactory.ConcretClass
{
    public class GuinchoCriador
    {
        public static Guincho Criar(Porte porte)
        {
            switch (porte)
            {
                case Porte.Pequeno: return new GuinchoPequeno(porte);                    
                case Porte.Medio: return new GuinchoMedio(porte);                    
                case Porte.Grande: return new GuinchoGrande(porte);                    
                default: throw new ApplicationException("Porte de guincho desconhecido");                    
            }
        }        
    }
}
