using UnitTestIntro.Models.CustomExceptions;
using UnitTestIntro.Models.Interfaces;
using UnitTestIntro.Models.Services;

namespace UnitTestIntro.Models.Test.Services
{
    public class MathCalculServiceTest
    {
        #region Addition
        [Fact]
        public void Addition_TwoInteger_ReturnSum()
        {
            // Arrange → Préparation (Création des différentes variables necessaire)
            IMathCalculService calculService = new MathCalculService();
            int val1 = 23;
            int val2 = 19;
            int expected = 42;

            // Action → Traitement à tester
            int actual = calculService.Addition(val1, val2);

            // Assert → Validation des resultats
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 9, 23, 42)]
        [InlineData(-5, -9, -10, -24)]
        [InlineData(0, 1, -1, 0)]
        public void Addition_ManyInterger_ReturnSum(int val1, int val2, int val3, int expected)
        {
            // Arrange 
            IMathCalculService calculService = new MathCalculService();

            // Action
            int actual = calculService.Addition(val1, val2, val3);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Addition_TwoBigInteger_ThrowsException()
        {
            // Arrange 
            IMathCalculService calculService = new MathCalculService();
            int val1 = 1_900_000_000;
            int val2 = 2_100_000_000;

            // Action + Assert
            Assert.Throws<MathCalculException>(() =>
            {
                int actual = calculService.Addition(val1, val2);
            });
        }
        
        [Fact]
        public void Addition_TwoDouble_RetrunSum()
        {

            // Arrange 
            IMathCalculService mathCalculServiceDouble = new MathCalculService();
            double nb1 = 1.49;
            double nb2 = 1.111;
            double expected = 2.6;

            // Action 
            double actual = mathCalculServiceDouble.Addition(nb1, nb2);

            // Assert 
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Addition_FourDoubles_ReturnSum()
        {
            //Arrange
            IMathCalculService mathCalculServiceDouble = new MathCalculService();
            double nb1 = 0.01;
            double nb2 = 0.03;
            double nb3 = 0.001;
            double nb4 = 0.5;
            double expected = 0.54;

            //Action

            double actual = mathCalculServiceDouble.Addition(nb1,nb2,nb3,nb4);

            //Assert

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2, 4, 0.5)]
        [InlineData(3, -3, -1)]
        public void Division_TwoInt_ReturnDivision(int nb1, int nb2, double expected)
        {
            // Arrange
            IMathCalculService mathCalculService = new MathCalculService();

            // Action
            double actual = mathCalculService.Division(nb1, nb2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4.4, 2.3, 1.91)]
        [InlineData(3.1, -3.1, -1)]
        [InlineData(5, 0.21, 23.81)]
        public void Division_TwoDouble_ReturnDivision(double nb1, double nb2, double expected)
        {
            // Arrange
            IMathCalculService mathCalculService = new MathCalculService();

            // Action
            double actual = mathCalculService.Division(nb1, nb2);

            // Assert
            Assert.Equal(expected, actual);
        }
        #endregion
    }
}
