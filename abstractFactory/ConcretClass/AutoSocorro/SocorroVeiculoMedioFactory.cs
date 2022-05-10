using abstractFactory.AbstractClass;
using abstractFactory.Enums;

namespace abstractFactory.ConcretClass
{
    public class SocorroVeiculoMedioFactory : AutoSocorroFactory
    {
        public override Guincho CriarGuicho() => GuinchoCriador.Criar(Porte.Medio);

        public override Veiculo CriarVeiculo(string modelo, Porte porte) => VeiculoCriador.Criar(modelo, porte);        
    }
}
