namespace FigureArea
{
    public class Triangle : Figure
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public double SideA
        {
            get { return _sideA; }
            set
            {
                if (!SidesCheck(value, _sideB, _sideC))
                {
                    throw new ArgumentException(message: "Error: There is no triangle with the given sides");
                };
                _sideA = value;
            }
        }
        public double SideB
        {
            get { return _sideB; }
            set
            {
                if (!SidesCheck(_sideA, value, _sideC))
                {
                    throw new ArgumentException(message: "Error: There is no triangle with the given sides");
                };
                _sideB = value;
            }
        }
        public double SideC
        {
            get { return _sideC; }
            set
            {
                if (!SidesCheck(_sideA, _sideB, value))
                {
                    throw new ArgumentException(message: "Error: There is no triangle with the given sides");
                };
                _sideC = value;
            }
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!SidesCheck(sideA, sideB, sideC))
            {
                throw new ArgumentException(message: "Error: There is no triangle with the given sides");
            }
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }
        public override double CalcArea()
        {
            double p = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }

        public bool RightTriangleCheck()
        {
            if (_sideA > _sideB && _sideA > _sideC)
            {
                return PythagoreanTheoremCheck(_sideC, _sideB, _sideA);
            }
            else if (_sideB > _sideA && _sideB > _sideC)
            {
                return PythagoreanTheoremCheck(_sideC, _sideA, _sideB);
            }
            else if (_sideC > _sideA && _sideC > _sideB)
                return PythagoreanTheoremCheck(_sideB, _sideA, _sideC);

            return false;
        }

        private static bool PythagoreanTheoremCheck(double a, double b, double c)
        {
            return Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2);
        }
        private static bool SidesCheck(double sideA, double sideB, double sideC)
        {
            if (sideA + sideB <= sideC || sideB + sideC <= sideA || sideC + sideA <= sideB || sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                return false;
            }
            return true;
        }

    }
}
