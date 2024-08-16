namespace UnitTestIntro.Models.CustomExceptions
{
    public class MathCalculException : Exception {
        public MathCalculException(string message) : base(message) { }
    }

}
