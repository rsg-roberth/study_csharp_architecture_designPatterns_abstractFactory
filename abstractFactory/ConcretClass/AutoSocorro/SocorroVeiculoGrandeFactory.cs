using abstractFactory.AbstractClass;
using abstractFactory.Enums;

namespace abstractFactory.ConcretClass
{
    public class SocorroVeiculoGrandeFactory : AutoSocorroFactory
    {
        public override Guincho CriarGuicho() => GuinchoCriador.Criar(Porte.Grande);

        public override Veiculo CriarVeiculo(string modelo, Porte porte) => VeiculoCriador.Criar(modelo, porte);        
    }
}
