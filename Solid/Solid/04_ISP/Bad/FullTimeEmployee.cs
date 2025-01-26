namespace Solid.ISP.Bad;

public class FullTimeEmployee : IEmployee
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
