using abstractFactory.AbstractClass;
using abstractFactory.ConcretClass;
using abstractFactory.Enums;
using System;
using System.Collections.Generic;

namespace abstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ExecucaoAbstractFactory.Executar();
        }
    }

    public class ExecucaoAbstractFactory
    {        

        public static void Executar()
        {
            var veiculosSocorro = new List<Veiculo>
            {
                VeiculoCriador.Criar("Celta", Porte.Pequeno),
                VeiculoCriador.Criar("Jetta", Porte.Medio),
                VeiculoCriador.Criar("BMX X6", Porte.Grande)
            };

            veiculosSocorro.ForEach(v => AutoSocorro.CriarAutoSocorro(v).RealizarAtendimento());

        }
    }
}
