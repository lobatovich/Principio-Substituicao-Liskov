using System;



namespace liskov
{
    class Quadrado : FormaGeometrica
    {
        public double Lado { get; set; }

        public Quadrado(double lado)
        {
            this.Lado = lado;
        }

        public override double Area()
        {
            return Lado * Lado;
        }
    }
}
