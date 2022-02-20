public class ReserveBank
{
    public virtual float ROI { get; } = 6.0f;    
    public float CalculateInterest(int amount,int years,float rate)
    {
        return (amount * rate * years) / 100;
    }
}
public class BankOfIndia : ReserveBank
{
    public override float ROI { get; } = 10.2f;
}
public class AxisBank : ReserveBank
{
    public override float ROI { get; } = 9.0f;
    
}
public class CosmosBank : ReserveBank
{
    public override float ROI { get; } = 9.0f;
}

public class MyClass
{
    public static void Main(string[] args)
    {
        ReserveBank rb=new ReserveBank();
     
        int bank;

        int amount, time;
        float interest;
        Console.Write("\n\nEnter Required Amount : ");
        amount = Convert.ToInt32(Console.ReadLine());
        Console.Write("\n\nEnter Time Required (years) : ");
        time = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n\n\t\t **** BANK **** ");
        Console.WriteLine("\n\t 1. Bank of India");
        Console.WriteLine("\n\t 2. Axis Bank ");
        Console.WriteLine("\n\t 3. Cosmos Bank ");

        Console.Write("\n\nChoose Bank : ");
        bank = Convert.ToInt32(Console.ReadLine());
     
        switch(bank)
        {
 
            case 1:
                   // BankOfIndia bankOfIndia = new BankOfIndia();
                    rb = new BankOfIndia();
                      Console.WriteLine(rb.ROI);
                    Console.WriteLine("\n\tInterest Rate : " + rb.ROI);
                    interest = rb.CalculateInterest(amount, time, rb.ROI);
                    Console.WriteLine("\n\tTotal Interest : " + interest);
                    Console.WriteLine("\n\n\tTotal Principle Amount : " + ( amount + interest)); 
                    break;
            case 2:
                    rb = new AxisBank();

                    Console.WriteLine("\n\tInterest Rate : " + rb.ROI);
                    interest = rb.CalculateInterest(amount, time, rb.ROI);
                    Console.WriteLine("\n\tTotal Interest : " + interest);
                    Console.WriteLine("\n\n\tTotal Principle Amount : " + (amount + interest));
                    break;
            case 3:
                    rb = new CosmosBank();

                    Console.WriteLine("\n\tInterest Rate : " + rb.ROI);
                    interest = rb.CalculateInterest(amount, time, rb.ROI);
                    Console.WriteLine("\n\tTotal Interest : " + interest);
                    Console.WriteLine("\n\n\tTotal Principle Amount : " + (amount + interest));
                    break;
            default:
                    Console.WriteLine("\n\n\tInvalid option!!");
                    Console.WriteLine("\n\n\tThanks for using our services..");
                    return;

        }


        Console.WriteLine("\n\n\tThanks for using our services..");

    }
}


