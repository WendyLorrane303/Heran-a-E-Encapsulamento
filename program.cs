using System;

namespace Herança_E_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Circulo 1");
            Circulo circ1 = new Circulo(3.0);

            // acessando métodos get
            Console.WriteLine("Raio:\t\t{0:0.0}", circ1.Raio);
            Console.WriteLine("Área:\t\t{0:0.0}", circ1.Area);
            Console.WriteLine("Perímetro\t{0:0.0}", circ1.Perimetro);

            // acessando método set
            // atualização automática
            // da área e perímetro
            circ1.Raio = 9.0;

            Console.WriteLine("==============================");
            Console.WriteLine("Circulo 2");
            Circulo circ2 = new Circulo(6.0);

            // acessando métodos get
            Console.WriteLine("Raio:\t\t{0:0.0}", circ1.Raio);
            Console.WriteLine("Área:\t\t{0:0.0}", circ1.Area);
            Console.WriteLine("Perímetro\t{0:0.0}", circ1.Perimetro);

            // acessando método set
            // atualização automática
            // da área e perímetro
            circ2.Raio = 2.0;

            Console.WriteLine("==============================");
            Console.WriteLine("Retangulo 1");
            Retangulo nu1 = new Retangulo(6.0,2.0);

            // acessando métodos get
            Console.WriteLine("Largura:\t\t{0:0.0}", nu1.Largura);
            Console.WriteLine("Área:\t\t{0:0.0}", nu1.Altura);

            //acessando método set
            // atualização automática
            // da área e perímetro
            nu1.Largura = 1.5;
            nu1.Altura = 2.0;

            


            
        }
    }
}
