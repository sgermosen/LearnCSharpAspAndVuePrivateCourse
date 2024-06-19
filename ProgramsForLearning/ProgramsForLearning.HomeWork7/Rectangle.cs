namespace ProgramsForLearning.HomeWork7
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        // Sobreescribir el método GetArea para calcular el área del rectángulo
        public override double GetArea()
        {
            return Width * Height;
        }

        // Sobrecargar el método GetArea para calcular el área en diferentes unidades
        public double GetArea(string unit)
        {
            double area = Width * Height;
            if (unit == "cm")
            {
                return area; // Área en cm²
            }
            else if (unit == "m")
            {
                return area / 10000; // Convertir cm² a m²
            }
            else
            {
                throw new ArgumentException("Unit not recognized.");
            }
        }
    }

}
