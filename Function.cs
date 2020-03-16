using System;

namespace pe4
{
    class Function
    {
        internal delegate double deledate_foo(double x);
        internal double e { get; set; }
        internal deledate_foo d_foo;
        internal deledate_foo d_foo_dx;
        internal deledate_foo d_foo_ddx;

        static double f1(double x)
        {
            return Math.Log10(x) - x + 2;
        }
        static double f1_dx(double x)
        {
            //return 1 / (x * Math.Log(10, Math.Exp(1))) - 1;
            return 1 / (x * Math.Log(10)) - 1;
        }
        static double f1_ddx(double x)
        {
            return -1 / (x * x * Math.Log(10));
        }
        static double f2(double x)
        {
            return Math.Pow(x, 3) * 2 + x * x - x - 2;
        }
        static double f2_dx(double x)
        {
            return 6*x*x + 2*x - 1;
        }
        static double f2_ddx(double x)
        {
            return 12 * x + 2;
        }
        static double f3(double x)
        {
            return Math.Exp(x) + 2 * x + 4;
        }
        static double f3_dx(double x)
        {
            return Math.Exp(x) + 2;
        }
        static double f4(double x)
        {
            return Math.Pow(x, 3) + 3 * x * x - x + 1;
        }
        static double f4_dx(double x)
        {
            return 3 * x * x + 6 * x - 1;
        }

        internal void change_foo(int number)
        {
            switch (number)
            {
                case 1:
                    {
                        d_foo = new deledate_foo(f1);
                        d_foo_dx = new deledate_foo(f1_dx);
                    }
                    break;
                case 2:
                    {
                        d_foo = new deledate_foo(f2);
                        d_foo_dx = new deledate_foo(f2_dx);
                    }
                    break;
                case 3:
                    {
                        d_foo = new deledate_foo(f3);
                        d_foo_dx = new deledate_foo(f3_dx);
                    }
                    break;
                default:
                    {
                        d_foo = new deledate_foo(f4);
                        d_foo_dx = new deledate_foo(f4_dx);
                    }
                    break;
            }
        }
        internal double Newton(double x)
        {
            double f2 = 0, f3;
            while (Math.Abs(f2) <= e)
            {
                f3 = d_foo(x);
                f2 = d_foo(x) / d_foo_dx(x);
                x -= f2;
            }
            return x;
        }
        internal double dichotomy(double a, double b)
        {
            double c;
            while (Math.Abs(b - a) > e)
            {
                c = (a + b) / 2;
                if (d_foo(c) * d_foo(a) < 0) b = c;
                else a = c;
            }
            return (a + b) / 2;
        }
        //-------------------------------------------------------------------end
    }
}
