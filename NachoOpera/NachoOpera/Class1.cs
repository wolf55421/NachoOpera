using System;

namespace NachoOpera
{
    public class Class1
    {
        public static double Suma(double a, double b)
        {
            return a + b;
        }

        public static double Resta(double a, double b)
        {
            return a - b;
        }

        public static double Multiplicacion(double a, double b)
        {
            return a * b;
        }

        public static double Division(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("No se puede dividir por cero.");
            }
            return a / b;
        }
    }
}
