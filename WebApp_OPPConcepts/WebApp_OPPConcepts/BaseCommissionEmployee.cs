using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp_OPPConcepts
{
    public class BaseCommissionEmployee : CommissionEmployee // salary hereda de Employee que es el papá por eso los ":"
    {

        #region Properties

        public decimal Base { get; set; } // decimal porque estamos hablando de plata


        #endregion


        public override decimal GetValueToPay()
        {
            return base.GetValueToPay() + Base; //me traigo eso de commission
                //(Sales * ((decimal)CommissionPercentage/100))+ Base;//esto es un casteo 
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" + //base es la palabra reservada para reutilizar lo que hay en Employee
                   $"Base................. {Base:C2}\n\t" + 
                   $"Total ............... {GetValueToPay():C2}\n\t";
        }

      
    }
}
