

public abstract class EmployeeSalary
{
    public abstract int getSalary();
}
interface IOrganization
{
    void DisplayStructure();
}
public class Employee : EmployeeSalary, IOrganization
{
    public int id;
    public string name;
    public int baseSalary;
    public int dearAllowance;
    public int travelAllowance;
    public int professionalTax;
    public override int getSalary()
    { 
        
        return ((baseSalary+dearAllowance+travelAllowance)-(2*professionalTax));
    }
    public void DisplayStructure()
        {
        Console.WriteLine("\t\t\n ****** Welcome to NCS ******");
        Console.WriteLine("\t\nDear : " + name);
        Console.WriteLine("\t\n\nYour Gross Monthly Salary : " +getSalary());
        Console.WriteLine("\nThanks.");

    }
}

public class Program
{
    public static void Main(string[] args)
    {

        Employee e = new Employee();
        //  {id= 101, name="Vijay",baseSalary=10000,dearAllowance=900,travelAllowance=800,professionalTax=1000 }
        Console.Write("\t\nEnter ID : ");
        e.id = Convert.ToInt32(Console.ReadLine());
        Console.Write("\t\nEnter Name : ");
        e.name = Console.ReadLine();
        Console.Write("\t\nEnter Base Salary : ");
        e.baseSalary = Convert.ToInt32(Console.ReadLine());
        Console.Write("\t\nEnter Travel Allowance : ");
        e.travelAllowance = Convert.ToInt32(Console.ReadLine());
        Console.Write("\t\nEnter Dear Allowance : ");
        e.dearAllowance = Convert.ToInt32(Console.ReadLine());
        Console.Write("\t\nEnter Professional Tax : ");
        e.professionalTax = Convert.ToInt32(Console.ReadLine());


        e.DisplayStructure();

    }
}