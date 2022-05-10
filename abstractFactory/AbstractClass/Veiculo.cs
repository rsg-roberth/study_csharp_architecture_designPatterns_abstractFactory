using abstractFactory.Enums;

namespace abstractFactory.AbstractClass
{
    public abstract class Veiculo
    {
        protected Veiculo(string modelo, Porte porte)
        {
            Modelo = modelo;
            Porte = porte;
        }

        public string Modelo { get; set; }
        public Porte Porte { get; set; }
    }
}
