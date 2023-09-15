using System;



namespace liskov
{
    class Retangulo : FormaGeometrica
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura)
        {
            this.Largura = largura;
            this.Altura = altura;
        }

        public override double Area()
        {
            return Largura * Altura;
        }
    }
}
