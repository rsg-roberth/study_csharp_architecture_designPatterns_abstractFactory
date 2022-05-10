using abstractFactory.AbstractClass;
using System;

namespace abstractFactory.ConcretClass
{
    public class AutoSocorro
    {
        private readonly Veiculo _veiculo;
        private readonly Guincho _guincho;

        public AutoSocorro(AutoSocorroFactory factory, Veiculo veiculo)
        {
            _veiculo = factory.CriarVeiculo(veiculo.Modelo, veiculo.Porte);
            _guincho = factory.CriarGuicho();
        }

        public void RealizarAtendimento()
        {
            _guincho.Socorrer(_veiculo);
        }

        public static AutoSocorro CriarAutoSocorro(Veiculo veiculo)
        {
            switch (veiculo.Porte)
            {
                case Enums.Porte.Pequeno: return new AutoSocorro(new SocorroVeiculoPequenoFactory(), veiculo);                    
                case Enums.Porte.Medio: return new AutoSocorro(new SocorroVeiculoMedioFactory(), veiculo);                    
                case Enums.Porte.Grande: return new AutoSocorro(new SocorroVeiculoGrandeFactory(), veiculo);                    
                default: throw new ApplicationException("Não foi possível identificar o veículo");                    
            }
        }
    }
}
