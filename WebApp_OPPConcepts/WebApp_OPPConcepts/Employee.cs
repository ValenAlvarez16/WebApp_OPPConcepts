using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp_OPPConcepts
{
    public abstract class Employee
    {
        //fields tiene campos
        //las propiedades llevan get y sed, los fields no
        #region

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Date BirthDate { get; set; }

        public Date HiringDate { get; set; }

        //los booleanos siempre deben comentar con el verbo to be (is), para identificar que es un booleano
        // booleano (falso o verdadero)

        //pascal case: es la anotación que cada palabra empieza con mayuscula "LolaMesa"
        //camel case: es minuscula y despuès mayuscula "lolaMesa", no aplica en propiedades: solo en fields y variables 

        public bool IsActive { get; set; }

        #endregion

        #region Methods

        public abstract decimal GetValueToPay(); // temas financieros es decimal

        public override string ToString() // ToString viene de la clase object y ya tiene unas definiciones
        {

            return $"--------- EMPLOYEE--------\n\\t" +
                   $"ID..............{Id}\n\t" +
                   $"First Name......{FirstName}\n\t" +
                   $"Last Name.......{LastName}\n\t" +
                   $"Birth Date .....{BirthDate}\n\t" +
                   $"Hiring Date.....{HiringDate}\n\t" +
                   $"Is Active?......{IsActive}";
        }

        #endregion
    }
}
