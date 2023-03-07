using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp_OPPConcepts.Interfaces;

namespace WebApp_OPPConcepts
{
    public class Invoice : IPay
    {

        #region Poperties
        public int Id { get; set; }

        public string Description { get; set; }

        public double Quantity { get; set; }

        public decimal Price { get; set; }

        #endregion


        #region Methods
        public decimal GetValueToPay()
        {
            return (decimal)Quantity * Price;
        }

        public override string ToString()
        {
            return $"ID:{Id} - Description: {Description}\n\t" +
                $"Quantity......... {Quantity}\n\t" +
                $"Price.............{Price:C2}\n\t" +
                $"Total Invoice.....{GetValueToPay()}";
        }
        #endregion
    }

}
