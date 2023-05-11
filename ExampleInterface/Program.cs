using ConsoleApp1.Interfaces;
using ConsoleApp1.model;

namespace teste
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Sampleclass sample = new Sampleclass();

            IControl control = sample;
            Isurface surface = sample;


            sample.Nome = "Andre";
            sample.sobrenome = "Vitor";
            sample.cpf = "123456";
            sample.idade = "20";

            surface.paint(sample.Nome, sample.sobrenome);
            control.paint(sample.cpf, sample.idade);
        }
    }
}