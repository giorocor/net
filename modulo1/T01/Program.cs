using System;

namespace T01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 6;
            double num3 = 2.3;
            double suma;
            suma = num1 + num3;

            Console.WriteLine(suma);
            string valor1 = Console.ReadLine();
            Console.WriteLine("El numero introducido es " + valor1);
            int valorEntero = Convert.ToInt32(valor1);

            Console.ReadKey();
        }
    }
}
