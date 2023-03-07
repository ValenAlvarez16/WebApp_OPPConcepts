namespace WebApp_OPPConcepts.Helpers
{
    public class EmployeeHelper
    {
        private Employee _salaryEmployee;
        private Employee _commissionEmployee;
        private Employee _hourlyEmployee;
        private Employee _baseCommissionEmployee;

        public EmployeeHelper(Employee salaryEmployee, Employee commisionEmployee, 
            Employee hourlyEmployee, Employee baseCommissionEmployee)
        {
            _salaryEmployee = salaryEmployee;
            _commissionEmployee = commisionEmployee;
            _hourlyEmployee = hourlyEmployee;
            _baseCommissionEmployee = baseCommissionEmployee;
        }

        public decimal GetPayrollFromActiveEmployees()
        {
            ICollection<Employee> employees = new List<Employee>()
                {
                    _salaryEmployee,
                    _commissionEmployee,
                    _hourlyEmployee,
                    _baseCommissionEmployee
                };

            decimal payroll = 0;

            foreach (Employee employee in employees) //dentro de la collection me vas a extraer cada uno de sus elementos
            {
                if (employee.IsActive == true)
                {

                    Console.WriteLine(employee);
                    Console.WriteLine(" ");
                    payroll += employee.GetValueToPay();

                }

            }
            return payroll;
        }
    }
}
