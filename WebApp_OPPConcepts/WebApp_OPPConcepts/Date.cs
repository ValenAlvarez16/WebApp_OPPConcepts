using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp_OPPConcepts
{
    public class Date
    {
        #region Fields 
        //campos
        private int _year;
        private int _month;
        private int _day;

        #endregion

        #region Methods
        //Métodos

        public Date(int year, int month, int day)
        {
            //ctor y te hace esto
            _year = CheckYear(year);
            _month = CheckMonth(month);
            _day = CheckDay(day,month, year);

        }

        private int CheckYear(int year)
        {
            if (year >= 1900)
            {
                return year;
            }
            throw new YearException(" The Year is invalid");
        }

        private int CheckDay(int day, int month, int year)
        {
            if (month ==2 && day == 29 && IsLeapYear(year)) // me valida que lo que yo ponga hasta mes 2 llegue solo hasta 29
            {                                               // el IsLeapYear me valida que el año que pongo sea un año bisiesto
                return day;
            }

            int[] daysPorMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }; //lìmite de dias que tienen los meses del año
                                                                                        // el 0 porque el arrays siempre tiene que empezar con cero

            if (day >= 1 && day <= daysPorMonth[month])
            {
                return day;
            }

            throw new DayException("The Day is invalid");
        }


        private bool IsLeapYear(int year)
        {
            return year %400== 0 || year %4 ==0 && year %100 !=0;
            
        }

        private int CheckMonth(int month) //validaciòn interna por eso es privada
        {
            if (month >= 1 && month <= 12)
            {
                return month;
            }
            
            throw new MonthException("The month is invalid"); //capturando una excepción
            
        }




        // cuando yo quiero sobreescribir un método ya existente, el método papá
        //que se llama ToString debe tener la palabra virtual
        //pero el mètodo hijo que lo va a sobreescribir debe tener la palabra override
        public override string ToString()
        {
            return String.Format("{0:0000}/{1:00}/{2:00}", _year, _month, _day);
        //$"{_year}/ {_month}/ {_day}";  //sobreescribiendo lo del papà para que no le muestre un ToString
        
        }
        #endregion

    }
}
//virtual,constructor