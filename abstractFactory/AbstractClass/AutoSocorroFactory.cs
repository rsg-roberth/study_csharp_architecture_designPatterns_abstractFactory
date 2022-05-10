using abstractFactory.Enums;

namespace abstractFactory.AbstractClass
{
    public abstract class AutoSocorroFactory
    {
        public abstract Guincho CriarGuicho();
        public abstract Veiculo CriarVeiculo(string modelo, Porte porte);
    }
}
