namespace FigureArea.Tests
{
    public class CircleTest
    {
        // Тест верности определения площади
        [Fact]
        public void CalcArea_Correct()
        {
            double r = 5d;
            double s = 78.5398;

            var circle = new Circle(r);
            double actual = circle.CalcArea();
            Assert.Equal(s, actual, 0.001d);
        }
        //Проверка вывода исключения при установке недопустимых значений
        [Fact]
        public void Cirlce_setParamMin()
        {
            double r = -1d;
            Assert.Throws<ArgumentException>(() =>
                {
                    var circle = new Circle(r);
                });
        }
        //Проверка вывода исключения при установке радиуса = 0 
        [Fact]
        public void Cirlce_setParamNull()
        {
            double r = 0;
            Assert.Throws<ArgumentException>(() =>
            {
                var circle = new Circle(r);
            });
        }
        //Тест вывода исключения при неправильной установке свойств
        [Fact]
        public void Property_setFail()
        {
            double r = 4;
            var circle = new Circle(r);
            Assert.Throws<ArgumentException>(() =>
            {
                circle.Radius = 0;
            });
            Assert.Throws<ArgumentException>(() =>
            {
                circle.Radius = -1;
            });
        }
        //Тест установки свойств при допустимом значении
        [Fact]
        public void Property_setSuccess()
        {
            double r = 4;
            var circle = new Circle(r);
            circle.Radius = 4;
        }
    }
}