using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp_OPPConcepts
{
    public class CommissionEmployee : Employee // salary hereda de Employee que es el papá por eso los ":"
    {

        #region Properties

        public double CommissionPercentage { get; set; }

        public decimal Sales { get; set; }


        #endregion


        public override decimal GetValueToPay()
        {
            return Sales * ((decimal)CommissionPercentage/100);//esto es un casteo 
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" + //base es la palabra reservada para reutilizar lo que hay en Employee
                   $"Commission Percentage.................{CommissionPercentage/100:P2}\n\t" + //P es de porcentaje
                   $"Sales.................................{Sales:C2}\n\t" + //c quiere decir plata
                   $"Get Value To Pay......................{GetValueToPay():C2}\n\t";
        }

      
    }
}
