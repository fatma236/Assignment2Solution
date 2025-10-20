using System.Reflection.Metadata;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //-------1------------------------------
            string[] userName = { "Fatma", "Younis", "Leema", "Salim" };
            string[] password = { "555a", "444b", "666c", "999d" };
            double[] Balance = { 555.0, 680.25, 850.0, 1000.0 };
            Console.WriteLine("----Welcome to Bank Muscat-----");
            Console.WriteLine("Write your user Name please?");
            string us = Console.ReadLine();
            Console.WriteLine("Write Your passward please?");
            string ps = Console.ReadLine();

            for (int i = 0; i < userName.Length; i++)
            {
                if ((userName[i] == us) && (password[i] == ps))
                {
                    Console.WriteLine("Choose An Operation");
                    Console.WriteLine("1 - Check balance");
                    Console.WriteLine("2 - Deposite");
                    Console.WriteLine("3 - Withdraw");
                    Console.WriteLine("4 - Transfer");
                    Console.WriteLine("5 - Exit");
                    int x = int.Parse(Console.ReadLine());
                    switch (x)
                    {
                        case 1:
                            //-----------Check Balance                            
                            if (x == 1)
                            {
                                Console.WriteLine($"You have {Balance[i]} OMR ");
                            }
                            break;
                        case 2:

                            //------------Deposite

                            if (x == 2)
                            {


                                Console.WriteLine("Enter The Amount That You Want To Depsite :");
                                double depos = double.Parse(Console.ReadLine());




                                double z = Balance[i] + depos;
                                Console.WriteLine($"Done.. Now Your Balance is {z}");


                            }
                            break;

                        case 3:

                            //------------Deposite

                            if (x == 3)
                            {


                                Console.WriteLine("Enter The Amount That You Want To WithDraw :");
                                double withd = double.Parse(Console.ReadLine());



                                if (withd > Balance[i])
                                {
                                    Console.WriteLine("Invalid");
                                }
                                else
                                {
                                    double z = Balance[i] - withd;
                                    Console.WriteLine($"Done.. Now Your Balance is {z}");

                                }
                            }
                            break;

                        case 4:
                            if (x == 4)
                            {
                                Console.WriteLine("Write the user name that you want to transfer to ?");
                                string us1 = Console.ReadLine();
                                Console.WriteLine("Enter the amount that you want to transfer ?");
                                double amount = double.Parse(Console.ReadLine());
                                for (int j = 0; j < userName.Length; j++)
                                {
                                    if (userName[j] == us1) {
                                        if (amount < Balance[i])
                                        {
                                            Balance[i] = amount - Balance[i];
                                            Balance[j] = Balance[j] + amount;
                                            Console.WriteLine($" Transfer Done Your Balance Now is {Balance[i]}");
                                        }


                                    }

                                }

                            } 
                            break ;
                        case 5:
                        Console.WriteLine("Thank You");
                        break ; 

                        default:

                             Console.WriteLine();
                             break;
                            
                    }
                }
                
            }
        }
    }
}
            
        
    