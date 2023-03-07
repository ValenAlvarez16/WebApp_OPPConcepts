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

                Console.Write("Please type your year: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();

                Console.WriteLine(" ");

                Console.Write("Please type your month: ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();

                Console.WriteLine(" ");

                Console.Write("Please type your day: ");
                int day = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();

                //para instanciar el objeto:
                 // todo lo que yo haga y mande, me lo mada con un toString
                 // al menos que yo empiece a desarrollar la lógica
            


                //traerme la información de la clase Employee

                Employee salaryEmployee = new SalaryEmployee()
                {
                    Id = 100,
                    FirstName = "Patricia",
                    LastName = "Alvarez",
                    BirthDate = new Date(year, month, day),
                    HiringDate =new Date(year, month, day),
                    IsActive = true,
                    Salary = 1160000

                };
                Console.WriteLine(salaryEmployee); //para leer los datos
                Console.WriteLine(" ");



                Employee commissionEmployee = new CommissionEmployee()
                {
                    Id = 200,
                    FirstName = "Julio",
                    LastName = "Pérez",
                    BirthDate = new Date(year, month, day),
                    HiringDate =new Date(year, month, day),
                    IsActive = false,
                    CommissionPercentage = 5,
                    Sales = 20000000

                };
                Console.WriteLine(commissionEmployee);
                Console.WriteLine(" ");


                Console.Write("Please type the ID: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                Console.Write("Please type the First Name: ");
                string firstName = Console.ReadLine();
                Console.WriteLine(" ");

                Console.Write("Please type the Last Name: ");
                string lastName = Console.ReadLine();
                Console.WriteLine(" ");

                Console.Write("Please type the if is Active ID: ");
                bool isActive = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine(" ");

                Console.Write("Please type the number of hours: ");
                float hours = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine(" ");

                Console.Write("Please type value per Hours: ");
                decimal hourValue= Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine(" ");

                Employee hourlyEmployee = new HourlyEmployee()
                {
                    Id = 300,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = new Date(year, month, day),
                    HiringDate =new Date(year, month, day),
                    IsActive = isActive,
                    Hours = hours,
                    HourValue = hourValue

                };
                Console.WriteLine(hourlyEmployee);
                Console.WriteLine(" ");


                Employee basecommissionEmployee = new BaseCommissionEmployee()
                {
                    Id = 400,
                    FirstName = "Armando",
                    LastName = "Tirado",
                    BirthDate = new Date(year, month, day),
                    HiringDate = new Date(year, month, day),
                    IsActive = true,
                    CommissionPercentage = 10,
                    Sales = 30000000,
                    Base = 5000000

                };
                Console.WriteLine(basecommissionEmployee);
                Console.WriteLine(" ");
            }
            catch (Exception message)
            {
                Console.WriteLine(message);
            }

           



        }
    }

}

