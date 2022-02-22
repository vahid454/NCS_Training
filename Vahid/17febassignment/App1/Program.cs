
// See https://aka.ms/new-console-template for more information

//C# program to calculate the total of employee's salary 
//using the Aggregate() method. 

using System;
using System.Linq;
using System.Collections.Generic;

public class Employee
{
    int ID;
    string Name;
    int BaseSalary;
    int TravelAllowance;
    int DearAllowance;
    int ProfessionalTax;
 
    static void Main(string[] args)
    {

        float Hike = 0.0f; 
        int GrossSalary = 0 ;
        int id, bs = 0, ta, da, pt;
        Console.Write("Enter Your ID : ");
        id=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Your Name : ");
        String name = Convert.ToString(Console.ReadLine());
        Console.Write("Enter Your Base Salary : ");
        bs = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Your Travel Allowance : ");
        ta = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Your Dear Allowance: ");
        da = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Your Professional Tax : ");
        pt = Convert.ToInt32(Console.ReadLine());

        Employee e = new Employee { ID = id, Name =name, BaseSalary =bs, TravelAllowance = ta, DearAllowance = da , ProfessionalTax=pt};

        GrossSalary = e.BaseSalary + e.DearAllowance + e.TravelAllowance;
        GrossSalary = GrossSalary - (2 * e.ProfessionalTax);
        if (e.BaseSalary < 50000)
        {
            Console.WriteLine("Congrats "+e.Name +" ! You got 8% Bonus");
            GrossSalary = (GrossSalary + (GrossSalary * 8) / 100);
            Console.WriteLine("Total Gross Salary : " + GrossSalary);
        }
        else
        {
            if (e.BaseSalary > 50000 && e.BaseSalary < 60000)
            {
                Console.WriteLine("Congrats " +e.Name+ " ! You got 10% Bonus");
                GrossSalary = (GrossSalary + (GrossSalary * 10) / 100);
                Console.WriteLine("Total Gross Salary : " + GrossSalary);
            }
            else
            {
                if (e.BaseSalary > 100000)
                {
                    Console.WriteLine("Congrats  " + e.Name + " ! You got 5% Bonus");
                    GrossSalary = (GrossSalary + (GrossSalary * 5) / 100);
                    Console.WriteLine("Total Gross Salary : " + GrossSalary);
                }
            }
        }


    }
}
