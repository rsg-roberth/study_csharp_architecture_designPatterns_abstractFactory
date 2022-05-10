using abstractFactory.AbstractClass;
using abstractFactory.Enums;

namespace abstractFactory.ConcretClass
{
    public class VeiculoGrande: Veiculo
    {
        public VeiculoGrande(string modelo, Porte Porte) : base(modelo, Porte) { }        
    }
}
