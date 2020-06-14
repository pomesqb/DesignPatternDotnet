using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new Employees();
            employees.Attach(new Clerk());
            employees.Attach(new Director());
            employees.Attach(new President());

            var incomeVisitor = new IncomeVisitor();
            var vacationVisitor = new VacationVisitor();

            employees.Accept(incomeVisitor);
            employees.Accept(vacationVisitor);

            Console.ReadLine();
        }
    }
}
