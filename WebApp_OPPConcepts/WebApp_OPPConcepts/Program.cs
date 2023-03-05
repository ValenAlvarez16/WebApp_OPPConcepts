using System;

namespace WebApp_OPPConcepts
{

    public class Program
    {
        //Program es el controlador

        static void Main(string[] args)
        {
            try
            {
                //vamos a ingresar la información por teclado
                Console.WriteLine("***************");
                Console.WriteLine("*My first Date Class*");
                Console.WriteLine("***************");
                Console.WriteLine("");

                Console.WriteLine("Please type your year: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();

                Console.WriteLine("");

                Console.WriteLine("Please type your month: ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();

                Console.WriteLine("");

                Console.WriteLine("Please type your day: ");
                int day = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();

                //para instanciar el objeto:
                var dateObject = new Date(year, month, day); // todo lo que yo haga y mande, me lo mada con un toString
                                                             // al menos que yo empiece a desarrollar la lógica
                Console.Write("The date entered is: " + dateObject);
                

            }
            catch (Exception message)
            {
                Console.WriteLine(message);
            }

           



        }
    }

}

