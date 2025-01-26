namespace Solid.ISP.Good;

public class FullTimeEmployee : IEmployee, ISalaryCalculator, IBenefitsCalculator
{
    public string Name { get; set; }

    public void CalculateBenefits()
    {
        Console.WriteLine("Calculate FullTime Employee Benefits");
    }

    public void CalculateSalary()
    {
        Console.WriteLine("Calculate FullTime Employee Salary");
    }
}
