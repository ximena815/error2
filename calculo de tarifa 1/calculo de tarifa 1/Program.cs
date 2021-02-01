using System;

namespace calculo_de_tarifa_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de tarifas ");
            int smmlv = 908526;
            Console.WriteLine("ingrese su salario: $");
            int salario = int.Parse(Console.ReadLine());

            //Calculo de tarifas
            if (salario < smmlv * 2)
            {
                Console.WriteLine("Tarifa a");
            }
                else if (smmlv * 2 <= salario && salario < smmlv * 4) 
            {
                Console.WriteLine("Tarifa b");
            }
            if (salario >= smmlv * 4)
            {
                Console.WriteLine("Tarifa c");
            }

            //-------------------------------------------------------------------------------
            Console.WriteLine("Calculo de tarifas y Cuotas Moderadoras");
            int smmlv1 = 908526;
            int smdlv = 32688;
            Console.WriteLine("ingrese su salario: $");
            int salario1 = int.Parse(Console.ReadLine());

            //Calculo de tarifas y Cuotas Moderadoras
            if (salario1 < smmlv1 * 2)
            {
                Console.WriteLine("Tarifa a");
                double cum = smdlv * 11.70 / 100;
                Console.WriteLine("Cuotas Moderadoras de: " + cum);
            }
                else if (smmlv1 * 2 <= salario1 && salario1 < smmlv1 * 5) 
                
            {
                Console.WriteLine("Tarifa b");
                double cum = smdlv * 46.10 / 100;
                Console.WriteLine("Cuotas Moderadoras de :" + cum);
            }
            if (salario1 >= smmlv1 * 5)
            {
                Console.WriteLine("Tarifa c");
                double cum = smdlv * 121.50 / 100;
                Console.WriteLine("Cuotas Moderadoras de: " + cum);
            }

        }
    }
}
