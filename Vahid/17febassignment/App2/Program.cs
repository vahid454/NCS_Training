using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Collections.Generic;

class PizzaHut
{
    int ID;
    string Name;
    int cost;
  
    static void Main(string[] args)
    {
        int TotalBill = 0;

        List<PizzaHut> pizzas = new List<PizzaHut>()
        {
             new PizzaHut {ID=101,   Name="Onion Pizza" ,cost=800},
             new PizzaHut {ID=102,   Name="Plain Pizza" ,cost=900},
             new PizzaHut {ID=401,   Name="King Burger" ,cost=100},
             new PizzaHut {ID=201,   Name="Masala Tea" ,cost=20},
             new PizzaHut {ID=202,   Name="Plain Tea" ,cost=10},
             new PizzaHut {ID=301,   Name="Cold Drink" ,cost=50},
        };
        Display(pizzas);

        TotalBill= pizzas.Aggregate<PizzaHut, int>(0, (sum, e) => sum += e.cost);
        if (TotalBill <= 10000)
        {
            TotalBill= (TotalBill- (TotalBill*10)/100);
            Console.WriteLine("\n\nCongrats! You got 10% deduction...");
            Console.WriteLine("\n\tYou Bill Amount : " +TotalBill);
        }
        else if (TotalBill > 10000 && TotalBill < 50000)
        {
            TotalBill = (TotalBill - (TotalBill * 30) / 100);
            Console.WriteLine("\n\nCongrats! You got 30% deduction...");
            Console.WriteLine("\n\tYou Bill Amount : " + TotalBill);
        }
        
    }

    public static void Display(List<PizzaHut> pizzas)
    {
        Console.WriteLine("** Your Order **");
        for (int i = 0; i < pizzas.Count; i++)
        {
            Console.Write(pizzas[i].Name + "\t");
            Console.WriteLine(pizzas[i].cost + "\t");

        }

    }
}

