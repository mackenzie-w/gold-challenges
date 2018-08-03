using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Outing outing1 = new Outing(7, "10/10/2010", 25.00m, 175.00, (OutingType)1);
            Outing outing2 = new Outing(10, "12/12/2012", 15.00m, 150.00, (OutingType)2);
            Outing outing3 = new Outing(25, "01/01/2013", 50.00m, 1250.00, (OutingType)3);
            Outing outing4 = new Outing(10, "05/07/2014", 30.00m, 300.00, (OutingType)4);

            OutingRepository outingRepo = new OutingRepository();

            outingRepo.AddOutingToList(outing1);
            outingRepo.AddOutingToList(outing2);
            outingRepo.AddOutingToList(outing3);
            outingRepo.AddOutingToList(outing4);

            List<Outing> outings = outingRepo.GetList();

            while(true)
            {
                Console.WriteLine("Enter the NUMBER you would like to select:\n" +
               "1. Display all outings.\n" +
               "2. Add an outing. \n" +
               "3. View all costs of outings. \n" +
               "4. View costs of outings by type. \n" +
               "5. Exit program.\n");

                string optionAsString = Console.ReadLine();
                int option = int.Parse(optionAsString);

                if (option == 1)
                {
                    foreach (Outing outing in outings)
                    {
                        Console.WriteLine($"Number of attendees: { outing.People}\n" +
                            $"Date of outing: {outing.Date}\n" +
                            $"Cost per head: {outing.CostPerHead}\n" +
                            $"Total cost of outing: {outing.OutingCost}\n" +
                            $"Type of outing: {outing.Type}\n");
                    }
                }

                if (option == 2)
                {
                    while (true)
                    {
                        Console.WriteLine("Enter the number of attendees: ");
                        int people = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the date of the outing: ");
                        string date = Console.ReadLine();
                        Console.WriteLine("Enter the cost per head: ");
                        decimal costperhead = Decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the total cost of the outing: ");
                        double outingcost = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the outing type:\n" +
                            "1. Golf" +
                            "2. Bowling" +
                            "3. Skiing" +
                            "4. Concert ");
                        int type = int.Parse(Console.ReadLine());
                        OutingType outingtype = (OutingType)type;

                        Outing userOuting = new Outing(people, date, costperhead, outingcost, outingtype);
                        outingRepo.AddOutingToList(userOuting);

                        Console.WriteLine("\n Would you like to add another outing? y/n");
                        string response = Console.ReadLine();
                        response = response.ToLower();
                        if (response == "y") { }
                        else if (response == "n")
                        {
                            break;
                        }
                    }
                }

                if (option == 3)
                {
                    double costTotal = 0;
                    foreach (var outing in outings)
                    {
                        costTotal += outing.OutingCost;
                    }
                    Console.WriteLine(costTotal);
                }

                if(option == 4)
                {
                    while(true)
                    {
                        Console.WriteLine("Enter the number of the event type whose cost you would like to check:\n" +
                       "\t 1. Golf \n" +
                       "\t 2. Bowling \n" +
                       "\t 3. Skiing \n" +
                       "\t 4. Concert \n");

                        string inputAsString = Console.ReadLine();
                        int inputAsInt = int.Parse(inputAsString);
                        
                        if (inputAsInt == 1)
                        {
                            foreach(Outing outing in outings)
                            {
                                if(outing.Type == (OutingType)inputAsInt)
                                {
                                    double costOfGolf = 0;
                                    costOfGolf = costOfGolf + outing.OutingCost;
                                    Console.WriteLine(costOfGolf);
                                }
                            }
                        }

                        else if (inputAsInt == 2)
                        {
                            foreach(Outing outing in outings)
                            {
                                if (outing.Type == (OutingType)inputAsInt)
                                {
                                    double costOfBowling = 0;
                                    costOfBowling = costOfBowling + outing.OutingCost;
                                    Console.WriteLine(costOfBowling);
                                }
                            }
                        }

                        else if (inputAsInt == 3)
                        {
                            foreach(Outing outing in outings)
                            {
                                if (outing.Type == (OutingType)inputAsInt)
                                {
                                    double costOfSkiing = 0;
                                    costOfSkiing = costOfSkiing + outing.OutingCost;
                                    Console.WriteLine(costOfSkiing);
                                }
                            }
                        }

                        else if (inputAsInt == 4)
                        {
                            foreach(Outing outing in outings)
                            {
                                if (outing.Type == (OutingType)inputAsInt)
                                {
                                    double costOfConcert = 0;
                                    costOfConcert = costOfConcert + outing.OutingCost;
                                    Console.WriteLine(costOfConcert);
                                }
                            }
                        }
                        Console.WriteLine("\n Would you like to see another outing cost? y/n");
                        string response = Console.ReadLine();
                        response = response.ToLower();
                        if (response == "y") { }
                        else if (response == "n")
                        {
                            break;
                        }
                    }
                }

                if(option == 5)
                {
                    break;
                }
            }
        }
    }
}
