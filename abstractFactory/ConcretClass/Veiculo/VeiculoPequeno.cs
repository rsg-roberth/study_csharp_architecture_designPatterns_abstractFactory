using abstractFactory.AbstractClass;
using abstractFactory.Enums;

namespace abstractFactory.ConcretClass
{
    public class VeiculoPequeno : Veiculo
    {
        public VeiculoPequeno(string modelo, Porte Porte) : base(modelo, Porte) { }        
    }
}
