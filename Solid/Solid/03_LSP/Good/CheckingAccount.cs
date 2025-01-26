namespace Solid.LSP.Good;

public class CheckingAccount : BankAccount
{
    public override void Withdraw(decimal amount)
    {
        throw new NotImplementedException();
    }
}
