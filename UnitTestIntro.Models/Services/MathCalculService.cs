using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestIntro.Models.Interfaces;

namespace UnitTestIntro.Models.Services
{
    public class MathCalculService : IMathCalculService
    {
        public int Addition(int nb1, int nb2)
        {
            return nb1 + nb2;
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
            throw new NotImplementedException();
        }

        public double Addition(double nb1, double nb2, params double[] nbs)
        {
            throw new NotImplementedException();
        }
    }
}
