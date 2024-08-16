namespace UnitTestIntro.Models.Interfaces
{
    public interface IMathCalculService
    {
        public int Addition(int nb1, int nb2);
        public int Addition(int nb1, int nb2, params int[] nbs);

        public double Addition(double nb1, double nb2);
        public double Addition(double nb1, double nb2, params double[] nbs);

        public double Division(int nb1, int nb2);
        public double Division(double nb1, double nb2);

    }
}

