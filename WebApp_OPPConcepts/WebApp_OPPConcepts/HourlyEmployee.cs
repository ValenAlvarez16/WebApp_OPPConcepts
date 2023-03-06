using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp_OPPConcepts
{
    public class HourlyEmployee : Employee // salary hereda de Employee que es el papá por eso los ":"
    {

        #region Properties

        public float Hours { get; set; }
        public decimal HourValue { get; set; }

        #endregion


        public override decimal GetValueToPay()
        {
            return HourValue * (decimal) Hours; //castear
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" + //base es la palabra reservada para reutilizar lo que hay en Employee
                   $"Hours.................     {Hours}\n\t" + //c quiere decir plata
                   $"Value per Hour.............{HourValue:C2}\n\t" +
                   $"Get value to Pay...........{GetValueToPay():C2}\n\t";


        }
    }
}
