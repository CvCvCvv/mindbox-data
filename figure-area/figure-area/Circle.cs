namespace FigureArea
{
    public class Circle : Figure
    {
        private double _radius;
        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(message: "Error: radius cannot be less than or equal to 0");
                }
                _radius = value;
            }
        }
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException(message: "Error: radius cannot be less than or equal to 0");
            }
            _radius = radius;
        }
        public override double CalcArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
