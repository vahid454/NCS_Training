using System;
class ATMService
{
    int pin;
    string name;
    int amount;
    int deposit;
    int withdraw;

    public static void Main()
    {
        //int amount = 10000, deposit, withdraw;

        int choice,p=0, x = 0;
        ATMService aTMService = new ATMService { pin=1234, name="Vahid", amount=10000, deposit=0, withdraw =0};
        Console.WriteLine("\n\tWelcome to ICIC ATM Services\t\n");
        Console.WriteLine("Enter your 4 digit pin:");
        p = int.Parse(Console.ReadLine());
        if (p== aTMService.pin)
        {
            while (true)
            {
                Console.WriteLine("\n\t********  Dashboard  ********\n\n");
                Console.WriteLine("\t1. Current balance\n");
                Console.WriteLine("\t2. Withdraw\n");
                Console.WriteLine("\t3. Deposit\n");
                Console.WriteLine("\t4. Change Pin\n");

                Console.WriteLine("\t5. Cancel\n");
                Console.WriteLine("====================\n\n");
                Console.WriteLine("enter you choice\n");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n your current balance is RS: {0}", aTMService.amount);
                        break;
                    case 2:
                        Console.WriteLine("\n enter your withdraw amount:");
                        aTMService.withdraw = int.Parse(Console.ReadLine());
                        if (aTMService.withdraw % 100 != 0)
                        {
                            Console.WriteLine("\n please enter the amount in above 100");
                        }
                        else if (aTMService.withdraw > (aTMService.amount - 1000))
                        {
                            Console.WriteLine("\n sorry! insufficent balance.......................");
                        }
                        else
                        {
                            aTMService.amount = aTMService.amount - aTMService.withdraw;
                            Console.WriteLine("\n\n please collect your cash");
                            Console.WriteLine("\n current balance is RS {0}", aTMService.amount);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n enter the deposit amount");
                        aTMService.deposit = int.Parse(Console.ReadLine());
                        aTMService.amount = aTMService.amount + aTMService.deposit;
                        Console.WriteLine("your amount has been deposited successfully....");
                        Console.WriteLine("your total balance is RS {0}", aTMService.amount);
                        break;
                    case 4:
                        Console.Write("\n\nEnter 4 Digit New Pin : ");
                        int tpin = int.Parse(Console.ReadLine());
                        if (tpin.ToString().Length != 4)
                        {
                            Console.WriteLine("\n\tPlease enter 4 digit pin");
                            break;
                        }
                        else
                        {

                            aTMService.pin = Convert.ToInt32(tpin);
                            Console.WriteLine("\nCongrats! {0} changed pin successfully...", aTMService.name);
                            Console.WriteLine("\n\tWelcome to ICIC ATM Services\t\n");
                            Console.WriteLine("Enter your 4 digit pin:");
                            p = int.Parse(Console.ReadLine());
                            if (p == aTMService.pin)
                            {
                                break;
                            }
                            else 
                            {
                                Console.WriteLine("\t\n Wrong Pin.....");
                            }

                            Console.WriteLine("\n\n Thanks for using ATM Services.");
                            return;
                        
                        }
                        break;


                    case 5:
                     
                        Console.WriteLine("\n\n Thanks for using ATM Service.");
                        return;
                    
                       
                }
            }
        }
        else 
        {
            Console.WriteLine("\t\n Wrong Pin.....");
        }
        
        Console.WriteLine("\n\n Thanks for using ATM Services.");
    }
}
