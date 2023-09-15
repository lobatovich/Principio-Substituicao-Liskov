using System.Drawing;

namespace liskov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FormaGeometrica retangulo = new Retangulo(5, 3);
            FormaGeometrica quadrado = new Quadrado(4);

            Console.WriteLine($"Area do Retangulo:  {retangulo.Area()}");
            Console.WriteLine($"Area do Quadrado:   {quadrado.Area()}");
            Console.ReadLine();
        }
    }
}