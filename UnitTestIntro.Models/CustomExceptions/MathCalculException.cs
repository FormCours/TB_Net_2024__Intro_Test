namespace UnitTestIntro.Models.CustomExceptions
{
    public class MathCalculException : Exception {
        public MathCalculException(string message) : base(message) { }
    }

    public class MathCalculDivByZeroException : MathCalculException
    {
        public MathCalculDivByZeroException() : base("Div by zero !!!") { }
    }

}
