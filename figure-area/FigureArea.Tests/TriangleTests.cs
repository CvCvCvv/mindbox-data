namespace FigureArea.Tests
{
    public class TriangleTests
    {
        // Проверка на исключение при установке не верных параметров в констуктор
        [Theory]
        [InlineData(2d, 3d, 5d)]
        [InlineData(0d, 2d, 2d)]
        [InlineData(-5d, 2d, 5d)]
        [InlineData(5d, -2d, 5d)]
        [InlineData(1d, 2d, -5d)]
        public void Triandle_setParam(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var triangle = new Triangle(a, b, c);
            });
        }

        //Тест корректности вычисления площади
        [Fact]
        public void CalcArea_Correct()
        {
            double a = 2d;
            double b = 4d;
            double c = 5d;
            double s = 3.7996;

            var triangle = new Triangle(a, b, c);
            double actual = triangle.CalcArea();
            Assert.Equal(s, actual, 0.001d);
        }

        //Тест правильности определения прямоугольного треугольника
        [Theory]
        [InlineData(3d, 4d, 5d)]
        [InlineData(4d, 3d, 5d)]
        [InlineData(5d, 4d, 3d)]
        public void RightTriangleCheck_true(double a, double b, double c)
        {
            Assert.True(new Triangle(a, b, c).RightTriangleCheck());

        }

        //Тест определения не прямоугольного треугольника
        [Theory]
        [InlineData(2d, 4d, 5d)]
        [InlineData(4d, 2d, 5d)]
        [InlineData(5d, 4d, 2d)]
        public void RightTriangleCheck_false(double a, double b, double c)
        {
            Assert.False(new Triangle(a, b, c).RightTriangleCheck());

        }

        //Тест вывода исключения при неправильной установке свойств
        [Theory]
        [InlineData(-2d, -4d, -5d)]
        [InlineData(0d, 0d, 0d)]
        [InlineData(10d, 10d, 10d)]
        public void Property_setFail(double a, double b, double c)
        {
            double _a = 3d;
            double _b = 4d;
            double _c = 5d;

            var triangle = new Triangle(_a, _b, _c);

            Assert.Throws<ArgumentException>(() =>
            {
                triangle.SideA = a;
            });
            Assert.Throws<ArgumentException>(() =>
            {
                triangle.SideB = b;
            });
            Assert.Throws<ArgumentException>(() =>
            {
                triangle.SideC = c;
            });
        }
        //Тест установки свойств при правильных значениях
        [Fact]
        public void Property_setSuccess()
        {
            double _a = 3d;
            double _b = 4d;
            double _c = 5d;

            var triangle = new Triangle(_a, _b, _c);
            triangle.SideA = _a;
            triangle.SideB = _b;
            triangle.SideC = _c;
        }

    }

}
