using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestIntro.Models.CustomExceptions;
using UnitTestIntro.Models.Interfaces;

namespace UnitTestIntro.Models.Services
{
    public class MathCalculService : IMathCalculService
    {
        public int Addition(int nb1, int nb2)
        {
            if ((nb1 > 0 && nb2 > 0 && int.MaxValue - nb1 < nb2)
                || (nb1 < 0 && nb2 < 0 && int.MinValue - nb1 > nb2))
            {
                throw new MathCalculException("Overflow !!!");
            }

            return nb1 + nb2;

            // Ou alors ça ↓
            // try
            // {
            //     return checked(nb1 + nb2);
            // }
            // catch
            // {
            //     throw new MathCalculException("Overflow !!!");
            // }
        }

        public int Addition(int nb1, int nb2, params int[] nbs)
        {
            int result = Addition(nb1, nb2);

            foreach (int nb in nbs)
            {
                result = Addition(result, nb);
            }

            return result;
        }

        public double Addition(double nb1, double nb2)
        {
            return Math.Round(nb1 + nb2, 2);
        }

        public double Addition(double nb1, double nb2, params double[] nbs)
        {
            double result = nb1 + nb2;

            foreach (double nb in nbs)
            {
                result = result + nb;
            }

            return Math.Round(result, 2);
        }

        #region Division
        public double Division(int nb1, int nb2)
        {
            return Division((double)nb1, nb2);
        }

        public double Division(double nb1, double nb2)
        {
            if(nb2 == 0)
            {
                throw new MathCalculDivByZeroException();
            }

            double result = nb1 / nb2;
            return Math.Round(result, 2); ;
        }
        #endregion
    }
}
