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
                Console.WriteLine(" ");

                Console.WriteLine("Please type your year: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();

                Console.WriteLine(" ");

                Console.WriteLine("Please type your month: ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();

                Console.WriteLine(" ");

                Console.WriteLine("Please type your day: ");
                int day = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();

                //para instanciar el objeto:
                var dateObject = new Date(year, month, day); // todo lo que yo haga y mande, me lo mada con un toString
                                                             // al menos que yo empiece a desarrollar la lógica
                Console.Write("The date entered is: " + dateObject);
                Console.WriteLine(" ");


                //traerme la información de la clase Employee

                Employee salaryEmployee = new SalaryEmployee()
                {
                    Id = 1,
                    FirstName = "Patricia",
                    LastName = "Alvarez",
                    BirthDate = dateObject,
                    HiringDate = dateObject,
                    IsActive = true,
                    Salary = 1160000

                };
                Console.WriteLine(salaryEmployee); //para leer los datos
                Console.WriteLine(" ");

                Employee commissionEmployee = new CommissionEmployee()
                {
                    Id = 1,
                    FirstName = "Julio",
                    LastName = "Pérez",
                    BirthDate = dateObject,
                    HiringDate = dateObject,
                    IsActive = false,
                    CommissionPercentage = 5,
                    Sales = 20000000

                };
                Console.WriteLine(commissionEmployee);

            }
            catch (Exception message)
            {
                Console.WriteLine(message);
            }

           



        }
    }

}

