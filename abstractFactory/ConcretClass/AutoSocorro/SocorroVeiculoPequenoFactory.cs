using abstractFactory.AbstractClass;
using abstractFactory.Enums;

namespace abstractFactory.ConcretClass
{
    public class SocorroVeiculoPequenoFactory : AutoSocorroFactory
    {
        public override Guincho CriarGuicho() => GuinchoCriador.Criar(Porte.Pequeno);

        public override Veiculo CriarVeiculo(string modelo, Porte porte) => VeiculoCriador.Criar(modelo, porte);        
    }
}
