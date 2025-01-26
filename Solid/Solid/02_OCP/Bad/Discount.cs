namespace Solid.OCP.Bad;

public class Discount
{
    public decimal Calculate(EProductType type, decimal price) 
    {
        if (type == EProductType.Eletronics) return price * 0.2M;
        if (type == EProductType.Health) return price * 0.3M;
        if (type == EProductType.Beauty) return price * 0.4M;
        if (type == EProductType.Fashion) return price * 0.5M;
        
        return price;
    }
}
