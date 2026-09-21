using System;

namespace exprimerparcial
{
    public class Program
    {
        public static void Main()
        {
            const int total_soldados = 5;
            string fortin;
            double promedio;
            double agua;
            double agua2 = 0;
            Console.WriteLine("Ingrese el nombre de su fortin:");
            fortin = Console.ReadLine();

            for (int i = 1; i <= total_soldados; i++)
            {
                Console.WriteLine("ingrese la cantidad de agua de los soldados en el fortin");
                agua = double.Parse(Console.ReadLine());
                Console.WriteLine("El numero de soldados " + i + " tiene la cantidad de agua"+ ":" + agua);

                agua2  += agua;
               
            

            }
            promedio = agua2 / total_soldados;
            
            static  void abastecimiento (double promedio) {
                if (promedio >= 50)
                {

                    Console.WriteLine("Fortin abastecido aguanta la lucha");

                }
                else if (promedio == 25)
                {
                    Console.WriteLine("fortin apunto de llegar a reservas");
                }
                else {
                    Console.WriteLine("Fortin en peligro NECESITA PROVISIONES");
                
                }
                
            }

            Console.WriteLine("==========================================");
            Console.WriteLine("Informacion confidencial del fortin:" + fortin);
            Console.WriteLine("El estado de agua en el fortin es de:" + promedio);
            abastecimiento(promedio);
            Console.WriteLine("==========================================");



        }
    }
}
