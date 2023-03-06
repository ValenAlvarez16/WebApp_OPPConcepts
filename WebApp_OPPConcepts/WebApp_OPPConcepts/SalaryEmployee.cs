using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp_OPPConcepts
{
    public class SalaryEmployee : Employee // salary hereda de Employee que es el papá por eso los ":"
    {

        #region Properties

        public decimal Salary { get; set; }


        #endregion


        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" + //base es la palabra reservada para reutilizar lo que hay en Employee
                   $"Salary.................{GetValueToPay():C2}"; //c quiere decir plata


        }
    }
}
