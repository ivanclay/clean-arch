namespace Solid.ISP.Good;

public class ContractEmployee : IEmployee, ISalaryCalculator
{
    public string Name { get; set; }

    public void CalculateSalary()
    {
        Console.WriteLine("Calculate Contract Employee Salary");
    }
}
