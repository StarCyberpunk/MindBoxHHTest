
namespace mindboxHH.Test
{

    public class UnitTest1
    {
        [Fact]
        public void CircleTest1()
        {
            //arrange
            Circle circle = new Circle("Circle", 24);
            double expected = 1809.56;

            //act
            double result = circle.Calc();

            //assert
            Assert.Equal(expected, result);


        }
        [Fact]
        public void TriangleTest1()
        {
            //arrange
            Triangle triangle = new Triangle("Triangle", 8, 8, 10);
            double expected = 31.22;

            //act
            double result = triangle.Calc();

            //assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void isRectangleTest1()
        {
            //Arrange
            var triangle = new Triangle("Triangle", 4, 6, 8);

            //Act
            var result = triangle.IsRectangular();

            //Assert
            Assert.False(result);
        }


    }
}

