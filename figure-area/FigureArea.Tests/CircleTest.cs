namespace FigureArea.Tests
{
    public class CircleTest
    {
        // ���� �������� ����������� �������
        [Fact]
        public void CalcArea_Correct()
        {
            double r = 5d;
            double s = 78.5398;

            var circle = new Circle(r);
            double actual = circle.CalcArea();
            Assert.Equal(s, actual, 0.001d);
        }
        //�������� ������ ���������� ��� ��������� ������������ ��������
        [Fact]
        public void Cirlce_setParamMin()
        {
            double r = -1d;
            Assert.Throws<ArgumentException>(() =>
                {
                    var circle = new Circle(r);
                });
        }
        //�������� ������ ���������� ��� ��������� ������� = 0 
        [Fact]
        public void Cirlce_setParamNull()
        {
            double r = 0;
            Assert.Throws<ArgumentException>(() =>
            {
                var circle = new Circle(r);
            });
        }
        //���� ������ ���������� ��� ������������ ��������� �������
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
        //���� ��������� ������� ��� ���������� ��������
        [Fact]
        public void Property_setSuccess()
        {
            double r = 4;
            var circle = new Circle(r);
            circle.Radius = 4;
        }
    }
}