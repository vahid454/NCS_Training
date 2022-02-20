public class ReserveBank
{
    public virtual float ROI { get; } = 1.2f;
    public float CalculateInterest(int amount, int months, float rate)
    {
        return (amount * rate * months) / 100;
    }
    public int GetTotalMonths(int year,int month)
    {
        return ((12 * year) + month);
    }
    public float GetMonthlyInstallments(int months,int principle)
    {

        return (principle/months);
    }
}
public class BankOfIndia : ReserveBank
{
    public override float ROI { get; } = 1.0f;
}
public class AxisBank : ReserveBank
{
    public override float ROI { get; } = 1.5f;

}
public class CosmosBank : ReserveBank
{
    public override float ROI { get; } = 2.0f;
}

public class MyClass
{
    public static void Main(string[] args)
    {
        ReserveBank rb = new ReserveBank();

        int bank;

        int amount, year, month;
        float interest;
        int principleAmount;
        Console.WriteLine("\n\t\t ********* Loan System **********");
        Console.Write("\n\nEnter Required Amount : ");
        amount = Convert.ToInt32(Console.ReadLine());
        Console.Write("\n\nEnter Time Required (years) : ");
        year = Convert.ToInt32(Console.ReadLine());
        Console.Write("\n\nEnter Time Required (months) : ");
        month = Convert.ToInt32(Console.ReadLine());
        if (month < 0 || month > 12)
        {
            Console.WriteLine("\nInvalid input..");
            return;
        }

        Console.WriteLine("\n\n\t\t **** BANK **** ");
        Console.WriteLine("\n\t 1. Bank of India  ( 18 % annum ) ");
        Console.WriteLine("\n\t 2. Axis Bank ( 21.6 % annum ) ");
        Console.WriteLine("\n\t 3. Cosmos Bank  ( 24 % annum ) ");

        Console.Write("\n\nChoose Bank : ");
        bank = Convert.ToInt32(Console.ReadLine());

        int months=rb.GetTotalMonths(year,month);

        switch (bank)
        {

            case 1:
                // BankOfIndia bankOfIndia = new BankOfIndia();
                rb = new BankOfIndia();

                Console.WriteLine("\n\tMonthly Interest Rate : " + rb.ROI+" %");
                interest = rb.CalculateInterest(amount, months, rb.ROI);
                Console.WriteLine("\n\tTotal Interest : " + interest);
                principleAmount = Convert.ToInt32(amount + interest);
                Console.WriteLine("\n\n\tTotal Principle Amount : " + principleAmount);
                Console.WriteLine("\n\nYour monthly installments will be of : " + rb.GetMonthlyInstallments(months,principleAmount) + " for next " + months + " months.");

                break;
            case 2:
                rb = new AxisBank();

                Console.WriteLine("\n\tMonthly Interest Rate : " + rb.ROI + " %");
                interest = rb.CalculateInterest(amount, months, rb.ROI);
                Console.WriteLine("\n\tTotal Interest : " + interest);
                principleAmount = Convert.ToInt32(amount + interest);
                Console.WriteLine("\n\n\tTotal Principle Amount : " + principleAmount);
                Console.WriteLine("\n\nYour monthly installments will be of : " + rb.GetMonthlyInstallments(months, principleAmount) + " for next " + months + " months.");

                break;
            case 3:
                rb = new CosmosBank();

                Console.WriteLine("\n\tMonthly Interest Rate : " + rb.ROI + " %");
                interest = rb.CalculateInterest(amount, months, rb.ROI);
                Console.WriteLine("\n\tTotal Interest : " + interest);
                principleAmount = Convert.ToInt32(amount + interest);
                Console.WriteLine("\n\n\tTotal Principle Amount : " + principleAmount);
                Console.WriteLine("\n\nYour monthly installments will be of : " + rb.GetMonthlyInstallments(months, principleAmount) + " for next " + months + " months.");

                break;
            default:
                Console.WriteLine("\n\n\tInvalid option!!");
                Console.WriteLine("\n\n\tThanks for using our services..");
                return;

        }


        Console.WriteLine("\n\n\tThanks for using our services..");

    }
}


