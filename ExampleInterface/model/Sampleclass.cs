
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.model
{
    internal class Sampleclass: IControl, Isurface
    {
        public string Nome { get; set; }
        public string sobrenome { get; set; }
        public string cpf { get; set; }
        public string idade { get; set; }


        void IControl.paint(string cpf, string idade)
        {
            Console.WriteLine($"CPF {cpf} IDADE {idade}");
        }

        void Isurface.paint(string Nome, string sobrenome)
        {
            Console.WriteLine($"NOME {Nome} SobreNome {sobrenome}");

        }
    }
}

