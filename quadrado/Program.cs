using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            retangulo p1 = new retangulo();
            Console.WriteLine("calculo de area");

            //leitura de dados do retangulo
            Console.WriteLine("informe o valor da altura: ");
            p1.Vertical = int.Parse(Console.ReadLine());
            Console.WriteLine("informe o valor da base: ");
            p1.Orizontal = int.Parse(Console.ReadLine());
            p1.exibir();
            Console.ReadLine();
        }
    }
}
