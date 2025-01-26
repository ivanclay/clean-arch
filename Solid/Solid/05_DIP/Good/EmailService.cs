namespace Solid.DIP.Good;

public class EmailService:IEmailService
{
    public void Send()
    {
        Console.WriteLine("Sending");
    }
}
