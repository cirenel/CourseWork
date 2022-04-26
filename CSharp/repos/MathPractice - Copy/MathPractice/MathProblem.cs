using System;
using System.Collections.Generic;
using System.Text;

namespace MathPractice
{
    class MathProblem
    {
        public int i, j, ans, op;
        private Random r = new Random(); 
        public MathProblem()
        {
            i = r.Next(-100, 100);
            j = r.Next(-100, 100);
            op = r.Next(0, 4);

            switch (op)
            {
                case 0:
                    ans = i + j;
                    break;
                case 1:
                    ans = i - j;
                    break;
                case 2:
                    ans = i / j;
                    break;
                case 3:
                    ans = i * j;
                    break;
            }

        }

    }
}
