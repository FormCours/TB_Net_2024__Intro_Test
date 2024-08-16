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

        #endregion
    }
}
