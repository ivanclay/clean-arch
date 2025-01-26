namespace Solid.ISP.Bad;

public class ContractEmployee : IEmployee
{
    public string Name { get; set; }

    public void CalculateBenefits()
    {
        throw new NotImplementedException();
    }

    public void CalculateSalary()
    {
        Console.WriteLine("Calculate Contract Employee Salary");
    }
}
