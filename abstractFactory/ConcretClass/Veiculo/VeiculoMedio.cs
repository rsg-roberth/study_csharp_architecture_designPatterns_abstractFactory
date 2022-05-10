using abstractFactory.AbstractClass;
using abstractFactory.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactory.ConcretClass
{
    public class VeiculoMedio: Veiculo
    {
        public VeiculoMedio(string modelo, Porte Porte) : base(modelo, Porte) { }        
    }
}
