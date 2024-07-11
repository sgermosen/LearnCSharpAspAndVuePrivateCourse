namespace ProgramsForLearning.HomeWork7
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        // Sobreescribir el método GetArea para calcular el área del círculo
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

}
