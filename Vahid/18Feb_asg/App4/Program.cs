

public class MathOperation
{
   
       
    public int getFactorial()
    {
        Console.Write("\t\nEnter Number : ");
        int n=Convert.ToInt32(Console.ReadLine());
        
        return getFactorial(n);
    }
    public int getFactorial(int num)
    {
        int fact = 1;
        for (int i = 1; i <= num; i++)
        {
            fact = fact * i;
        }
        return fact;
    }
    public virtual int getSquare(int a)
    {
        return a * a;
    }
    public virtual int getCube(int a)
    {
        return a * a * a;
    }
}
public class Square : MathOperation
{
    public override int getSquare(int a)
    {
        Console.WriteLine("\n\nSquare Class Method Invoked !! ");

        return a*a;
    }

}
public class Cube : MathOperation
{
    public override int getCube(int a)
    {
        Console.WriteLine("\n\nCube Class Method Invoked !! ");

        return a * a * a;
    }

}
class Program
{
    public static void Main(string[] args)
    {
        MathOperation mo=new MathOperation();
        Console.WriteLine("\n\n\tFactorial : "+ mo.getFactorial());
        Square square=new Square();
        Console.Write("\nEnter number to find square : ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("\n\n\tSqaure is : "+square.getSquare(n));
        Cube cb=new Cube();
        Console.Write("\nEnter number to find cube : ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("\n\n\tCube is : " + cb.getCube(n));
    }
}
