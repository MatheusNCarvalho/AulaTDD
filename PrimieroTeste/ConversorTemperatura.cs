

using System;

namespace PrimieroTeste
{
    public  class ConversorTemperatura
    {
        public static double converteCelsiusParaFahrenheit(double celsius)
        {
            double fahrenheit = 1.8 * celsius + 32; // f =1,8*c+32
            return fahrenheit;
        }
        public static double converteFahrenheitParaCelsius(double fahrenheit)
        {
            //double x = a / (double)b;

            
            double celsius = System.Math.Round((5.0 / 9.0) * (fahrenheit - 32)); // c =(5/9)*(f-32)
            return celsius;
        }
    }
}
