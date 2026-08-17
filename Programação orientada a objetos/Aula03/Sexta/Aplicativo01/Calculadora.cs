
namespace Aplicativo01
{
    internal static class Calculadora
    {
        //Membros
        // Campos
        public const double pi = 3.1415;


        // Terceiro membro da classe - Métodos
        public static double Circunferencia( double raio)
        {
            return 2 * pi * raio;
        }


         public static double volume(double raio); 
        {
         return (4 * pi * Math.Pow(raio, 3 )) /3;
        }

    namespace Aplicativo01
    {
        internal static class Calculadora
        {
            //Membros
            // Campos
            public const double pi = 3.1415;


            // Terceiro membro da classe - Métodos
            public static double Circunferencia(double raio)
            {
                return 2 * pi * raio;
            }


            // public static double volume(double raio); 
            //{
            // return (4 * pi * Math.Pow(raio, 3 )) /3;
            //}

            public static double volume(double raio)
            {
                return (4.0 / 3.0) * pi * raio * raio * raio;
            }



            public static void PI()
            {
                Console.WriteLine(pi);
            }


        }
    }
        


        public static void PI()
        {
            Console.WriteLine(pi);
        }


    }
}
